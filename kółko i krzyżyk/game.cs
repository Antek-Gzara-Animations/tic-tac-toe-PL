using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace kółko_i_krzyżyk
{
    public partial class game : Form
    {
        #region poruszanie oknem
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public game()
        {
            InitializeComponent();
        }
        
        #region Exit Button
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.X_red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.X_white;
        }
        #endregion

        #region poruszanie oknem
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private int btn1State = 0, btn2State = 0, btn3State = 0, btn4State = 0, btn5State = 0, btn6State = 0, btn7State = 0, btn8State = 0, btn9State = 0;
        private bool turn = false; //false - x ; true - o
                                   //BtnState - 1 = X ; 2 = o

        #region click events
        private void btn1_Click(object sender, EventArgs e)
        {
            if (turn) 
            {
                btn1State = 2;
                btn1.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn1State = 1;
                btn1.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn1.Enabled = false;
            

            check();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn2State = 2;
                btn2.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn2State = 1;
                btn2.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn2.Enabled = false;
            

            check();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn3State = 2;
                btn3.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn3State = 1;
                btn3.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn3.Enabled = false;
            

            check();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn4State = 2;
                btn4.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn4State = 1;
                btn4.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn4.Enabled = false;


            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn1.BackgroundImage = null;
            btn2.BackgroundImage = null;
            btn3.BackgroundImage = null;
            btn4.BackgroundImage = null;
            btn5.BackgroundImage = null;
            btn6.BackgroundImage = null;
            btn7.BackgroundImage = null;
            btn8.BackgroundImage = null;
            btn9.BackgroundImage = null;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1State = 0;
            btn2State = 0;
            btn3State = 0;
            btn4State = 0;
            btn5State = 0;
            btn6State = 0;
            btn7State = 0;
            btn8State = 0;
            btn9State = 0;

            button3.Visible = false; // ukryj ten przycisk
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn5State = 2;
                btn5.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn5State = 1;
                btn5.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn5.Enabled = false;


            check();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn6State = 2;
                btn6.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn6State = 1;
                btn6.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn6.Enabled = false;


            check();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn7State = 2;
                btn7.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn7State = 1;
                btn7.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn7.Enabled = false;


            check();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn8State = 2;
                btn8.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn8State = 1;
                btn8.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn8.Enabled = false;


            check();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                btn9State = 2;
                btn9.BackgroundImage = Properties.Resources.O;
                turn = false;
            }
            else
            {
                btn9State = 1;
                btn9.BackgroundImage = Properties.Resources.X;
                turn = true;
            }

            btn9.Enabled = false;


            check();
        }

        #endregion

        private void check()
        {
            //zmiana napisu na górze
            if (turn)
            {
                label1.Text = "teraz gra O";
            }
            else
            {
                label1.Text = "teraz gra X";
            }


            //X

            if (btn1State == 1 && btn2State == 1 && btn3State == 1)
            {
                Xwin();
            }
            else if (btn4State == 1 && btn5State == 1 && btn6State == 1)
            {
                Xwin();
            }
            else if (btn7State == 1 && btn8State == 1 && btn9State == 1)
            {
                Xwin();
            }
            else if (btn1State == 1 && btn5State == 1 && btn9State == 1)
            {
                Xwin();
            }
            else if (btn3State == 1 && btn5State == 1 && btn7State == 1)
            {
                Xwin();
            }
            //update 03.07.2021 zapomniełem o tych ifach
            else if (btn1State == 1 && btn4State == 1 && btn7State == 1)
            {
                Xwin();
            }
            else if (btn2State == 1 && btn5State == 1 && btn8State == 1)
            {
                Xwin();
            }
            else if (btn3State == 1 && btn6State == 1 && btn9State == 1)
            {
                Xwin();
            }

            //O

            else if (btn1State == 2 && btn2State == 2 && btn3State == 2)
            {
                Owin();
            }
            else if (btn4State == 2 && btn5State == 2 && btn6State == 2)
            {
                Owin();
            }
            else if (btn7State == 2 && btn8State == 2 && btn9State == 2)
            {
                Owin();
            }
            else if (btn1State == 2 && btn5State == 2 && btn9State == 2)
            {
                Owin();
            }
            else if (btn3State == 2 && btn5State == 2 && btn7State == 2)
            {
                Owin();
            }
            //update 03.07.2021 zapomniełem o tych ifach
            else if (btn1State == 2 && btn4State == 2 && btn7State == 2)
            {
                Owin();
            }
            else if (btn2State == 2 && btn5State == 2 && btn8State == 2)
            {
                Owin();
            }
            else if (btn3State == 2 && btn6State == 2 && btn9State == 2)
            {
                Owin();
            }


            else if (btn1.Enabled == false && btn2.Enabled == false && btn3.Enabled  == false && btn4.Enabled == false && btn5.Enabled == false && btn6.Enabled == false && btn7.Enabled == false && btn8.Enabled == false && btn9.Enabled == false)
            {
                remis();
            }


        }

        private void Xwin()
        {
            MessageBox.Show("wygrywa x", "wynik", MessageBoxButtons.OK);
            button3.Visible = true;
        }

        private void Owin()
        {
            MessageBox.Show("wygrywa o", "wynik", MessageBoxButtons.OK);
            button3.Visible = true;
        }

        private void remis()
        {
            MessageBox.Show("Remis", "wynik", MessageBoxButtons.OK);
            button3.Visible = true;
        }
    }
}