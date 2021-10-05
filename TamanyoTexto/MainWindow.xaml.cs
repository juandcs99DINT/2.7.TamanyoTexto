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

namespace TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tamañoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton boton = (RadioButton)sender;
            // textoACambiarTextBlock.FontSize = double.Parse(boton.Tag.ToString());

            switch(boton.Tag.ToString())
            {
                case "36":
                    textoACambiarTextBlock.FontSize = 36;
                    break;
                case "48":
                    textoACambiarTextBlock.FontSize = 48;
                    break;
                case "72":
                    textoACambiarTextBlock.FontSize = 72;
                    break;
            }
        }
    }
}
