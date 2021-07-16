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

namespace Wpf_Homework2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool capsLockPressed = false;

        BrushConverter brushConverter = new BrushConverter();


        public MainWindow()
        {
            InitializeComponent();
        }

        
        #region Start And Stop Buttons Press


        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            userInputTextBox.Focus();

            startButton.IsEnabled = false;
            stopButton.IsEnabled = true;

        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;


        }


        #endregion


        #region Managing KeyBoard


        private void userInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            // Shift
            
            if (e.Key == Key.LeftShift)
            {
                lShiftButton.Background = (Brush)brushConverter.ConvertFromString("#404040");

                MakeBoardUpperCase();
            }

            else if (e.Key == Key.RightShift)
            {
                rShiftButton.Background = (Brush)brushConverter.ConvertFromString("#404040");

                MakeBoardUpperCase();
            }
            

            // Caps Lock
            
            else if (e.Key == Key.CapsLock)
            {
                if (capsLockPressed)
                {
                    capsLockButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
                    MakeBoardLowerCase();
                }
                else
                {
                    capsLockButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
                    MakeBoardUpperCase();
                }
                capsLockPressed = !capsLockPressed;
            }
        }

        private void userInputTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            // Shift

            if (e.Key == Key.LeftShift)
            {
                lShiftButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
                MakeBoardLowerCase();
            }
            else if (e.Key == Key.RightShift)
            {
                rShiftButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
                MakeBoardLowerCase();
            }
        }

        private void MakeBoardUpperCase()
        {
            someButton.Content = "~";
            oneButton.Content = "!";
            twoButton.Content = "@";
            threeButton.Content = "#";
            fourButton.Content = "$";
            fiveButton.Content = "%";
            sixButton.Content = "^";
            seventButton.Content = "&";
            eightButton.Content = "*";
            nineButton.Content = "(";
            zeroButton.Content = ")";
            minusButton.Content = "_";
            equalsButton.Content = "+";


            qButton.Content = "Q";
            wButton.Content = "W";
            eButton.Content = "E";
            rButton.Content = "R";
            tButton.Content = "T";
            yButton.Content = "Y";
            uButton.Content = "U";
            iButton.Content = "I";
            oButton.Content = "O";
            pButton.Content = "P";
            leftBracketButton.Content = "{";
            rightBracketButton.Content = "}";
            backSlashButton.Content = "|";



            aButton.Content = "A";
            sButton.Content = "S";
            dButton.Content = "D";
            fButton.Content = "F";
            gButton.Content = "G";
            hButton.Content = "H";
            jButton.Content = "J";
            kButton.Content = "K";
            lButton.Content = "L";
            semicolumnButton.Content = ":";
            paranthesisButton.Content = "\"";


            zButton.Content = "Z";
            xButton.Content = "X";
            cButton.Content = "C";
            vButton.Content = "V";
            bButton.Content = "B";
            nButton.Content = "N";
            mButton.Content = "M";
            commaButton.Content = "<";
            dotButton.Content = ">";
            slashButton.Content = "?";

        }


        private void MakeBoardLowerCase()
        {
            someButton.Content = "`";
            oneButton.Content = "1";
            twoButton.Content = "2";
            threeButton.Content = "3";
            fourButton.Content = "4";
            fiveButton.Content = "5";
            sixButton.Content = "6";
            seventButton.Content = "7";
            eightButton.Content = "8";
            nineButton.Content = "9";
            zeroButton.Content = "0";
            minusButton.Content = "-";
            equalsButton.Content = "=";


            qButton.Content = "q";
            wButton.Content = "w";
            eButton.Content = "e";
            rButton.Content = "r";
            tButton.Content = "t";
            yButton.Content = "y";
            uButton.Content = "u";
            iButton.Content = "i";
            oButton.Content = "o";
            pButton.Content = "p";
            leftBracketButton.Content = "[";
            rightBracketButton.Content = "]";
            backSlashButton.Content = "\\";


            aButton.Content = "a";
            sButton.Content = "s";
            dButton.Content = "d";
            fButton.Content = "f";
            gButton.Content = "g";
            hButton.Content = "h";
            jButton.Content = "j";
            kButton.Content = "k";
            lButton.Content = "l";
            semicolumnButton.Content = ";";
            paranthesisButton.Content = "'";


            zButton.Content = "z";
            xButton.Content = "x";
            cButton.Content = "c";
            vButton.Content = "v";
            bButton.Content = "b";
            nButton.Content = "n";
            mButton.Content = "m";
            commaButton.Content = ",";
            dotButton.Content = ".";
            slashButton.Content = "/";
        }
        
        
        #endregion


    }
}
