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

namespace Triangle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(A_tb.Text);
                int B = Convert.ToInt32(B_tb.Text);
                int C = Convert.ToInt32(C_tb.Text);

                if (A <= 0 || B <= 0 || C <= 0)
                {
                    ans_tb.Text = "Ошибка - стороны не должны быть отрицательными или равны нулю";
                    ans_tb.Foreground = Brushes.Red;
                }
                else if (A >= B + C || B >= A + C || C >= B + A)
                {
                    ans_tb.Text = "Ошибка - одна сторона больше суммы других сторон или равна им";
                    ans_tb.Foreground = Brushes.Red;
                }
                else if (A == B && B == C && A == C)
                {
                    ans_tb.Text = "Равносторонний";
                    ans_tb.Foreground = Brushes.Black;
                }
                else if (A == B || A == C || B == C)
                {
                    ans_tb.Text = "Равнобедренный";
                    ans_tb.Foreground = Brushes.Black;
                }
                else
                {
                    ans_tb.Text = "Разносторонний";
                    ans_tb.Foreground = Brushes.Black;
                }
            }
            catch
            {
                ans_tb.Text = "Ошибка - не треугольник!";
                ans_tb.Foreground = Brushes.Red;
            }

            grid_for_answer.Visibility = Visibility.Visible;
            grid_main.Visibility = Visibility.Hidden;
            
        }


        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            grid_main.Visibility = Visibility.Visible;
            grid_for_answer.Visibility = Visibility.Hidden;
            
        }
    }
}
