using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAvanzada1
{

    //Declarar delegado
    public delegate void ShowData(string args);
    public class Delegates
    {
        //Action
        public void ExampleAction()
        {
            Action<string> ex = delegate (string args)
            {
                Console.WriteLine(args);
            };
            ex("olaaaaa de awa");
        }

        //Funct
        public void ExampleFunc()
        {
            Func<int,string> example = rsp => ((rsp % 3) == 0) ? "Es multiplo de 3" : "No es multiplo";
            Console.WriteLine(example(3));
        }

        //Predicate
        public void ExamplePredicate()
        {
            Predicate<int> example = rsp => ((rsp % 3) == 0) ? true : false;
            Console.WriteLine(example(3));
        }
    }
}
