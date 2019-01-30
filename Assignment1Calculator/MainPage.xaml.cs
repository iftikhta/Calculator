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

    public sealed partial class MainPage : Page
    {
        //last clicked operator
        String status = "";

        // temporary storage 
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
        {    //the if status check will check if there is an operator in queue and if so, it will clear input and status
            //string newVar = userInp.Parse(userInp.Text); This does not work, took me a an embarssing amount of time to get this right
            if (status != "")
            {
               // headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
               // headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
               // headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
               // headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "4";

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
               // headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
               // headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "6";

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
               // headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                //headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                //headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "9";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (status != "")
            {
                //headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }
            userInp.Text = userInp.Text + "0";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            String[] lencheck = headInp.Text.Split(' ');
            if (status == "=")
            {
                headInp.Text = "";
            }
            if (lencheck.Length > 1)
            {
                headInp.Text = $"{headInp.Text} {userInp.Text} /";
                status = "/";
            }
            else
            {
                // creating a end decimal checker/remover

                if (userInp.Text.EndsWith("."))
                {
                    // cutt off the decimal
                    userInp.Text = userInp.Text.TrimEnd('.');
                }
                temp = userInp.Text + " /";
                headInp.Text += temp;
                status = "/";
            }
            /*temp = userInp.Text + " /";
            status = "/";*/

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
            /* temp = userInp.Text + " -";
             status = "-";*/
            String[] lencheck = headInp.Text.Split(' ');
            if (lencheck.Length > 1)
            {
                headInp.Text = $"{headInp.Text} {userInp.Text} -";
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
                temp = userInp.Text + " -";
                headInp.Text += temp;
                status = "-";
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            String[] lencheck = headInp.Text.Split(' ');
            if (lencheck.Length > 1)
            {
                headInp.Text = $"{headInp.Text} {userInp.Text} *";
                status = "*";
            }
            else
            {
                // creating a end decimal checker/remover

                if (userInp.Text.EndsWith("."))
                {
                    // cutt off the decimal
                    userInp.Text = userInp.Text.TrimEnd('.');
                }
                temp = userInp.Text + " *";
                headInp.Text += temp;
                status = "*";
            }
            /* temp = userInp.Text + " *";
             status = "*";*/
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            String[] lencheck = headInp.Text.Split(' ');
            if (lencheck.Length > 1)
            {
                headInp.Text = $"{headInp.Text} {userInp.Text} +";
                status = "+";
            }
            else
            {
                // creating a end decimal checker/remover

                if (userInp.Text.EndsWith("."))
                {
                    // cutt off the decimal
                    userInp.Text = userInp.Text.TrimEnd('.');
                }
                temp = userInp.Text + " +";
                headInp.Text += temp;
                status = "+";
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {

            // must ad an if status = "=", then do nothing type of code here to prevent repeated spam of +
            //String tempHead = headInp.Text;
            //headInp.Text = "";
            if (status == "=")
            {
         

            }
            else if (headInp.Text.Split(' ').Length == 1) 
            {

            }

            // must fix equal sign click,it consantly breaks format after the first useage
           /* else if (userInp.Text.Length == 1 && headInp.Text =="")
            {
                if (status == "+")
                {
                    headInp.Text = $"{userInp.Text} + {userInp.Text}";
                    userInp.Text = Convert.ToString(Convert.ToDecimal(userInp.Text)+ Convert.ToDecimal(userInp.Text));
                    status = "=";
                }
            }*/
         

           
            
            else
            {
            headInp.Text = headInp.Text + " "  + userInp.Text;
               // String[] tempTotal = headInp.Text.Split(' ');
               StringCollection fullStringCollection = new StringCollection();
               String[] splitHeader = headInp.Text.Split(' ');
               fullStringCollection.AddRange(splitHeader);

                // must make below line only run if there is more than  1 number

                
                Decimal sumTotal = Convert.ToDecimal(fullStringCollection[0]);
                

                for (int i = 1; i < fullStringCollection.Count; i++)
                    {
                        if (fullStringCollection[i] == "+")
                        {
                            //Decimal tempNum1 = Convert.ToDecimal(fullStringCollection[i - 1]);
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            sumTotal = sumTotal + tempNum2;
                            //sumTotal = total;
                            //tempTotal.RemoveAt(0);
                            //tempTotal.RemoveAt(0);
                            //fullStringCollection.Insert(i+1, Convert.ToString(subTotal));
                            //sumTotal = Convert.ToDecimal(fullStringCollection[i + 1]);

                            //userInp.Text = Convert.ToString(total);

                        }
                        else if (fullStringCollection[i] == "-")
                        {
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            sumTotal = sumTotal - tempNum2;
                            /*
                            Decimal tempNum1 = Convert.ToDecimal(fullStringCollection[i - 1]);
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            Decimal total = tempNum1 - tempNum2;
                            sumTotal += total;*/
                            //userInp.Text = Convert.ToString(total);
                        }
                        else if (fullStringCollection[i] == "/")
                        {
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            sumTotal = sumTotal / tempNum2;
                            /*Decimal tempNum1 = Convert.ToDecimal(fullStringCollection[i - 1]);
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            Decimal total = tempNum1 / tempNum2;
                            sumTotal += total;*/
                            //userInp.Text = Convert.ToString(total);
                        }
                        else if (fullStringCollection[i] == "*")
                        {
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            sumTotal = sumTotal * tempNum2;
                            /*Decimal tempNum1 = Convert.ToDecimal(fullStringCollection[i - 1]);
                            Decimal tempNum2 = Convert.ToDecimal(fullStringCollection[i + 1]);
                            Decimal total = tempNum1 * tempNum2;
                            sumTotal += total;*/
                            //userInp.Text = Convert.ToString(total);
                        }


                        // Decimal tempNum1 = Convert.ToDecimal(i);
                        // Decimal tempNum2 = Convert.ToDecimal(i + 2);
                        //sumTotal = Convert.ToDecimal(tempTotal[i + 1]);
                    }
                

                //total answer after for loop must go here
                userInp.Text = Convert.ToString(sumTotal);

            }

            //userInp.Text = Total;
            status = "=";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (userInp.Text.Length >= 1)
            {
                userInp.Text = userInp.Text.Remove(userInp.Text.Length - 1);
            }
            //userInp.Text = userInp.Text.Remove(userInp.Text.Length-1);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            userInp.Text = "";
        }

        private void Invert_Click(object sender, RoutedEventArgs e)
        {
            // These below lines dont work yet
            // userInp.Text = Convert.ToString(Convert.ToDecimal(userInp.Text)*-1);

            if (userInp.Text.Length >= 1)
            {
                if (userInp.Text[0] == '-')
                {
                    userInp.Text = userInp.Text.Substring(1);
                }
                else
                {
                    userInp.Text = "-" + userInp.Text; //userInp.Text + "-";
                }
            }
            else
            {
                userInp.Text = "-" + userInp.Text; //userInp.Text + "-";
            }
        }

        private void Deciaml_Click(object sender, RoutedEventArgs e)
        {
           /* if (status != "")
            {
                // headInp.Text = temp;
                userInp.Text = "";
                status = "";
            }*/

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
