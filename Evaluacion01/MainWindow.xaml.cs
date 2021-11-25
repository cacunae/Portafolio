using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using Biblioteca;
using System.Data.OracleClient;

namespace Evaluacion01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {


        OracleConnection conn = new OracleConnection("Data source = orcl; user id = cris; password = 1234");

        public MainWindow()
        {
            InitializeComponent();

            cbo_Origen.ItemsSource = Enum.GetValues(typeof(Origen));
            cbo_tipoTransporte.ItemsSource = Enum.GetValues(typeof(Transporte));
            cbo_tipoLicencia.ItemsSource = Enum.GetValues(typeof(Licencia));

            
        }




        private void Txt_rut_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Salir1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
        private void ListadoCliente_Click(object sender, RoutedEventArgs e)
        {
            listadoCliente listadoC = new listadoCliente();
            listadoC.Owner = this;
            listadoC.Show();

        }



        private void cbo_tipo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        /*
        private void btnConectar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                Console.WriteLine("Version de servidor: " + conn.ServerVersion);
                Console.WriteLine("Estado de conexion: " + conn.State.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hay un error: " + ex.Message);
            }

        }
        */
        
        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {

            
            OracleCommand commands = new OracleCommand("SELECT NOMBRE, PRECIO FROM PRODUCTOS", conn);
            //conn.Open();
            OracleDataReader reader = commands.ExecuteReader();

            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("RESULTADO DEL QUERY " + reader["NOMBRE"].ToString());
                    //este es un mensaje para probar github
                }
            }   
            else
            {
                Console.WriteLine("NO SE ENCONTRARON FILAS");
            }
            
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ESTADO ANTES DE CERRAR: " + conn.State.ToString());
            conn.Close();
            Console.WriteLine("ESTADO CERRADO: " + conn.State.ToString());
        }

        private void btnAbrir_Click(object sender, RoutedEventArgs e)
        {
          conn.Open();
          Console.WriteLine("ESTADO DE LA CONEXION: " + conn.State.ToString());
        }

        private void btnContratos_Click(object sender, RoutedEventArgs e)
        {
            listadoContrato list = new listadoContrato();
            list.Owner = this;
            list.Show();
        }

        private void btnTransportista_Click(object sender, RoutedEventArgs e)
        {
            AgregarTransportista.IsOpen = true;
        }
    }
}
