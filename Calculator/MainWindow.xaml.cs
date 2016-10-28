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

namespace Calculator
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private String text;
        private void batton1_Click(object sender, RoutedEventArgs e)
        {
            if (batton1 != null)
            {
                textset(text += (sender as Button).Content);
            }
        }

        private double a = 0, b = 0, c = 0;
        private String _operator = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TextBox1.Text);
                textset(text = "");
                _operator += (sender as Button).Content;
            }
            catch (Exception){};
         
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "")
            {
                b = Convert.ToDouble(TextBox1.Text);
                switch (_operator)
                {
                    case "+":
                        c = a + b;
                        break;
                    case "-":
                        c = a - b;
                        break;
                    case "*":
                        c = a*b;
                        break;
                    case "/":
                        c = a/b;
                        break;

                }
                textset(text=Convert.ToString(c));
                _operator = null;
            }
        }

        private void ButtoC_Click(object sender, RoutedEventArgs e)
        {
            textset(text="");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "")
            {
                if (TextBox1.Text[0] == '-')
                {
                    textset(text = TextBox1.Text.Remove(0, 1));
                }
                else
                {
                    textset(text = '-' + TextBox1.Text);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "")
            {
                textset(text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1));
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "")
            {
                textset(text = Math.Sqrt(Convert.ToDouble(TextBox1.Text)).ToString());
            }
        }

        private void battonClick(object sender, RoutedEventArgs e)
        {
            c = a/b*100;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "")
            {
                textset(text = (1 / Convert.ToDouble(TextBox1.Text)).ToString());
            }
        }

        private void batton11Click(object sender, RoutedEventArgs e)
        {   

            if (TextBox1.Text != "")
            {   
                double a = 0;

                a = Convert.ToDouble(TextBox1.Text);

                textset(text = (a * a).ToString()); 
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            textset(text = "3,1415926535");
        }

        private void textset(String str)
        {
            
            if (str.Length < 39)
            {
                if (str.Length > 15)
                {
                    TextBox1.FontSize = 15;
                } else{TextBox1.FontSize = 20;}

                TextBox1.Text = str;
            }
        }
        private void battonznakClick(object sender, RoutedEventArgs e)
        {

            if (text != "")
            {
                try
                {
                    if (text.Contains(",") != true)
                    {
                        textset(text += ",");
                    }
                }
                catch (Exception) {}
            }
        }

    }
}
