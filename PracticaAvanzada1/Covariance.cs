using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAvanzada1
{
    public class Covariance
    {
    }

    public class Persona
    {
        public string Cargo { get; set; }
        public string Name { get; set; }
    }

    public class Medico : Persona
    {
        public int uid { get; set; }
    }

    public class Pediatra : Medico { }

    public class Cirujano : Medico { }
}
