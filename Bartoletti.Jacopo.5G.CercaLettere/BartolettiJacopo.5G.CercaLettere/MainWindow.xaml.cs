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

namespace BartolettiJacopo._5G.CercaLettere
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnVai_Click(object sender, RoutedEventArgs e)
        {
            char[] Alfabeto = "abcdefghilmnopqrstuvz".ToCharArray();
            string Panagramma = Frase.Text;
            Panagramma = Panagramma.ToLower();

            int alphabetCount = 0;

            for (int i = 0; i < Alfabeto.Length; i++)
            {
                if (Panagramma.Contains(Alfabeto[i])) alphabetCount++;
            }

            if (alphabetCount == 26)
                Risultato.Text="Si";

            Risultato.Text=("No");
        }
    }
}
