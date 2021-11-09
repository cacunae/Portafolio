using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Contrato
    {



        public Contrato()
        {
            this.Init();

        }

        private void Init()
        {
            NContrato = string.Empty;
            Creacion = string.Empty;
            Termino = string.Empty;
            hInicio = string.Empty;
            hTermino = string.Empty;
            Direccion = string.Empty;
            Vigente = string.Empty;
            tipo = string.Empty;
            Observacion = string.Empty;
            rutc = string.Empty;
        }

        public string rutc { get; set; }
        public string NContrato { get; set; }
        public string Creacion { get; set; }
        public string Termino { get; set; }
        public string hInicio { get; set; }
        public string hTermino { get; set; }
        public string Direccion { get; set; }
        public string Vigente { get; set; }
        public string tipo { get; set; }
        public string Observacion { get; set; }

        public string InformacionCliente()
        {
            StringBuilder sb = new StringBuilder();
           

            return sb.ToString();

        }






    }
}
