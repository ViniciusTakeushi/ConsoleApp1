using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp;

namespace FirebaseRepository
{
    public class FirebaseActions
    {
        private IFirebaseConfig _firebaseConfig;
        private IFirebaseClient _firebaseClient;

        public FirebaseActions(string url = "", string appSecret = "")
        {
            _firebaseConfig = new FirebaseConfig
            {
                AuthSecret = appSecret,
                BasePath = url
            };

            _firebaseClient = new FirebaseClient(_firebaseConfig);
        }

        public bool Insert()
        {
            var response = _firebaseClient.Set("Pessoa/2", new Person()
            {
                Nome = "Teste7",
                Sobrenome = "Teste 8"
            });

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;
        }

        public bool Update(string id)
        {
            var result =  _firebaseClient.Update("Pessoa/" + id, new Person()
            {
                Nome = "Teste 3",
                Sobrenome = "Teste 4"
            });

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;
        }

        public void GetAll()
        {
            var result = _firebaseClient.Get("Pessoa");

            var list = result.ResultAs<List<Person>>();
        }

        public void GetWithParamenter(string id)
        {
            var result = _firebaseClient.Get("Pessoa/" + id);
        }

        public bool Delete(string id)
        {
            var result = _firebaseClient.Delete("Pessoa/" + id);

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;
        }
    }

    public class Person
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }
    }
}
