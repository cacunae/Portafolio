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

            cbo_actividad.ItemsSource = Enum.GetValues(typeof(ActividadEmpresa));
            cbo_tipo.ItemsSource = Enum.GetValues(typeof(TipoEmpresa));
            cbo_tipo1.ItemsSource = Enum.GetValues(typeof(TipoEmpresa));

            
        }



        private void Tile_Click(object sender, RoutedEventArgs e)
        {

        }

       

        private void Usuarios_Click_1(object sender, RoutedEventArgs e)
        {
            AgregarCliente1.IsOpen = true;
        }

        private async void B_Agregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_rut.Text == "")
                {
                    MessageBox.Show("Hacen falta campor por llenar");
                }
                else
                {
                    Cliente cliente = new Cliente();
                    cliente.nombre = txt_nombre.Text;
                    cliente.rut = txt_rut.Text;
                    cliente.telefono = txt_telefono.Text;
                    cliente.razon = txt_razon.Text;
                    cliente.mail = txt_mail.Text;
                    cliente.direccion = txt_direccion.Text;
                    cliente.actividad = cbo_actividad.SelectedItem.ToString();
                    cliente.tipo = cbo_tipo.SelectedItem.ToString();
                    ClienteColeccion.RegistrarCliente(cliente);
                    txt_box.Text = txt_box.Text + "nombre :" + cliente.nombre + " Rut :" + cliente.rut  ;
                    await this.ShowMessageAsync("Exito...!", "Datos guardados correctamente");

                }
            }
            catch (Exception ex)
            {
                //Si se produce un error de ingreso arrojará un mensaje
                MessageBox.Show("Error:" + ex.Message);
            }


             vaciar();

        }

        private  void vaciar()
        {
            txt_rut.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_mail.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_razon.Text = string.Empty;
            txt_rut.Focus();
        }


        private void Txt_rut_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Txt_nombre_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private async void B_buscar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Cliente cliente = new Cliente();
                cliente = ClienteColeccion.BuscarCliente(txt_rut.Text);
                
                if (cliente.rut.Length > 0)
                {
                    txt_rut.Text = cliente.rut;
                    txt_nombre.Text = cliente.nombre;
                    txt_mail.Text = cliente.mail;
                    txt_direccion.Text = cliente.direccion;
                    txt_telefono.Text = cliente.telefono;
                    txt_razon.Text = cliente.razon;
                    await this.ShowMessageAsync("Exito...!", "Datos encontrados correctamente");
                }
                else
                {
                    await this.ShowMessageAsync("Error...!", "Datos no encontrados correctamente");
                    vaciar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


        }

        private async void B_eliminar_Click(object sender, RoutedEventArgs e)
        {
           try
            {

                if (txt_rut.Text == "")
                {
                    MessageBox.Show("Hacen falta campor por llenar");
                }
                else
                {
                    bool elimino = ClienteColeccion.EliminarCliente(txt_rut.Text);
                    if (elimino)
                    {
                        await this.ShowMessageAsync("Exito...!", "Cliente Eliminado");
                        vaciar();
                    }
                    else
                    {
                        await this.ShowMessageAsync("Error...!", " No has podido eliminar el cliente  ");
                    }

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void B_refrescar_Click(object sender, RoutedEventArgs e)
        {
            vaciar();
        }

        private void B_calcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                double valor = 28000;
                double uf = 0;
                double total = 0;
                int asistentes = int.Parse(txt_asistentes.Text);
                int personal = int.Parse(txt_personalA.Text);

                if (asistentes < 20)
                {
                    uf = uf + 3;
                }
                else if (asistentes < 50)
                {
                    uf = uf + 5;
                }
                else if (asistentes < 70)
                {
                    uf = uf + 7;
                }
                else if (asistentes < 90)
                {
                    uf = uf + 9;
                }
                if (personal == 2)
                {
                    uf = uf + 2;
                }
                else if (personal == 3)
                {
                    uf = uf + 3;
                }
                else if (personal == 4)
                {
                    uf = uf + 3.5;
                }
                else if (personal > 4)
                {
                    uf = uf + 3.5;
                }




                total = valor * uf;
                txt_total.Text = total.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
           

        }

        private void CalcularContrato_Click(object sender, RoutedEventArgs e)
        {
            CalculoValor.IsOpen = true;

        }

        private async void B_AgregarC_Click(object sender, RoutedEventArgs e)
        {



            try
            {
                if (txt_creacion.Text == "")
                {
                    MessageBox.Show("Hacen falta campor por llenar");
                }
                else
                {
                    Contrato contrato = new Contrato();
                    contrato.Creacion = txt_creacion.Text;
                    contrato.Termino = txt_termino.Text;
                    contrato.hInicio = txt_horaInicio.Text;
                    contrato.hTermino = txt_horaTermino.Text;
                    contrato.Direccion = txt_direccion1.Text;
                    contrato.Vigente = txt_vigente.Text;
                    contrato.Observacion = txt_observaciones.Text;
                    contrato.tipo = cbo_tipo1.SelectedItem.ToString();
                    DateTime Hoy = DateTime.Today;
                    DateTime Hora = DateTime.Now;
                    //txtHora.Text = DateTime.Now.ToString("hh:mm") ;


                    string fecha_actual = Hoy.ToString("yyyyMMdd");
                    string hora_actual = Hora.ToString("hhmm");
                    contrato.NContrato = fecha_actual+hora_actual ;
                    ContratoCollecion.RegistrarContrato(contrato);
                    txt_num.Text = contrato.NContrato;
                    await this.ShowMessageAsync("Exito...!", "Datos guardados correctamente");

                }
            }
            catch (Exception ex)
            {
                //Si se produce un error de ingreso arrojará un mensaje
                MessageBox.Show("Error:" + ex.Message);
            }


            vaciar();



        }

        private void AgregarContratos_Click(object sender, RoutedEventArgs e)
        {
            AgregarContrato.IsOpen = true;
        }

        private void Salir1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void B_BuscarC_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Contrato contrato = new Contrato();
                contrato = ContratoCollecion.BuscarContrato(txt_num.Text);

                if (contrato.NContrato == "")
                {
                    await this.ShowMessageAsync("Error...!", "Datos no encontrados correctamente");
                    vaciar();
                   
                }
                else
                {
                    txt_num.Text = contrato.NContrato;
                    txt_creacion.Text = contrato.Creacion;
                    txt_termino.Text = contrato.Termino;
                    txt_horaInicio.Text = contrato.hInicio;
                    txt_horaTermino.Text = contrato.hTermino;
                    txt_direccion1.Text = contrato.Direccion;
                    txt_vigente.Text = contrato.Vigente;
                    txt_observaciones.Text = contrato.Observacion;
                    await this.ShowMessageAsync("Exito...!", "Datos encontrados correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void ListadoCliente_Click(object sender, RoutedEventArgs e)
        {
            listadoCliente listadoC = new listadoCliente();
            listadoC.Owner = this;
            listadoC.Show();

        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            listadoContrato list = new listadoContrato();
            list.Owner = this;
            list.Show(); 
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
    }
}
