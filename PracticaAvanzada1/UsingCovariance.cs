using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAvanzada1
{
    public class UsingCovariance
    {
        public static void ShowList(List<Persona> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        //Covariance
        public static void ShowList(IEnumerable<Persona> covariance)
        {
            foreach (var item in covariance)
            {
                Console.WriteLine(item);
            }
        }

        //Contravariance
        public static void AssignSurgeon(Action<Cirujano> cirujano)
        {
            Cirujano p = new Cirujano();
            cirujano(p);
        }

    }
}
