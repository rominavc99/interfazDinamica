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

namespace interfazdinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BtnAceptar.Visibility = Visibility.Hidden;
            BtnCancelar.Visibility = Visibility.Hidden;
        }

        private void CbPersona_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosPersona.Children.Clear();
            

        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (CbPersona.SelectedIndex)
            {
                case 0:  //Alumno
                    grdParametrosPersona.Children.Add(new Alumno());
                    BtnAceptar.Visibility = Visibility.Visible;
                    BtnCancelar.Visibility = Visibility.Visible;
                    break;

                case 1:  //Maestro
                    grdParametrosPersona.Children.Add(new Maestro());
                    BtnAceptar.Visibility = Visibility.Visible;
                    BtnCancelar.Visibility = Visibility.Visible;
                    break;
            }


        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdParametrosPersona.Children.Clear();
            BtnAceptar.Visibility = Visibility.Hidden;
            BtnCancelar.Visibility = Visibility.Hidden;
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            grdParametrosPersona.Children.Clear();
            BtnAceptar.Visibility = Visibility.Hidden;
            BtnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
