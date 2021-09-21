using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseTarea1
{

    public struct Persona
    {
        public string ccedula;
        public string cnombre;
        public string capellidos;
        public DateTime dFechaNaci;
    }

    public class Clase1
    {
        private string ccedula;
        private string cnombre;
        private string capellidos;
        private DateTime dFechaNaci;

        public string Ccedula { get => ccedula; set => ccedula = value; }
        public string Cnombre { get => cnombre; set => cnombre = value; }
        public string Capellidos { get => capellidos; set => capellidos = value; }
        public DateTime DFechaNaci { get => dFechaNaci; set => dFechaNaci = value; }

        public static int GetEdadPersona(DateTime FechaNacimiento)
        {
            int nedad = 0;
            DateTime dFechaHoy = DateTime.Today;
            if (dFechaHoy.Year - FechaNacimiento.Year > 0)
            {
                nedad = dFechaHoy.Year - FechaNacimiento.Year;
            }
            return nedad;
        }

        public static string RepeatString (string pcadena, int pcount)
        {
            StringBuilder cCadena = new StringBuilder();
            for (int i = 0; i < pcount; i++)
            {
                cCadena.Append(pcadena);
                cCadena.Append("\n");
            }
            return cCadena.ToString();
        }

        public static string Encrypt(char letter)
        {
            int nASCII = (int)letter;
            StringBuilder cCadenaEncriptada = new StringBuilder(nASCII.ToString());
            char cprimero;
            char cultimo;
            int nprimero = 0;
            int nultimo = 0;
            cprimero = cCadenaEncriptada[0];
            cultimo = cCadenaEncriptada[cCadenaEncriptada.Length-1];
            nprimero = nASCII + Convert.ToInt32(cultimo.ToString());
            nultimo = nASCII - Convert.ToInt32(cprimero.ToString());
            cCadenaEncriptada.Remove(0, cCadenaEncriptada.Length);
            cCadenaEncriptada.Append(Convert.ToChar(nprimero));
            cCadenaEncriptada.Append(cprimero.ToString());
            cCadenaEncriptada.Append(cultimo.ToString());
            cCadenaEncriptada.Append(Convert.ToChar(nultimo));
            return cCadenaEncriptada.ToString();
        }

    }
            
 
}
