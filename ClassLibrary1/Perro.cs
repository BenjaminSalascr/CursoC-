using ClassLibrary1.Interfaces;
using System;

namespace ClassLibrary1
{
    public class Perro : IAnimal
    {
        public void Comida()
        {
            Console.WriteLine("Super Perro");
        }

        public int EdadHumana()
        {
            Console.WriteLine("7 años por año de un humano");
            return 0;
        }

        public void Moverse()
        {
            Console.WriteLine("Camina");
        }
    }
}
