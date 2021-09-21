using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Clase que permite registrar datos personales de individuos
    /// </summary>
    public class Persona
    {
        // Miembros de la clase

        public enum TipoEdad
        {
            Anios,
            Meses
        }

        #region Constructores
        public Persona()
        {
            _identificacion = "00000";
        }
        public Persona(string identificacion, string nombre, DateTime fecha)
        {
            _identificacion = identificacion;
            _nombre = nombre;
            _fechaNacimiento = fecha;
        }
        #endregion
        #region Datos privados
        // campos o datos privados
        private string _identificacion;
        private string _nombre;
        private DateTime _fechaNacimiento;
        private string _lugarNacimiento;
        #endregion

        #region Propiedades
        public string Identificacion
        {
            get { return _identificacion; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("La identificacion no es válida");
                }
                else
                    _identificacion = value;
            }
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }


        #endregion

        #region Metodos de la clase
        // metodos o comportamiento de la clase

        /// <summary>
        /// Calcula la edad de una persona
        /// </summary>
        /// <param name="tipo">Indica si la edad a calcular es años o meses</param>
        /// <returns></returns>
        public int Edad(TipoEdad tipo)
        {
            return 0;
        }
        #endregion
    }
}
