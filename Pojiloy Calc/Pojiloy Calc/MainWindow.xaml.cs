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

namespace Pojiloy_Calc

{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool clickon = false;
        int Action;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.music_pojiloy);


        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "0";
        }

        private void Button_Click_Action_1(object sender, RoutedEventArgs e)
        {

            if (clickon == false)
            {
                label.Content = TextBox.Text;
                TextBox.Text = null;
                Action = 1;
            }

            clickon = true;


        }

        private void Button_Click_Action_2(object sender, RoutedEventArgs e)
        {

            if (clickon == false)
            {
                label.Content = TextBox.Text;
                TextBox.Text = null;
                Action = 2;
            }

            clickon = true;
        }


        private void Button_Click_Action_3(object sender, RoutedEventArgs e)
        {

            if (clickon == false)
            {
                label.Content = TextBox.Text;
                TextBox.Text = null;
                Action = 3;
            }

            clickon = true;
        }

        private void Button_Click_Action_4(object sender, RoutedEventArgs e)
        {

            if (clickon == false)
            {
                label.Content = TextBox.Text;
                TextBox.Text = null;
                Action = 4;
            }

            clickon = true;
        }

        private void Button_Click_Action_5(object sender, RoutedEventArgs e)
        {
            string a;
            decimal aa = 0, b = 1;
            try
            {
                a = label.Content.ToString();
                aa = Convert.ToDecimal(a);
                b = Convert.ToDecimal(TextBox.Text);
            }
            catch
            {
                MessageBox.Show("ты че с калькулятором делаешь падла");
                label.Content = null;
                TextBox.Text = null;
                return;
            }
            decimal answer = 0;
            switch (Action)
            {
                case 1:
                    answer = aa * b;
                    break;
                case 2:
                    try
                    {
                        answer = aa / b;
                    }
                    catch
                    {
                        MessageBox.Show("ты че на ноль делишь, падла");
                    }
                    break;
                case 3:
                    answer = aa + b;
                    break;
                case 4:
                    answer = aa - b;
                    break;



            }
            label.Content = null;
            TextBox.Text = Convert.ToString(answer);
            clickon = false;



        }



        private void Button_Click_Action(object sender, RoutedEventArgs e)
        {
            TextBox.Text = null;
            label.Content = null;
        }



        private void Button_Click_Action6(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextBox.Text[0] == '-') TextBox.Text = TextBox.Text.Trim(new Char[] { '-' });
                else TextBox.Text = '-' + TextBox.Text;
            }
            catch
            {
                TextBox.Text = null;
                MessageBox.Show("ты в адеквате вообще?");
            }

        }

        private void Button_Click_Action8(object sender, RoutedEventArgs e)
        {
            int ind = TextBox.Text.Length - 1;
            if (ind > 0)
            {
                TextBox.Text = TextBox.Text.Remove(ind);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Play();

        }

    }
}







