using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

    /* previously repeated coments are being kept by me  atleast once incase I need to refrence them quickly for any reason*/
    public sealed partial class MainPage : Page
    {
        //last clicked operator
        String status = "";

        // temporary storage 
        String temp = "";

        //writing functions up here because its easier

        public void OnNumClick(string num)
        {   //the if status check will check if there is an operator in queue and if so, it will clear input and status
            if (status != "")
            {
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + num;
        }

        public void OnOperatorClick(string Operator)
        {
            String[] lencheck = headInp.Text.Split(' ');
            if (lencheck.Length > 1)
            {
                headInp.Text = $"{headInp.Text} {userInp.Text} {Operator}";
                status = "-";
            }
            else
            {
                // creating a end decimal checker/remover

                if (userInp.Text.EndsWith("."))
                {
                    // cutt off the decimal
                    userInp.Text = userInp.Text.TrimEnd('.');
                }
                temp = userInp.Text + $" {Operator}";
                headInp.Text += temp;
                status = Operator;
            }
        }


        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("1");
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("2");
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("3");
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("4");

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("5");
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("6");
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("7");
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("8");
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("9");
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            OnNumClick("0");
        }


        // operators below, known bugs fixed
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            OnOperatorClick("/");
        }

        private void FullClear_Click(object sender, RoutedEventArgs e)
        {
            userInp.Text = "";
            headInp.Text = "";
            status = "";
            temp = "";

        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            OnOperatorClick("-");
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            OnOperatorClick("*");
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            OnOperatorClick("+");
        }

        // the Equals_Click function could be partially refactored but I think its totally extra and wont accomplish much
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (status == "=")
            {
         

            }
            else if (headInp.Text.Split(' ').Length == 1) 
            {

            }      
            else
            {
            headInp.Text = headInp.Text + " "  + userInp.Text;
               // creating a StringCollection to store String[] in
               StringCollection fullStringCollection = new StringCollection();
               // String[] splitHeader stores the split up headInp.Text so I can loop through it
               String[] splitHeader = headInp.Text.Split(' ');
               // I used addRange, to add the String[] I created to the string collection
               fullStringCollection.AddRange(splitHeader);

                // must make below line only run if there is more than  1 number
                
                Decimal sumTotal = Convert.ToDecimal(fullStringCollection[0]);
                

                for (int i = 1; i < fullStringCollection.Count; i++)
                    {
                        if (fullStringCollection[i] == "+")
                        {
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            sumTotal = sumTotal + tempNum2;
                        }

                        else if (fullStringCollection[i] == "-")
                        {
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            sumTotal = sumTotal - tempNum2;
                        }

                        else if (fullStringCollection[i] == "/")
                        {
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            sumTotal = sumTotal / tempNum2;
                        }

                        else if (fullStringCollection[i] == "*")
                        {
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            sumTotal = sumTotal * tempNum2;
                        }
                    }
                //total answer after for loop must go here
                userInp.Text = Convert.ToString(sumTotal);

            }

            //resets the head text and sets correct status after calculations are done
            headInp.Text = "";
            status = "=";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (userInp.Text.Length >= 1)
            {
                userInp.Text = userInp.Text.Remove(userInp.Text.Length - 1);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            userInp.Text = "";
        }

        private void Invert_Click(object sender, RoutedEventArgs e)
        {
            if (userInp.Text.Length >= 1)
            {
                if (userInp.Text[0] == '-')
                {
                    userInp.Text = userInp.Text.Substring(1);
                }
                else
                {
                    userInp.Text = "-" + userInp.Text;
                }
            }
            else
            {
                userInp.Text = "-" + userInp.Text;
            }
        }

        private void Deciaml_Click(object sender, RoutedEventArgs e)
        {

           if (userInp.Text.Length == 0)
           {
               userInp.Text = "0.";
           }
           else if (userInp.Text.EndsWith("."))
           {

           }
    
           else
           {
               userInp.Text = userInp.Text + ".";
           }
        }
    }
}
