using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebaseRepository;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirebaseActions firebaseActions = new FirebaseActions();

            //var result = firebaseActions.Insert();
            //var result = firebaseActions.Update("1");

            //firebaseActions.GetAll();
            firebaseActions.GetWithParamenter("1");
            Console.ReadKey();
        }
    }
}
