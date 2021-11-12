using Biblioteca;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Windows;

namespace Evaluacion01
{
    /// <summary>
    /// Lógica de interacción para listadoContrato.xaml
    /// </summary>
    public partial class listadoContrato : Window
    {
        public List<Contrato> listaContratos = new List<Contrato>();
        public List<Contrato> listaContratosVigentes = new List<Contrato>();
        public List<Contrato> listaContratosVencidos = new List<Contrato>();

        OracleConnection conn = new OracleConnection("Data source = orcl; user id = cris; password = 1234");

        public listadoContrato()
        {

            InitializeComponent();
            cbEstado.ItemsSource = Enum.GetValues(typeof(Estado));

        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
            OracleCommand commands = new OracleCommand("SELECT * FROM CONTRATOS", conn);
            OracleDataReader reader = commands.ExecuteReader();

            Console.WriteLine("READER: ", reader);
            if (reader.HasRows)
            {
                foreach (var item in reader)
                { 
                    Contrato tmpContrato = new Contrato();
                    int estado;

                    tmpContrato.idd = reader["IDD"].ToString();
                    tmpContrato.descripcion = reader["DESCRIPCION"].ToString();
                    tmpContrato.inicio = reader["INICIO"].ToString();
                    tmpContrato.fin = reader["FIN"].ToString();
                    tmpContrato.estado = reader.GetInt32(4);


                    Console.WriteLine("Contrato temporal " + tmpContrato.InformacionContrato());

                    listaContratos.Add(tmpContrato);

                }

            }

            gridcontrato.ItemsSource = listaContratos;
            conn.Close();

            

            



        }


        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            if (cbEstado.SelectedItem.ToString() == "vigente")
            {
   
                gridcontrato.Items.Clear();
                conn.Open();
                OracleCommand commandsFilter = new OracleCommand("SELECT * FROM CONTRATOS WHERE ESTADO = 1", conn);
                OracleDataReader filterReader = commandsFilter.ExecuteReader();
                if (filterReader.HasRows)
                {
                    foreach (var item in filterReader)
                    {
                        Contrato tmpContratoFilterVigente = new Contrato();


                        tmpContratoFilterVigente.idd = filterReader["IDD"].ToString();
                        tmpContratoFilterVigente.descripcion = filterReader["DESCRIPCION"].ToString();
                        tmpContratoFilterVigente.inicio = filterReader["INICIO"].ToString();
                        tmpContratoFilterVigente.fin = filterReader["FIN"].ToString();
                        tmpContratoFilterVigente.estado = filterReader.GetInt32(4);


                        Console.WriteLine("Contrato temporal " + tmpContratoFilterVigente.InformacionContrato());

                        listaContratosVigentes.Add(tmpContratoFilterVigente);

                    }
                }
                gridcontrato.ItemsSource = listaContratosVigentes;
                conn.Close();
            };

            if (cbEstado.SelectedItem.ToString() == "vencido")
            {
                gridcontrato.Items.Clear();
                conn.Open();
                OracleCommand commandsFilter = new OracleCommand("SELECT * FROM CONTRATOS WHERE ESTADO = 0", conn);
                OracleDataReader filterReader = commandsFilter.ExecuteReader();
                if (filterReader.HasRows)
                {
                    foreach (var item in filterReader)
                    {
                        Contrato tmpContratoFilterVencido = new Contrato();


                        tmpContratoFilterVencido.idd = filterReader["IDD"].ToString();
                        tmpContratoFilterVencido.descripcion = filterReader["DESCRIPCION"].ToString();
                        tmpContratoFilterVencido.inicio = filterReader["INICIO"].ToString();
                        tmpContratoFilterVencido.fin = filterReader["FIN"].ToString();
                        tmpContratoFilterVencido.estado = filterReader.GetInt32(4);


                        Console.WriteLine("Contrato temporal " + tmpContratoFilterVencido.InformacionContrato());

                        listaContratosVencidos.Add(tmpContratoFilterVencido);

                    }
                }
                gridcontrato.ItemsSource = listaContratosVencidos;
                conn.Close();
            }
        }


    }
}
