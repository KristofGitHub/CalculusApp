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
    /// Логика взаимодействия для StartTheGame.xaml
    /// </summary>
    public partial class StartTheGame : Window
    {
        static int trueAnswerCounter = 0; 
        static int tryNumb;
        static int count = 0;
        static Boolean simple = false;
        static Boolean middle = false;
        static Boolean strong = false;

        public StartTheGame(int tryNum)
        {
            InitializeComponent();
            tryNumb = tryNum;
            int tryNumber = tryNumb;

            foreach (UIElement el in MainRoot.Children)
            {                                                           // Обращаемся к нашей сетке кнопок (списку) MainRoot и
                if (el is Button)                                       // через цикл foreach добавляем к каждой кнопке обработчик
                {                                                       // событий. Условие: является ли нажатый объект объектом
                    textLabel.Text = "Выберите уровень сложности";
                    ((Button)el).Click += (sender, e) => tryNumber = Button_Click(sender, e, tryNumber); ;
                }                                                       // класса Button. Обращаемся к свойству Click и вешаем
            }
        }

        public string GetTask(int min, int max)
        {
            string plusOrMinus;
            Random rnd = new Random();
            int valueSimpleFirstInt = rnd.Next(min, max);
            int valueSimpleSecondInt = rnd.Next(min, max);
            int plusOrMinusInt = new Random().Next(0, 2);
            int result;

            if (plusOrMinusInt == 0)
            {
                plusOrMinus = "+";
                result = valueSimpleFirstInt + valueSimpleSecondInt;
            }
            else
            {
                plusOrMinus = "-";
                result = valueSimpleFirstInt - valueSimpleSecondInt;
            }

            textLabel.Text = valueSimpleFirstInt.ToString() + " " + plusOrMinus + " (" + valueSimpleSecondInt.ToString() + ") = ";
            return textLabel.Text;
        } // Конец метода получения Задания

        private int Button_Click(object sender, RoutedEventArgs e, int tryNumber)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if ((trueAnswerCounter == 0) && (simple == false) && (middle == false) && (strong == false))
            {
                if (str == "AC")
                {
                    if (textLabel.Text.Length == 10) { }
                    else textLabel.Text = textLabel.Text.Substring(0, textLabel.Text.Length - 1);
                }
                else if (str == "ПРОВЕРКА") { }
                else if (str == "Простой") { textLabel.Text = GetTask(-99, -1); simple = true; }
                else if (str == "Средний") { textLabel.Text = GetTask(-999, -10); middle = true; }
                else if (str == "Сложный") { textLabel.Text = GetTask(-9999, -100); strong = true; }
                else if (str == "Следующий") { }
                else if (str == "МЕНЮ") 
                {
                    MainWindow main = new MainWindow();
                    tryNumber = tryNumb;
                    trueAnswerCounter = 0;
                    simple = false;
                    middle = false;
                    strong = false;
                    main.Show();
                    this.Hide();
                }
                else textLabel.Text += str;
                return tryNumber;
            }
            else if (simple == true) ////////////  SIMPLE   ////////////////////////////////////////////////////////////////////////////
            {
                if (str == "AC")
                {
                    if (textLabel.Text.Length == 10) { }
                    else textLabel.Text = textLabel.Text.Substring(0, textLabel.Text.Length - 1);
                }
                else if (str == "ПРОВЕРКА")
                {
                    string value = new DataTable().Compute(textLabel.Text, null).ToString();
                    textLabel.Text = value;
                    if (value == "True") { textLabel.Text = $" Правильно! Верных ответов: {trueAnswerCounter = trueAnswerCounter + 1}"; }
                    else
                    {
                        tryNumber--; textLabel.Text = $" Неправильно... Осталось попыток: {tryNumber}";
                        if (tryNumber <= 0)
                        {
                            textLabel.Text = "Вы проиграли. Для старта выбирите уровень.";
                            tryNumber = tryNumb;
                            trueAnswerCounter = 0;
                            simple = false;
                            middle = false;
                            strong = false;
                        }
                    }
                    if (trueAnswerCounter >= 10)
                    {
                        textLabel.Text = "Вы прошли уровень!";
                        tryNumber = tryNumb;
                        trueAnswerCounter = 0;
                        simple = false;
                        middle = false;
                        strong = false;
                    }
                }
                else if (str == "Следующий") { textLabel.Text = GetTask(-99, -1); }
                else if (str == "Простой") { }
                else if (str == "Средний") { }
                else if (str == "Сложный") { }
                else if (str == "МЕНЮ") 
                {
                    MainWindow main = new MainWindow();
                    tryNumber = tryNumb;
                    trueAnswerCounter = 0;
                    simple = false;
                    middle = false;
                    strong = false;
                    main.Show();
                    this.Hide();
                }
                else textLabel.Text += str;
                return tryNumber;
            }
            else if (middle == true) ////////////  MIDDLE   ///////////////////////////////////////////////////////////////////////////////
            {
                if (str == "AC")
                {
                    if (textLabel.Text.Length == 10) { }
                    else textLabel.Text = textLabel.Text.Substring(0, textLabel.Text.Length - 1);
                }
                else if (str == "ПРОВЕРКА")
                {
                    string value = new DataTable().Compute(textLabel.Text, null).ToString();
                    textLabel.Text = value;
                    if (value == "True") { textLabel.Text = $" Правильно! Верных ответов: {trueAnswerCounter = trueAnswerCounter + 1}"; }
                    else
                    {
                        tryNumber--; textLabel.Text = $" Неправильно... Осталось попыток: {tryNumber}";
                        if (tryNumber <= 0)
                        {
                            textLabel.Text = "Вы проиграли. Для старта выбирите уровень.";
                            tryNumber = tryNumb;
                            trueAnswerCounter = 0;
                            simple = false;
                            middle = false;
                            strong = false;
                        }
                    }
                    if (trueAnswerCounter >= 10)
                    {
                        textLabel.Text = "Вы прошли уровень!";
                        tryNumber = tryNumb;
                        trueAnswerCounter = 0;
                        simple = false;
                        middle = false;
                        strong = false;
                    }
                }
                else if (str == "Следующий") { textLabel.Text = GetTask(-999, -10); }
                else if (str == "Простой") { }
                else if (str == "Средний") { }
                else if (str == "Сложный") { }
                else if (str == "МЕНЮ")
                {
                    MainWindow main = new MainWindow();
                    tryNumber = tryNumb;
                    trueAnswerCounter = 0;
                    simple = false;
                    middle = false;
                    strong = false;
                    main.Show();
                    this.Hide();
                }
                else textLabel.Text += str;
                return tryNumber;
            }
            else if (strong == true)////////////  STRONG   /////////////////////////////////////////////////////////////////////////////////////////////
            {
                if (str == "AC")
                {
                    if (textLabel.Text.Length == 10) { }
                    else textLabel.Text = textLabel.Text.Substring(0, textLabel.Text.Length - 1);
                }
                else if (str == "ПРОВЕРКА")
                {
                    string value = new DataTable().Compute(textLabel.Text, null).ToString();
                    textLabel.Text = value;
                    if (value == "True") { textLabel.Text = $" Правильно! Верных ответов: {trueAnswerCounter = trueAnswerCounter + 1}"; }
                    else
                    {
                        tryNumber--; textLabel.Text = $" Неправильно... Осталось попыток: {tryNumber}";
                        if (tryNumber <= 0)
                        {
                            textLabel.Text = "Вы проиграли. Для старта выбирите уровень.";
                            tryNumber = tryNumb;
                            trueAnswerCounter = 0;
                            simple = false;
                            middle = false;
                            strong = false;
                        }
                    }
                    if (trueAnswerCounter >= 10)
                    {
                        textLabel.Text = "Вы прошли уровень!";
                        tryNumber = tryNumb;
                        trueAnswerCounter = 0;
                        simple = false;
                        middle = false;
                        strong = false;
                    }
                }
                else if (str == "Следующий") { textLabel.Text = GetTask(-9999, -100); }
                else if (str == "Простой") { }
                else if (str == "Средний") { }
                else if (str == "Сложный") { }
                else if (str == "МЕНЮ") 
                {
                    MainWindow main = new MainWindow();
                    tryNumber = tryNumb;
                    trueAnswerCounter = 0;
                    simple = false;
                    middle = false;
                    strong = false;
                    main.Show();
                    this.Hide();
                }
                else textLabel.Text += str;
                return tryNumber;
            }
            else textLabel.Text += str;
            return tryNumber;
        }
    }
}
