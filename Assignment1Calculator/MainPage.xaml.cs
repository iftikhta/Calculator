using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment1Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        String status = "";
        String temp = "";

        public MainPage()
        {
            this.InitializeComponent();
            
        }
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
        */
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            //string newVar = userInp.Parse(userInp.Text); This does not work, took me a an embarssing amount of time to get this right
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "4";

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "6";

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "9";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "0";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            temp = userInp.Text + " /";
            status = "/";

        }

        private void FullClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            temp = userInp.Text + " -";
            status = "-";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            temp = userInp.Text + " *";
            status = "*";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            temp = userInp.Text + " +";
            status = "+";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {

            // must ad an if status = "=", then do nothing type of code here to prevent repeated spam of +

            if (status == "=")
            {
            }
            else
            {
            headInp.Text = headInp.Text + ' ' + userInp.Text;
                String[] tempTotal = headInp.Text.Split(' ');
                for (int i = 0; i < tempTotal.Length; i++)
                {
                    if (tempTotal[i] == "+")
                    {
                        Decimal tempNum1 = Convert.ToDecimal(tempTotal[i - 1]);
                        Decimal tempNum2 = Convert.ToDecimal(tempTotal[i + 1]);
                        Decimal total = tempNum1 + tempNum2;
                        userInp.Text = Convert.ToString(total);

                    }
                    else if (tempTotal[i] == "-")
                    {
                        Decimal tempNum1 = Convert.ToDecimal(tempTotal[i - 1]);
                        Decimal tempNum2 = Convert.ToDecimal(tempTotal[i + 1]);
                        Decimal total = tempNum1 - tempNum2;
                        userInp.Text = Convert.ToString(total);
                    }
                    else if (tempTotal[i] == "/")
                    {
                        Decimal tempNum1 = Convert.ToDecimal(tempTotal[i - 1]);
                        Decimal tempNum2 = Convert.ToDecimal(tempTotal[i + 1]);
                        Decimal total = tempNum1 / tempNum2;
                        userInp.Text = Convert.ToString(total);
                    }
                    else if (tempTotal[i] == "*")
                    {
                        Decimal tempNum1 = Convert.ToDecimal(tempTotal[i - 1]);
                        Decimal tempNum2 = Convert.ToDecimal(tempTotal[i + 1]);
                        Decimal total = tempNum1 * tempNum2;
                        userInp.Text = Convert.ToString(total);
                    }


                    // Decimal tempNum1 = Convert.ToDecimal(i);
                    // Decimal tempNum2 = Convert.ToDecimal(i + 2);
                }
            }

            //userInp.Text = Total;
            status = "=";
        }
    }
}
