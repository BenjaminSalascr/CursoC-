using System;

namespace ConsolaTarea3
{
    public class Contacto
    {
        //1. Definir una clase Contacto con las siguientes propiedades (todas del tipo string):
        //a.Abreviatura estado
        //b.Nombre del estado
        //c.Nombre de la organización
        //d.Teléfono
        #region Contructores
        public Contacto()
        {
            CAbrEstad = "";
            CNomEstad = "";
            CNomOrgan = "";
            CTelefono = "";
        }
        public Contacto(string cAbrEstad, string cNomEstad, string cNomOrgan, string cTelefono)
        {
            CAbrEstad = cAbrEstad;
            CNomEstad = cNomEstad;
            CNomOrgan = cNomOrgan;
            CTelefono = cTelefono;
        }
        #endregion

        #region Datos privados
        // Campos o datos privados
        protected string _cAbrEstad;
        protected string _cNomEstad;
        protected string _cNomOrgan;
        protected string _cTelefono;
        #endregion

        #region Propiedades de la clase Contacto
        /// <summary>
        /// Abreviatura estado
        /// </summary>
        public string CAbrEstad
        {
            get { return _cAbrEstad; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _cAbrEstad = "";
                }
                else
                {
                    _cAbrEstad = value;
                }
            }

        }

        /// <summary>
        /// Nombre del estado
        /// </summary>
        public string CNomEstad
        {
            get { return _cNomEstad; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _cNomEstad = "";
                }
                else
                {
                    _cNomEstad = value;
                }
            }

        }

        /// <summary>
        /// Nombre de la organización
        /// </summary>
        public string CNomOrgan
        {
            get { return _cNomOrgan; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _cNomOrgan = "";
                }
                else
                {
                    _cNomOrgan = value;
                }
            }

        }

        /// <summary>
        /// Teléfono
        /// </summary>
        public string CTelefono
        {
            get { return _cTelefono; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _cTelefono = "";
                }
                else
                {
                    _cTelefono = value;
                }
            }

        }
        #endregion

    }
}
