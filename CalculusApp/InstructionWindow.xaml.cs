using System;
using System.Data;
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
using System.Security.Cryptography;

namespace CalculusApp
{
    /// <summary>
    /// Логика взаимодействия для InstructionWindow.xaml
    /// </summary>
    public partial class InstructionWindow : Window
    {
        public InstructionWindow()
        {
            InitializeComponent();

        }
        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            //StartTheGame startTheGame = new StartTheGame(3);
            //startTheGame.Show();
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
    }
}
