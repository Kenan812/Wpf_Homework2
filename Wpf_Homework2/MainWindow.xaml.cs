using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Wpf_Homework2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool capsLockPressed = false;

        BrushConverter brushConverter = new BrushConverter();

        DateTime d = new DateTime();


        string s = "fn qqwe owqn ejoqn jnr gpv; zja dasd";
        double correctLettersCount = 0;
        int falseLettersCount = 0;




        public MainWindow()
        {
            InitializeComponent();

            d = DateTime.Now;
        }


        #region Start And Stop Buttons Press


        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            userInputTextBox.Focusable = true;
            userInputTextBox.Focus();

            startButton.IsEnabled = false;
            stopButton.IsEnabled = true;

            speedLabel.Content = "0";
            failsNumberLabel.Content = "0";
            falseLettersCount = 0;
            correctLettersCount = 0;

            userInputTextBox.Text = String.Empty;
            exampleTextBox.Text = GenerateExampleText();

        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            userInputTextBox.Focusable = false;

            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;

            userInputTextBox.Background = (Brush)brushConverter.ConvertFromString("LightSkyBlue");

            speedLabel.Content = CountSpeed().ToString();
        }


        #endregion


        #region Managing KeyBoard


        private void userInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            #region Numbers 


            if (e.Key == Key.D1)
            {
                oneButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D2)
            {
                twoButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D3)
            {
                threeButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D4)
            {
                fourButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D5)
            {
                fiveButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D6)
            {
                sixButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D7)
            {
                sevenButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D8)
            {
                eightButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D9)
            {
                nineButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D0)
            {
                zeroButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }



            #endregion



            #region Letters


            if (e.Key == Key.Q)
            {
                qButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.W)
            {
                wButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.E)
            {
                eButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.R)
            {
                rButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.T)
            {
                tButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.Y)
            {
                yButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.U)
            {
                uButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.I)
            {
                iButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.O)
            {
                oButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.P)
            {
                pButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }


            ////////////////////////////////////////////////////


            else if (e.Key == Key.A)
            {
                aButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.S)
            {
                sButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.D)
            {
                dButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.F)
            {
                fButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.G)
            {
                gButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.H)
            {
                hButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.J)
            {
                jButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.K)
            {
                kButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.L)
            {
                lButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }


            /////////////////////////////////////////////////////


            else if (e.Key == Key.Z)
            {
                zButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.X)
            {
                xButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.C)
            {
                cButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.V)
            {
                vButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.B)
            {
                bButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.N)
            {
                nButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.M)
            {
                mButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }



            #endregion



            #region Characters


            if (e.Key == Key.Oem3)
            {
                someButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemMinus)
            {
                minusButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemPlus)
            {
                equalsButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemCloseBrackets)
            {
                rightBracketButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemOpenBrackets)
            {
                leftBracketButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.Oem5)
            {
                backSlashButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemBackTab)
            {
                backSlashButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemSemicolon)
            {
                semicolumnButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemQuotes)
            {
                paranthesisButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemComma)
            {
                commaButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemPeriod)
            {
                dotButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.OemQuestion)
            {
                slashButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }



            #endregion



            #region Control Keys


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


            else if (e.Key == Key.Tab)
            {
                tabButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.Enter)
            {
                enterButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }


            else if (e.Key == Key.LeftCtrl)
            {
                lCtrlButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }

            else if (e.Key == Key.RightCtrl)
            {
                rCtrlButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }


            else if (e.Key == Key.System)
            {
                lAltButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
                rAltButton.Background = (Brush)brushConverter.ConvertFromString("#404040");
            }


            #endregion
        }

        private void userInputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            #region Numbers 


            if (e.Key == Key.D1)
            {
                oneButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.D2)
            {
                twoButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.D3)
            {
                threeButton.Background = (Brush)brushConverter.ConvertFromString("#f4f471");
            }

            else if (e.Key == Key.D4)
            {
                fourButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.D5)
            {
                fiveButton.Background = (Brush)brushConverter.ConvertFromString("#06bcf9");
            }

            else if (e.Key == Key.D6)
            {
                sixButton.Background = (Brush)brushConverter.ConvertFromString("#06bcf9");
            }

            else if (e.Key == Key.D7)
            {
                sevenButton.Background = (Brush)brushConverter.ConvertFromString("#de6afb");
            }

            else if (e.Key == Key.D8)
            {
                eightButton.Background = (Brush)brushConverter.ConvertFromString("#de6afb");
            }

            else if (e.Key == Key.D9)
            {
                nineButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.D0)
            {
                zeroButton.Background = (Brush)brushConverter.ConvertFromString("#f4f471");
            }



            #endregion


            #region Letters

            if (e.Key == Key.Q)
            {
                qButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.W)
            {
                wButton.Background = (Brush)brushConverter.ConvertFromString("#f4f471");
            }

            else if (e.Key == Key.E)
            {
                eButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.R)
            {
                rButton.Background = (Brush)brushConverter.ConvertFromString("#06bcf9");
            }

            else if (e.Key == Key.T)
            {
                tButton.Background = (Brush)brushConverter.ConvertFromString("#06bcf9");
            }

            else if (e.Key == Key.Y)
            {
                yButton.Background = (Brush)brushConverter.ConvertFromString("#de6afb");
            }

            else if (e.Key == Key.U)
            {
                uButton.Background = (Brush)brushConverter.ConvertFromString("#de6afb");
            }

            else if (e.Key == Key.I)
            {
                iButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.O)
            {
                oButton.Background = (Brush)brushConverter.ConvertFromString("#f4f471");
            }

            else if (e.Key == Key.P)
            {
                pButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }


            ///////////////////////////////////////////////////////


            else if (e.Key == Key.A)
            {
                aButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.S)
            {
                sButton.Background = (Brush)brushConverter.ConvertFromString("#f4f471");
            }

            else if (e.Key == Key.D)
            {
                dButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.F)
            {
                fButton.Background = (Brush)brushConverter.ConvertFromString("#06bcf9");
            }

            else if (e.Key == Key.G)
            {
                gButton.Background = (Brush)brushConverter.ConvertFromString("#06bcf9");
            }

            else if (e.Key == Key.H)
            {
                hButton.Background = (Brush)brushConverter.ConvertFromString("#de6afb");
            }

            else if (e.Key == Key.J)
            {
                jButton.Background = (Brush)brushConverter.ConvertFromString("#de6afb");
            }

            else if (e.Key == Key.K)
            {
                kButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.L)
            {
                lButton.Background = (Brush)brushConverter.ConvertFromString("#f4f471");
            }


            /////////////////////////////////////////////////////


            else if (e.Key == Key.Z)
            {
                zButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.X)
            {
                xButton.Background = (Brush)brushConverter.ConvertFromString("#f4f471");
            }

            else if (e.Key == Key.C)
            {
                cButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.V)
            {
                vButton.Background = (Brush)brushConverter.ConvertFromString("#06bcf9");
            }

            else if (e.Key == Key.B)
            {
                bButton.Background = (Brush)brushConverter.ConvertFromString("#06bcf9");
            }

            else if (e.Key == Key.N)
            {
                nButton.Background = (Brush)brushConverter.ConvertFromString("#de6afb");
            }

            else if (e.Key == Key.M)
            {
                mButton.Background = (Brush)brushConverter.ConvertFromString("#de6afb");
            }



            #endregion


            #region Characters


            if (e.Key == Key.Oem3)
            {
                someButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.OemMinus)
            {
                minusButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.OemPlus)
            {
                equalsButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.OemCloseBrackets)
            {
                rightBracketButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.OemOpenBrackets)
            {
                leftBracketButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.Oem5)
            {
                backSlashButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.OemSemicolon)
            {
                semicolumnButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.OemQuotes)
            {
                paranthesisButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }

            else if (e.Key == Key.OemComma)
            {
                commaButton.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
            }

            else if (e.Key == Key.OemPeriod)
            {
                dotButton.Background = (Brush)brushConverter.ConvertFromString("#f4f471");
            }

            else if (e.Key == Key.OemQuestion)
            {
                slashButton.Background = (Brush)brushConverter.ConvertFromString("Lime");
            }


            #endregion


            #region Control Keys

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


            else if (e.Key == Key.Tab)
            {
                tabButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
            }

            else if (e.Key == Key.Enter)
            {
                enterButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
            }


            else if (e.Key == Key.LeftCtrl)
            {
                lCtrlButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
            }

            else if (e.Key == Key.RightCtrl)
            {
                rCtrlButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
            }

            else if (e.Key == Key.System)
            {
                lAltButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
                rAltButton.Background = (Brush)brushConverter.ConvertFromString("#b3b3b3");
            }


            #endregion

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
            sevenButton.Content = "&";
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
            sevenButton.Content = "7";
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


        private void userInputTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
            try
            {
                if (userInputTextBox.Text.Length == exampleTextBox.Text.Length) Stop();


                if (userInputTextBox.Text[userInputTextBox.Text.Length - 1] == exampleTextBox.Text[userInputTextBox.Text.Length - 1])
                {
                    correctLettersCount += 1 ;
                    userInputTextBox.Background = (Brush)brushConverter.ConvertFromString("Lime");
                    speedLabel.Content = CountSpeed().ToString();
                }

                else
                {
                    falseLettersCount++;
                    userInputTextBox.Background = (Brush)brushConverter.ConvertFromString("#f76e6e");
                    failsNumberLabel.Content = falseLettersCount.ToString();
                }

            }
            catch (IndexOutOfRangeException) { Stop(); }
        }


        private int CountSpeed()
        {
            if (correctLettersCount != 0)
            {
                double ms = DateTime.Now.Subtract(d).TotalSeconds / correctLettersCount;

                return (int)(correctLettersCount / DateTime.Now.Subtract(d).TotalSeconds * 60);
            }
            
            return 0;
        }


        private void Stop()
        {
            userInputTextBox.Focusable = false;
            stopButton.IsEnabled = false;
            startButton.IsEnabled = true;
        }


        private string GenerateExampleText()
        {
            Random rnd = new Random();


            string res = String.Empty;

            string str = "fjasdqwertyuiopklbvcnxmzgh1234567890`-=[];',./\\";

            string strCaseSensitive = "fFjJaAsSdDqQwWeErRtTyYuUiIoOpPkKlLbBvVcCnNxXmMzZgGhH1234567890!@#$%^&*()`-=~_+[]{}\\|;:'\",./<>?";




            if (!(bool)caseSensitiveCheckBox.IsChecked)
            {
                Double d = difficultySlider.Value;

                string tempS = str.Substring(0, (int)(4.7 * d));


                for (int i = 0; i < 50; i++)
                {
                    res += tempS[rnd.Next(0, tempS.Length)];

                    if (rnd.Next(0, 4) == 2) res += " ";
                }
            }


            else
            {
                Double d = difficultySlider.Value;

                string tempS = strCaseSensitive.Substring(0, (int)(9.4 * d));


                for (int i = 0; i < 50; i++)
                {
                    res += tempS[rnd.Next(0, tempS.Length)];

                    if (rnd.Next(0, 4) == 2) res += " ";
                }
            }

            return res;
        }


        private void difficultySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            difficultyLabel.Content = ((int)difficultySlider.Value).ToString();
        }
    }
}
