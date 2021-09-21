using System;
using System.IO;
using System.Net;
using System.Text.Json;

namespace ConsolaTarea4
{
    public class CLSConsumoAPI<T>
    {
        Uri _direccionServicio;
        HttpWebRequest _request;

        public CLSConsumoAPI(Uri direccion)
        {
            if (direccion == null)
            {
                throw new NullReferenceException("_direccionServicio");
            }
            this._direccionServicio = direccion;
        }

        private void InicializarRequest()
        {
            this._request = WebRequest.Create(this._direccionServicio) as HttpWebRequest;
            if (this._request == null)
            {
                throw new NullReferenceException("_request");
            }
        }

        public T ObtenerResultado()
        {
            this.InicializarRequest();

            this._request.Method = "GET";
            return this.LeerResultado();
        }

        private T LeerResultado()
        {
            T resultadoOperacion;

            var response = this._request.GetResponse() as HttpWebResponse;

            if (response.ContentLength == 0)
            {
                throw new Exception("Sin contenido");
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Se produjo una inconsistencia al invocar al servicio");
            }

            using (Stream resultado = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(resultado);

                string contenido = reader.ReadToEnd();
                resultadoOperacion = JsonSerializer.Deserialize<T>(contenido);
            }

            return resultadoOperacion;
        }
    }
}
