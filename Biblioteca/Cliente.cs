using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Cliente
    {

        public Cliente()
        {
            this.Init();

        }

        private void Init()
        {
            rut = string.Empty;
            nombre = string.Empty;
            mail = string.Empty;
            direccion = string.Empty;
            telefono = string.Empty;
            actividad = string.Empty;
            razon = string.Empty;
            tipo = string.Empty;
            lista = null;

        }

      
        public List<Contrato> lista = new List<Contrato>();
        public string razon { get; set; }
        public string tipo { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string actividad { get; set; }

        public string InformacionCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("--Información Cliente--"));
            sb.AppendLine(string.Format("RUT:{0}", rut));
            sb.AppendLine(string.Format("Nombre:{0}", nombre));
            sb.AppendLine(string.Format("Mail:{0}", mail));
            sb.AppendLine(string.Format("Direccion.:{0}", direccion));
            sb.AppendLine(string.Format("Telefono:{0}", telefono));
            sb.AppendLine(string.Format("Actividad:{0}", actividad));
            sb.AppendLine(string.Format("Tipo:{0}", tipo));
            sb.AppendLine(string.Format("Razon:{0}", razon));
       

            return sb.ToString();

        }


    }
}
