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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        } // Конец метода вывода начального Меню

        private void Button_Window_Start_The_Game_Click(object sender, RoutedEventArgs e)
        {
            string userInput = textBoxUserInput.Text;
            if (userInput.Length > 0) { 
                textBoxUserInput.ToolTip = "Какой любопытный! Cыграем в игру?";
                textBoxUserInput.Background = Brushes.Green;
            }
            StartTheGame startTheGame = new StartTheGame(3);
            startTheGame.Show();
            this.Hide();
        }
        private void Button_Test_Window_Start_The_Game_Click(object sender, RoutedEventArgs e)
        {
            string userInput = textBoxUserInput.Text;
            if (userInput.Length > 0)
            {
                textBoxUserInput.ToolTip = "Какой любопытный! Cыграем в игру?";
                textBoxUserInput.Background = Brushes.Green;
            }
            StartTheGame startTheGame = new StartTheGame(1);
            startTheGame.Show();
            this.Hide();
        }
        private void Button_Instruction_Click(object sender, RoutedEventArgs e)
        {
            string userInput = textBoxUserInput.Text;
            if (userInput.Length > 0)
            {
                textBoxUserInput.ToolTip = "Какой любопытный! Cыграем в игру?";
                textBoxUserInput.Background = Brushes.Green;
            }
            InstructionWindow getInstruction = new InstructionWindow();
            getInstruction.Show();
            this.Hide();
        }
    } // Конец главного класса Main
} // Конец приложения
