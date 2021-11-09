using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class ClienteColeccion
    {

        public static List<Cliente> lista = new List<Cliente>();

      
        public static void MostrarCliente()
        {
            
        }


        public static void RegistrarCliente(Cliente cliente)
        {
            
            lista.Add(cliente);
        }

       
        public static Cliente BuscarCliente(string rut)
        {
            Cliente cliente = new Cliente();
            
            foreach (var item in lista)
            {
                if (item.rut.Equals(rut))
                {
                    cliente = item;
                    break;
                }
            }
            return cliente;
        }




        public static bool EliminarCliente(string rut)
        {
            bool elimino = false;
            
            Cliente cliente = new Cliente();
            foreach (var objeto in lista)
            {
                if (objeto.rut.Equals(rut))
                {
                    if (cliente.lista == null)
                    {

                        cliente = objeto;
                        elimino = true;
                        break;
                    }
                }
            }
            if (elimino)
            {
                lista.Remove(cliente);
            }
            return elimino;
        }



        public static bool ModificarCliente(Cliente cliente)
        {
            bool modifico = false;
            
            foreach (var item in lista)
            {
                if (item.rut.Equals(cliente.rut))
                {
                    lista.Remove(item);
                    lista.Add(cliente);
                    modifico=true;
                    break;
                }
            }
            return modifico;

        }









    }
}
