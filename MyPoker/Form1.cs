using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MyPoker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DealCards PokerSet;
        
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FlopButton.Visible = false;
            TernButton.Visible = true;
            if (textBox3.Text == "") textBox3.Text = "0";
            textBox3.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Value.ToString()) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(numericUpDown2.Value.ToString()));
            textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(numericUpDown1.Value.ToString()));
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(numericUpDown1.Value.ToString()));

            numericUpDown1.Value = numericUpDown1.Minimum;
            numericUpDown2.Value = numericUpDown2.Minimum;
            DealCards.createDeal();
            DealCards.getDeal().setControl(Controls);
          //  DealCards.getDeal().setComponents(components);
            
           DealCards.getDeal().Deal();

         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "0") numericUpDown1.Value = numericUpDown1.Minimum;
            else
            if (numericUpDown1.Value > Convert.ToInt32(textBox2.Text))
            {
                numericUpDown1.Value = Convert.ToInt32(textBox2.Text);
                numericUpDown2.Value = Convert.ToInt32(textBox2.Text);
            }
            else
            numericUpDown2.Value = numericUpDown1.Value;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DealCards.getDeal().Fold("Player");
            //Fold::
            //DealCards.getDeal().myResult =new Fold();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") textBox3.Text = "0";
            //Хочет ли робот поднять ставку?

            //Yes
           // if ((Result.Text.IndexOf("PC WIN") >= 0) || (Result.Text.IndexOf("NO ONE WIN!") >= 0) || (Result.Text == ""))
            if (Convert.ToInt32(RobotHelp.Text)>20)
            {
            textBox3.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Value.ToString()) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(numericUpDown2.Value.ToString()));
            textBox2.Text = Convert.ToString( Convert.ToInt32(textBox2.Text) - Convert.ToInt32(numericUpDown1.Value.ToString()));
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(numericUpDown1.Value.ToString()));

            numericUpDown1.Value = numericUpDown1.Minimum;
            numericUpDown2.Value = numericUpDown2.Minimum;
        }
        else
    {
        DealCards.getDeal().Fold("Robot");

    }

            Button mybuttonCall = Controls.Find("TernButton", true).FirstOrDefault() as Button;
            mybuttonCall.Enabled = true;
            mybuttonCall = Controls.Find("FlopButton", true).FirstOrDefault() as Button;
            mybuttonCall.Enabled = true;
            mybuttonCall = Controls.Find("RiverButton", true).FirstOrDefault() as Button;
            mybuttonCall.Enabled = true;
            //No

            //Higher
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = Convert.ToInt32(textBox2.Text);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") numericUpDown2.Value = numericUpDown1.Minimum;
            else
                if (numericUpDown2.Value > Convert.ToInt32(textBox1.Text))
                {
                    numericUpDown2.Value = Convert.ToInt32(textBox1.Text);
                    numericUpDown1.Value = Convert.ToInt32(textBox1.Text);
                }
                else
                    numericUpDown1.Value = numericUpDown2.Value;
        }

        private void TernButton_Click(object sender, EventArgs e)
        {
            RiverButton.Visible = true;
            TernButton.Visible = false;
            DealCards.getDeal().getTern();
        }

        private void RiverButton_Click(object sender, EventArgs e)
        {
            FlopButton.Visible = true;
            RiverButton.Visible = false;
            TernButton.Visible = false;
            DealCards.getDeal().getRiver();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label2.Text += "  "+PlayerName.Text;
            textBox1.Text = PlayerAmount.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
               // dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    PlayerImg.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void PlayerName_Leave(object sender, EventArgs e)
        {
          
      
        }

        private void PlayerAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            try
            {
                StreamReader s = File.OpenText(System.IO.Directory.GetCurrentDirectory() + "/PlayerInfo/Player.txt");
                string read = null;
                bool l = true;
                while ((read = s.ReadLine()) != null)
                {
                    string[] tempArray = read.Split(' ');
                    if (tempArray[0].ToString() == PlayerName.Text)
                    {
                        PlayerAmount.Text = tempArray[1].ToString();
                        MessageBox.Show("С возвращением " + PlayerName.Text);
                        l = false;
                        button1.Enabled = true;
                    }

                }
                s.Close();
                if (l)
                {
                    DialogResult result = MessageBox.Show("К сожалению мы Вас не смогли найти, доюавить Вас в нашу базу?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + "/PlayerInfo/Player.txt", "\n" + PlayerName.Text + " 5000", Encoding.UTF8);
                        PlayerAmount.Text = " 5000";
                        button1.Enabled = true;
                    }
                    else if (result == DialogResult.No)
                    {
                        //code for No
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        //code for Cancel
                    }

                }
                i = 1;
            }
            catch (Exception ex) { };
            if (i != 1)
            {
                try
                {

                    StreamReader s = File.OpenText("..\\..\\..\\MyPoker\\bin\\Debug\\PlayerInfo\\Player.txt");
                    string read = null;
                    bool l = true;
                    while ((read = s.ReadLine()) != null)
                    {
                        string[] tempArray = read.Split(' ');
                        if (tempArray[0].ToString() == PlayerName.Text)
                        {
                            PlayerAmount.Text = tempArray[1].ToString();
                            MessageBox.Show("С возвращением " + PlayerName.Text);
                            l = false;
                            button1.Enabled = true;
                        }

                    }
                    s.Close();
                    if (l)
                    {
                        DialogResult result = MessageBox.Show("К сожалению мы Вас не смогли найти, доюавить Вас в нашу базу?", "Warning",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            File.AppendAllText("..\\..\\..\\MyPoker\\bin\\Debug\\PlayerInfo\\Player.txt", "\n" + PlayerName.Text + " 5000", Encoding.UTF8);
                            PlayerAmount.Text = " 5000";
                            button1.Enabled = true;
                        }
                        else if (result == DialogResult.No)
                        {
                            //code for No
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            //code for Cancel
                        }

                    }
                }
                catch (Exception ex) { };
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Ваши данные успели сохраниться. Приходите еще!","Bye");
            string str = string.Empty;
            try
            {
                using (System.IO.StreamReader reader = System.IO.File.OpenText(System.IO.Directory.GetCurrentDirectory() + "/PlayerInfo/Player.txt"))
                {
                    str = reader.ReadToEnd();
                }
                str = str.Replace(PlayerName.Text + " " + PlayerAmount.Text, PlayerName.Text + " " + textBox1.Text);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + "/PlayerInfo/Player.txt"))
                {
                    file.Write(str);
                }
            }
            catch (Exception es) { };
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text)==0)
            {
                MessageBox.Show("Вы выиграли. Боту пора на покой. Дадим ему отыграться.");
                textBox2.Text = "5000";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == 0)
            {
                MessageBox.Show("Вы проиграли. Вы азартный!. Дадим вам отыграться.");
                textBox1.Text = "5000";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
