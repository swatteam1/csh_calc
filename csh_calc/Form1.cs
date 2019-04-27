namespace csh_calc
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private string Operations = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }
        const double maxch = 12; //количество символов
		//wadsfdfhgjhkjlikl
        //constant
        string command;
        double ch1;
        double ch2;
        byte cl;
        byte com;
        string error;
        byte val;
        byte rept;

        //формлоад
        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 327;
            textBox1.Width = 300;

            cl = 0;
            ch1 = 0;
            ch2 = 0;
            command = "";
            com = 0;
            error = "";
            val = 1;
            rept = 0;

            textBox1.Text = "0";
        }

        // кнопка СE
        private void button1121_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            minies.Text = string.Empty;
        }

        private void Resh()
        {
            switch (command)
            {
                case "+":
                    if (cl == 1 || (cl == 0 && minies.Text != "")) ch2 = Convert.ToDouble(textBox1.Text);
                    ch1 = ch1 + ch2;
                    break;
                case "-":
                    if (cl == 1 || (cl == 0 && minies.Text != "")) ch2 = Convert.ToDouble(textBox1.Text);
                    ch1 = ch1 - ch2;
                    break;
                case "*":
                    if (cl == 1 || (cl == 0 && minies.Text != "")) ch2 = Convert.ToDouble(textBox1.Text);
                    ch1 = ch1 * ch2;
                    break;
                case "/":
                    if (cl == 1 || (cl == 0 && minies.Text != "")) ch2 = Convert.ToDouble(textBox1.Text);
                    if (ch2 != 0) ch1 = ch1 / ch2;
                    else
                    {
                        ch1 = 0;
                        MessageBox.Show(("На ноль делить нельзя!"));
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    break;
                case "mod":
                    if (cl == 1 || (cl == 0 && minies.Text != "")) ch2 = Convert.ToDouble(textBox1.Text);
                    ch1 = ch1 % ch2;
                    break;
            }
        }

        // ==
        private void bequal_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (minies.Text != "" || cl == 0)
                {
                    Resh();
                    if (error == "") textBox1.Text = Convert.ToString(ch1);
                    else textBox1.Text = error;
                    minies.Text = "";
                    cl = 0;
                    com = 0;
                    rept = 1;
                }
            }
        }

        // кнопка С
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }
        // %
        private void button21_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = Convert.ToString(a);
        }

        // Oct
        private void button22_Click(object sender, EventArgs e)
        {
            var a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 8);
        }
        // ln x
        private void button25_Click(object sender, EventArgs e)
        {
            var ilog = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("Ln" + "(" + textBox1.Text + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = Convert.ToString(ilog);
        }

        // Hex
        private void button26_Click(object sender, EventArgs e)
        {
            var a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 16);
        }
        // Tan
        private void button27_Click(object sender, EventArgs e)
        {
            var qTan = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("Tan" + "(" + textBox1.Text + ")");
            qTan = Math.Tan(qTan);
            textBox1.Text = Convert.ToString(qTan);
        }

        // Tanh
        private void button28_Click(object sender, EventArgs e)
        {
            var qTanh = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("Tanh" + "(" + textBox1.Text + ")");
            qTanh = Math.Tanh(qTanh);
            textBox1.Text = Convert.ToString(qTanh);
        }
        // 1/x
        private void button29_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(a);
        }

        // кнопка удаления
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "0";
            }
        }

        // Bin
        private void button30_Click(object sender, EventArgs e)
        {
            var a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 2);
        }

        // Cos
        private void button31_Click(object sender, EventArgs e)
        {
            var qCos = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("Cos" + "(" + textBox1.Text + ")");
            qCos = Math.Cos(qCos);
            textBox1.Text = Convert.ToString(qCos);
        }

        // Cosh
        private void button32_Click(object sender, EventArgs e)
        {
            var qCosh = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("Cosh" + "(" + textBox1.Text + ")");
            qCosh = Math.Cosh(qCosh);
            textBox1.Text = Convert.ToString(qCosh);
        }

        // X^3
        private void button33_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(a);
        }

        // Dec
        private void button34_Click(object sender, EventArgs e)
        {
            var a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a);
        }

        // sin
        private void button35_Click(object sender, EventArgs e)
        {
            var qSin = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("Sin" + "(" + textBox1.Text + ")");
            qSin = Math.Sin(qSin);
            textBox1.Text = Convert.ToString(qSin);
        }

        // sinh
        private void button36_Click(object sender, EventArgs e)
        {
            var qSinh = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("Sinh" + "(" + textBox1.Text + ")");
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = Convert.ToString(qSinh);
        }

        // X^2
        private void button37_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(a);
        }

        // sqrt
        private void button38_Click(object sender, EventArgs e)
        {
            var sq = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString(string.Empty + "(" + textBox1.Text + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = Convert.ToString(sq);
        }

        // log
        private void button39_Click(object sender, EventArgs e)
        {
            var ilog = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("Log" + "(" + textBox1.Text + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = Convert.ToString(ilog);
        }

        // Pi
        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589976323";
        }

        // mod
        private void button23_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "mod";
                    ch1 = Convert.ToDouble(textBox1.Text);
                    minies.Text = textBox1.Text + command;
                    //rept = 0;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "mod";
                            minies.Text = textBox1.Text + command;
                        }
                        else
                        {
                            command = "mod";
                            minies.Text = minies.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "mod";
                            ch1 = Convert.ToDouble(textBox1.Text);
                            minies.Text = textBox1.Text + command;
                            //rept = 0;
                        }
                        else
                        {
                            Resh();
                            command = "mod";
                            minies.Text += textBox1.Text + command;
                            textBox1.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        // exp
        private void button24_Click(object sender, EventArgs e)
        {
            var exp = double.Parse(textBox1.Text);
            minies.Text = Convert.ToString("exp" + "(" + textBox1.Text + ")");
            exp = Math.Exp(exp);
            textBox1.Text = Convert.ToString(exp);

        }

        // Кнопка mini
        private void mini(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            minies.Text = string.Empty;
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width = 682;
            textBox1.Width = 656;
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width = 327;
            textBox1.Width = 300;
        }

        // смена знака
        private void button4_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {

                if (textBox1.Text == "0")
                {
                    
                    MessageBox.Show(("Ноль не может быть отрицательным числом!"));
                    System.Media.SystemSounds.Asterisk.Play();

                }
                else
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * (-1));
                }
                if (com == 1 && Math.Floor(Convert.ToDouble(textBox1.Text)) == Convert.ToDouble(textBox1.Text)) com = 0;
                
            }
        }
        // точка запятая
        private void textbox1_keypress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (textBox1.Text.Contains(",") || textBox1.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bequal.Select();
            if (e.KeyCode == Keys.Delete) button2_Click(this, new EventArgs());
            if (e.KeyCode == Keys.Enter) bequal_Click(null, new EventArgs());

        }
        
        private void valid_enter(object validatetype)
        {
            switch (Convert.ToString(validatetype))
            {
                case "number":
                    if (error == "")
                    {
                        if (textBox1.Text.Length >= maxch && cl == 1)
                        {
                            val = 0;
                            System.Media.SystemSounds.Beep.Play();
                        }
                        else val = 1;
                    }
                    else
                    {
                        val = 0;
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    break;
                case "memo":
                    if (error != "")
                    {
                        val = 0;
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    else val = 1;
                    break;
                case "sign":
                    if (error != "")
                    {
                        val = 0;
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    else val = 1;
                    break;
                case "a":
                    if (error != "")
                    {
                        val = 0;
                        System.Media.SystemSounds.Asterisk.Play();
                    }
                    else val = 1;
                    break;
            }
        }
        //кнопка точки
        private void bpoint_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1 && com == 0)
            {
                if (cl == 1) textBox1.Text = textBox1.Text + System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
                else textBox1.Text = "0" + System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
                cl = 1;
                com = 1;
            }
        }

        // цифры
        private void bone_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "1";
                else textBox1.Text = textBox1.Text + "1";
                cl = 1;
            }
        }

        private void btwo_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "2";
                else textBox1.Text = textBox1.Text + "2";
                cl = 1;
            }
        }

        private void bthree_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "3";
                else textBox1.Text = textBox1.Text + "3";
                cl = 1;
            }
        }

        private void bfour_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "4";
                else textBox1.Text = textBox1.Text + "4";
                cl = 1;
            }
        }

        private void bfive_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "5";
                else textBox1.Text = textBox1.Text + "5";
                cl = 1;
            }
        }

        private void bsix_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "6";
                else textBox1.Text = textBox1.Text + "6";
                cl = 1;
            }
        }

        private void bseven_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "7";
                else textBox1.Text = textBox1.Text + "7";
                cl = 1;
            }
        }

        private void beight_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "8";
                else textBox1.Text = textBox1.Text + "8";
                cl = 1;
            }
        }

        private void bnine_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "9";
                else textBox1.Text = textBox1.Text + "9";
                cl = 1;
            }
        }

        private void bzero_Click(object sender, EventArgs e)
        {
            valid_enter("number");
            if (val == 1)
            {
                if (cl == 0) textBox1.Text = "0";
                else textBox1.Text = textBox1.Text + "0";
                if (textBox1.Text == "0") cl = 0;
                else cl = 1;
            }
        }

        private void bdelenie_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "/";
                    ch1 = Convert.ToDouble(textBox1.Text);
                    minies.Text = textBox1.Text + command;
                    //rept = 0;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "/";
                            minies.Text = textBox1.Text + command;
                        }
                        else
                        {
                            command = "/";
                            minies.Text = minies.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "/";
                            ch1 = Convert.ToDouble(textBox1.Text);
                            minies.Text = textBox1.Text + command;
                            //rept = 0;
                        }
                        else
                        {
                            Resh();
                            command = "/";
                            minies.Text += textBox1.Text + command;
                            textBox1.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "+";
                    ch1 = Convert.ToDouble(textBox1.Text);
                    minies.Text = textBox1.Text + command;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "+";
                            minies.Text = textBox1.Text + command;
                        }
                        else
                        {
                            command = "+";
                            minies.Text = minies.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "+";
                            ch1 = Convert.ToDouble(textBox1.Text);
                            minies.Text = textBox1.Text + command;
                        }
                        else
                        {
                            Resh();
                            command = "+";
                            minies.Text += textBox1.Text + command;
                            textBox1.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "-";
                    ch1 = Convert.ToDouble(textBox1.Text);
                    minies.Text = textBox1.Text + command;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "-";
                            minies.Text = textBox1.Text + command;
                        }
                        else
                        {
                            command = "-";
                            minies.Text = minies.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "-";
                            ch1 = Convert.ToDouble(textBox1.Text);
                            minies.Text = textBox1.Text + command;
                        }
                        else
                        {
                            Resh();
                            command = "-";
                            minies.Text += textBox1.Text + command;
                            textBox1.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        private void bmultyply_Click(object sender, EventArgs e)
        {
            valid_enter("sign");
            if (val == 1)
            {
                if (command == "")
                {
                    command = "*";
                    ch1 = Convert.ToDouble(textBox1.Text);
                    minies.Text = textBox1.Text + command;
                }
                else
                {
                    if (cl == 0)
                    {
                        if (rept == 1)
                        {
                            command = "*";
                            minies.Text = textBox1.Text + command;
                        }
                        else
                        {
                            command = "*";
                            minies.Text = minies.Text.TrimEnd('+', '-', '*', '/') + command;
                        }
                    }
                    if (cl == 1)
                    {
                        if (rept == 1)
                        {
                            command = "*";
                            ch1 = Convert.ToDouble(textBox1.Text);
                            minies.Text = textBox1.Text + command;
                        }
                        else
                        {
                            Resh();
                            command = "*";
                            minies.Text += textBox1.Text + command;
                            textBox1.Text = Convert.ToString(ch1);
                        }
                    }
                }
                cl = 0;
                com = 0;
                rept = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 12 && textBox1.Text.Length <= 14) textBox1.Font = new Font("Microsoft Sans Serif", 22);
            if (textBox1.Text.Length > 14 && textBox1.Text.Length <= 17) textBox1.Font = new Font("Microsoft Sans Serif", 19);
            if (textBox1.Text.Length > 17 && textBox1.Text.Length <= 23) textBox1.Font = new Font("Microsoft Sans Serif", 15);

            if (error != "") textBox1.Font = new Font("Microsoft Sans Serif", 8);

            //отображение 
            if (textBox1.Text == Convert.ToString(double.NaN))
            {
                error = "Неправильная операция";
                textBox1.Text = error;
                System.Media.SystemSounds.Asterisk.Play();
            }
            if (textBox1.Text == Convert.ToString(double.PositiveInfinity))
            {
                error = "Бесконечность";
                textBox1.Text = error;
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void minies_TextChanged(object sender, EventArgs e)
        {
            minies.SelectAll();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Select();
            switch (e.KeyChar)
            {
                case '0':
                    bzero_Click(null, new EventArgs());
                    
                    break;
                case '1':
                    bone_Click(null, new EventArgs());
                   
                    break;
                case '2':
                    btwo_Click(null, new EventArgs());
                    
                    break;
                case '3':
                    bthree_Click(null, new EventArgs());
                    break;
                case '4':
                    bfour_Click(null, new EventArgs());
                    break;
                case '5':
                    bfive_Click(null, new EventArgs());
                    break;
                case '6':
                    bsix_Click(null, new EventArgs());
                    break;
                case '7':
                    bseven_Click(null, new EventArgs());
                    break;
                case '8':
                    beight_Click(null, new EventArgs());
                    break;
                case '9':
                    bnine_Click(null, new EventArgs());
                    break;
                case '+':
                    bplus_Click(null, new EventArgs());
                    break;
                case '-':
                    bminus_Click(null, new EventArgs());
                    break;
                case '*':
                    bmultyply_Click(null, new EventArgs());
                    break;
                case '/':
                    bdelenie_Click(null, new EventArgs());
                    break;
                case '.':
                    bpoint_Click(null, new EventArgs());
                    break;
                case ',':
                    bpoint_Click(null, new EventArgs());
                    break;
                case '=':
                    bequal_Click(null, new EventArgs());
                    break;
                case (char)Keys.Escape:
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case (char)Keys.Back:
                    button2_Click(null, new EventArgs());
                    break;
            }
        }


        
    }
}
