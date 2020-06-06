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
using System.Windows.Shapes;

namespace EnvioDatosEntreFormularios
{
    /// <summary>
    /// Lógica de interacción para Externa.xaml
    /// </summary>
    public partial class Externa : Window
    {
        public string dato = "";
        public delegate void pasar(string datos);
        public event pasar pasando;
        public Externa()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, RoutedEventArgs e)
        {
            dato = TxtBox.Text;
            pasando(dato);
            this.Close();
        }
    }
}
