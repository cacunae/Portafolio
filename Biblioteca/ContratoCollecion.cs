using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class ContratoCollecion
    {




        public static List<Contrato> lista = new List<Contrato>();


        public static void RegistrarContrato(Contrato contrato)
        {

            lista.Add(contrato);
        }


        public static Contrato BuscarContrato(string cod)
        {
            Contrato contrato = new Contrato();
            //var detecta tipo cliente
            foreach (var item in lista)
            {
                if (item.NContrato.Equals(cod))
                {
                    contrato = item;
                    break;
                }
            }
            return contrato;
        }




        public static bool EliminarContrato(string cod)
        {
            bool elimino = false;
            Contrato contrato = new Contrato();
            foreach (var objeto in lista)
            {
                if (objeto.NContrato.Equals(cod))
                {
                    contrato = objeto;
                    elimino = true;
                    break;
                }
            }
            if (elimino)
            {
                lista.Remove(contrato);
            }
            return elimino;
        }



        public static bool ModificarContrato(Contrato contrato)
        {
            bool modifico = false;
           
            foreach (var item in lista)
            {
                if (item.NContrato.Equals(contrato.NContrato))
                {
                    lista.Remove(item);
                    lista.Add(contrato);
                    modifico = true;
                    break;
                }
            }
            return modifico;

        }


    }
}
