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
            idd = string.Empty;
            descripcion = string.Empty;
            inicio = string.Empty;
            fin = string.Empty;
            estado = 0;
        }

        public string idd { get; set; }

        public string descripcion { get; set; }

        public string inicio { get; set; }
        public string fin { get; set; }

        public int estado { get; set; }

        public string InformacionContrato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("ID: " + idd);
            sb.Append("Descripción: " + descripcion);
            sb.Append("inicio :" + inicio);
            sb.Append("fin: " + fin);
            sb.Append("estado: " + estado);

            return sb.ToString();

        }






    }
}
