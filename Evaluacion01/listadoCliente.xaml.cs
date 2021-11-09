using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using Biblioteca;

namespace Evaluacion01
{
    /// <summary>
    /// Lógica de interacción para listadoCliente.xaml
    /// </summary>
    public partial class listadoCliente : Window
    {


        public listadoCliente()


        {
            
            InitializeComponent();
            cbo_act.ItemsSource = Enum.GetValues(typeof(ActividadEmpresa));
            cbo_tipo.ItemsSource = Enum.GetValues(typeof(TipoEmpresa));


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridCliente.ItemsSource = ClienteColeccion.lista;

        }

        private void Filtrar_Click(object sender, RoutedEventArgs e)
        {


           

        }

        private void Cbo_tipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
