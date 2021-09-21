using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Aguila : IAnimal
    {
        public void Comida()
        {
            Console.WriteLine("Serpientes");
        }

        public int EdadHumana()
        {
            Console.WriteLine("10 años por uno de un humano");
            return 0;
        }

        public void Moverse()
        {
            Console.WriteLine("Vuela");
        }
    }
}
