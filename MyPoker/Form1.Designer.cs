namespace MyPoker
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FlopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxDealer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RobotHelp = new System.Windows.Forms.Label();
            this.TernButton = new System.Windows.Forms.Button();
            this.RiverButton = new System.Windows.Forms.Button();
            this.Combo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlayerAmount = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayerImg = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // FlopButton
            // 
            this.FlopButton.Location = new System.Drawing.Point(588, 769);
            this.FlopButton.Name = "FlopButton";
            this.FlopButton.Size = new System.Drawing.Size(75, 23);
            this.FlopButton.TabIndex = 0;
            this.FlopButton.Text = "Flop";
            this.FlopButton.UseVisualStyleBackColor = true;
            this.FlopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ставка PC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 725);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ставка";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(469, 723);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(469, 42);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 701);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Банк";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Банк";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(469, 694);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "5000";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(469, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "5000";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(24, 419);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 9;
            this.Result.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Общий банк";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(36, 351);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 769);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Call";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(750, 769);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Fold";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxDealer
            // 
            this.pictureBoxDealer.BackColor = System.Drawing.Color.Red;
            this.pictureBoxDealer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDealer.Image = global::MyPoker.Properties.Resources.dealer;
            this.pictureBoxDealer.Location = new System.Drawing.Point(36, 220);
            this.pictureBoxDealer.Name = "pictureBoxDealer";
            this.pictureBoxDealer.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDealer.TabIndex = 14;
            this.pictureBoxDealer.TabStop = false;
            this.pictureBoxDealer.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // RobotHelp
            // 
            this.RobotHelp.AutoSize = true;
            this.RobotHelp.Location = new System.Drawing.Point(370, 71);
            this.RobotHelp.Name = "RobotHelp";
            this.RobotHelp.Size = new System.Drawing.Size(35, 13);
            this.RobotHelp.TabIndex = 15;
            this.RobotHelp.Text = "label6";
            this.RobotHelp.Visible = false;
            // 
            // TernButton
            // 
            this.TernButton.Location = new System.Drawing.Point(588, 769);
            this.TernButton.Name = "TernButton";
            this.TernButton.Size = new System.Drawing.Size(75, 23);
            this.TernButton.TabIndex = 16;
            this.TernButton.Text = "Tern";
            this.TernButton.UseVisualStyleBackColor = true;
            this.TernButton.Visible = false;
            this.TernButton.Click += new System.EventHandler(this.TernButton_Click);
            // 
            // RiverButton
            // 
            this.RiverButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RiverButton.Location = new System.Drawing.Point(588, 769);
            this.RiverButton.Name = "RiverButton";
            this.RiverButton.Size = new System.Drawing.Size(75, 23);
            this.RiverButton.TabIndex = 17;
            this.RiverButton.Text = "River";
            this.RiverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RiverButton.UseVisualStyleBackColor = true;
            this.RiverButton.Visible = false;
            this.RiverButton.Click += new System.EventHandler(this.RiverButton_Click);
            // 
            // Combo
            // 
            this.Combo.AutoSize = true;
            this.Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Combo.Location = new System.Drawing.Point(710, 555);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(0, 20);
            this.Combo.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PlayerAmount);
            this.panel1.Controls.Add(this.PlayerName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PlayerImg);
            this.panel1.Location = new System.Drawing.Point(2, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 838);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(267, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Найти (Добавить)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Сменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(532, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 94);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поехали";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(210, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(937, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "Добро пожаловать в NoLikePoker Club. Желаем удачи и умных действий.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ваше состояние на данный момент";
            // 
            // PlayerAmount
            // 
            this.PlayerAmount.Enabled = false;
            this.PlayerAmount.Location = new System.Drawing.Point(467, 55);
            this.PlayerAmount.Name = "PlayerAmount";
            this.PlayerAmount.Size = new System.Drawing.Size(188, 20);
            this.PlayerAmount.TabIndex = 3;
            this.PlayerAmount.TextChanged += new System.EventHandler(this.PlayerAmount_TextChanged);
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(267, 55);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(106, 20);
            this.PlayerName.TabIndex = 2;
            this.PlayerName.Leave += new System.EventHandler(this.PlayerName_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ваше высочество";
            // 
            // PlayerImg
            // 
            this.PlayerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerImg.Location = new System.Drawing.Point(81, 38);
            this.PlayerImg.Name = "PlayerImg";
            this.PlayerImg.Size = new System.Drawing.Size(180, 185);
            this.PlayerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerImg.TabIndex = 0;
            this.PlayerImg.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(704, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 20;
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1357, 749);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.RiverButton);
            this.Controls.Add(this.TernButton);
            this.Controls.Add(this.RobotHelp);
            this.Controls.Add(this.pictureBoxDealer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "NLP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FlopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxDealer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label RobotHelp;
        private System.Windows.Forms.Button TernButton;
        private System.Windows.Forms.Button RiverButton;
        private System.Windows.Forms.Label Combo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PlayerAmount;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PlayerImg;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;


    }
}

