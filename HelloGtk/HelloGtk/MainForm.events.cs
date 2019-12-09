using System;
using System.Globalization;
using Gtk;

namespace HelloGtk
{
    internal partial class MainForm
    {
        private static double _firstNumber;
        private static double _secondNumber;
        private static int _operation;
        
        private static void Clear_Clicked(object o, EventArgs args)
        {
            Monitor.Text = "";
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = 0;
        }
        
        private static void Backspace_Clicked(object o, EventArgs args)
        {
            var message =
                new MessageDialog(_win, DialogFlags.Modal, MessageType.Warning, ButtonsType.Close, null, args)
                {
                    Text = "I am too lazy to implement this function XD~~",
                    Title = "Not Implement~~",
                };
            message.Response += (bClose, responseArgs) =>  { message.Dispose(); };
            message.Run();
        }
        
        private static void Close_Clicked(object o, EventArgs args)
        {
            _win.Close();
        }
        
        private static void Zero_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 0.ToString();
        }
        
        private static void One_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 1.ToString();
        }
        
        private static void Two_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 2.ToString();
        }
        
        private static void Three_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 3.ToString();
        }
        
        private static void Fore_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 4.ToString();
        }
        
        private static void Five_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 5.ToString();
        }
        
        private static void Six_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 6.ToString();
        }
        
        private static void Seven_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 7.ToString();
        }
        
        private static void Eight_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 8.ToString();
        }
        
        private static void Nine_Clicked(object o, EventArgs args)
        {
            Monitor.Text += 9.ToString();
        }
        
        private static void Plus_Clicked(object o, EventArgs args)
        {
            _firstNumber = Convert.ToDouble(Monitor.Text);
            _operation = 1;
            Monitor.Text = "";
        }
        
        private static void Minus_Clicked(object o, EventArgs args)
        {
            _firstNumber = Convert.ToDouble(Monitor.Text);
            _operation = 2;
            Monitor.Text = "";
        }
        
        private static void Multiplied_Clicked(object o, EventArgs args)
        {
            _firstNumber = Convert.ToDouble(Monitor.Text);
            _operation = 3;
            Monitor.Text = "";
        }
        
        private static void Division_Clicked(object o, EventArgs args)
        {
            _firstNumber = Convert.ToDouble(Monitor.Text);
            _operation = 4;
            Monitor.Text = "";
        }
        
        private static void Eq_Clicked(object o, EventArgs args)
        {
            _secondNumber = Convert.ToDouble(Monitor.Text);
            
            switch (_operation)
            {
                case 1:
                    Monitor.Text = (_firstNumber + _secondNumber).ToString(CultureInfo.CurrentCulture);
                break;
                case 2:
                    Monitor.Text = (_firstNumber - _secondNumber).ToString(CultureInfo.CurrentCulture);
                break;
                case 3:
                    Monitor.Text = (_firstNumber * _secondNumber).ToString(CultureInfo.CurrentCulture);
                break;
                case 4:
                    Monitor.Text = (_firstNumber / _secondNumber).ToString(CultureInfo.CurrentCulture);
                break;
                default:
                    Clear_Clicked(o, args);
                break;
            }
        }
        
        private static void Point_Clicked(object o, EventArgs args)
        {
            Monitor.Text += ".";
        }
    }
}