namespace WMplayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chBoxWithSlovak = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.txtSlovakDebug = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGerman1Debug = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGerman2Debug = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGerman1Transfer = new System.Windows.Forms.TextBox();
            this.txtGerman2Transfer = new System.Windows.Forms.TextBox();
            this.txtSlovakTransfer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblVerbs = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.chbSK = new System.Windows.Forms.CheckBox();
            this.chbDE1 = new System.Windows.Forms.CheckBox();
            this.chbDE2 = new System.Windows.Forms.CheckBox();
            this.numUDSpeed = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chBWiederholung = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(46, 152);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(954, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1059, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 303);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1222, 81);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 433);
            this.listBox2.TabIndex = 3;
            this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseClick);
            this.listBox2.MouseHover += new System.EventHandler(this.listBox2_MouseHover);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(46, 288);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(954, 96);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(31, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            // 
            // chBoxWithSlovak
            // 
            this.chBoxWithSlovak.AutoSize = true;
            this.chBoxWithSlovak.Checked = true;
            this.chBoxWithSlovak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxWithSlovak.Location = new System.Drawing.Point(1059, 444);
            this.chBoxWithSlovak.Name = "chBoxWithSlovak";
            this.chBoxWithSlovak.Size = new System.Drawing.Size(133, 17);
            this.chBoxWithSlovak.TabIndex = 7;
            this.chBoxWithSlovak.Text = "Mit slowakischem Satz";
            this.chBoxWithSlovak.UseVisualStyleBackColor = true;
            this.chBoxWithSlovak.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(808, 128);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Anfärben";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(919, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Verstecken";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(919, 264);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Verstecken";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(808, 264);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Anfärben";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // txtSlovakDebug
            // 
            this.txtSlovakDebug.Location = new System.Drawing.Point(55, 22);
            this.txtSlovakDebug.Multiline = true;
            this.txtSlovakDebug.Name = "txtSlovakDebug";
            this.txtSlovakDebug.Size = new System.Drawing.Size(633, 20);
            this.txtSlovakDebug.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGerman1Debug
            // 
            this.txtGerman1Debug.Location = new System.Drawing.Point(55, 48);
            this.txtGerman1Debug.Multiline = true;
            this.txtGerman1Debug.Name = "txtGerman1Debug";
            this.txtGerman1Debug.Size = new System.Drawing.Size(633, 20);
            this.txtGerman1Debug.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "DE 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "DE 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "SK";
            // 
            // txtGerman2Debug
            // 
            this.txtGerman2Debug.Location = new System.Drawing.Point(55, 78);
            this.txtGerman2Debug.Multiline = true;
            this.txtGerman2Debug.Name = "txtGerman2Debug";
            this.txtGerman2Debug.Size = new System.Drawing.Size(633, 20);
            this.txtGerman2Debug.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "DE 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "SK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "DE 2";
            // 
            // txtGerman1Transfer
            // 
            this.txtGerman1Transfer.Location = new System.Drawing.Point(83, 474);
            this.txtGerman1Transfer.Multiline = true;
            this.txtGerman1Transfer.Name = "txtGerman1Transfer";
            this.txtGerman1Transfer.Size = new System.Drawing.Size(633, 20);
            this.txtGerman1Transfer.TabIndex = 22;
            // 
            // txtGerman2Transfer
            // 
            this.txtGerman2Transfer.Location = new System.Drawing.Point(83, 503);
            this.txtGerman2Transfer.Multiline = true;
            this.txtGerman2Transfer.Name = "txtGerman2Transfer";
            this.txtGerman2Transfer.Size = new System.Drawing.Size(633, 20);
            this.txtGerman2Transfer.TabIndex = 24;
            // 
            // txtSlovakTransfer
            // 
            this.txtSlovakTransfer.Location = new System.Drawing.Point(83, 448);
            this.txtSlovakTransfer.Multiline = true;
            this.txtSlovakTransfer.Name = "txtSlovakTransfer";
            this.txtSlovakTransfer.Size = new System.Drawing.Size(633, 20);
            this.txtSlovakTransfer.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(1042, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 24);
            this.label9.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(55, -2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(576, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "  1  ,  2  ,  3  ,  4  ,  5  ,  6  ,  7  ,  8  ,  9  ,10  , 11 , 12 , 13 , 14 , 1" +
    "5 , 16 , 17 , 18 , 19 , 20 , 21 , 22 , 23 , 24  , 25 , 26 , 27 ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(855, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(971, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(55, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(576, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "  1  ,  2  ,  3  ,  4  ,  5  ,  6  ,  7  ,  8  ,  9  ,10  , 11 , 12 , 13 , 14 , 1" +
    "5 , 16 , 17 , 18 , 19 , 20 , 21 , 22 , 23 , 24  , 25 , 26 , 27 ";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(294, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(659, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(2, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "label14";
            // 
            // lblVerbs
            // 
            this.lblVerbs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVerbs.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblVerbs.Location = new System.Drawing.Point(769, 397);
            this.lblVerbs.Name = "lblVerbs";
            this.lblVerbs.Size = new System.Drawing.Size(208, 23);
            this.lblVerbs.TabIndex = 34;
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(520, 397);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 35;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(418, 397);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 36;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(855, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(524, 23);
            this.label15.TabIndex = 37;
            // 
            // chbSK
            // 
            this.chbSK.AutoSize = true;
            this.chbSK.Checked = true;
            this.chbSK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSK.Enabled = false;
            this.chbSK.Location = new System.Drawing.Point(428, 123);
            this.chbSK.Name = "chbSK";
            this.chbSK.Size = new System.Drawing.Size(118, 17);
            this.chbSK.TabIndex = 38;
            this.chbSK.Text = "Slowakischem Satz";
            this.chbSK.UseVisualStyleBackColor = true;
            this.chbSK.CheckedChanged += new System.EventHandler(this.chbSK_CheckedChanged);
            // 
            // chbDE1
            //          
            this.chbDE1.AutoSize = true;
            this.chbDE1.Checked = true;
            this.chbDE1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDE1.Enabled = false;
            this.chbDE1.Location = new System.Drawing.Point(562, 123);
            this.chbDE1.Name = "chbDE1";
            this.chbDE1.Size = new System.Drawing.Size(47, 17);
            this.chbDE1.TabIndex = 39;
            this.chbDE1.Text = "DE1";
            this.chbDE1.UseVisualStyleBackColor = true;
            this.chbDE1.CheckedChanged += new System.EventHandler(this.chbDE1_CheckedChanged);
            // 
            // chbDE2
            // 
            this.chbDE2.AutoSize = true;
            this.chbDE2.Checked = true;
            this.chbDE2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDE2.Enabled = false;
            this.chbDE2.Location = new System.Drawing.Point(638, 124);
            this.chbDE2.Name = "chbDE2";
            this.chbDE2.Size = new System.Drawing.Size(47, 17);
            this.chbDE2.TabIndex = 40;
            this.chbDE2.Text = "DE2";
            this.chbDE2.UseVisualStyleBackColor = true;
            this.chbDE2.CheckedChanged += new System.EventHandler(this.chbDE2_CheckedChanged);
            // 
            // numUDSpeed
            // 
            this.numUDSpeed.DecimalPlaces = 1;
            this.numUDSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDSpeed.Location = new System.Drawing.Point(857, 463);
            this.numUDSpeed.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numUDSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUDSpeed.Name = "numUDSpeed";
            this.numUDSpeed.Size = new System.Drawing.Size(120, 20);
            this.numUDSpeed.TabIndex = 43;
            this.numUDSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDSpeed.ValueChanged += new System.EventHandler(this.numUDSpeed_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(766, 465);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Geschwindigkeit";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1056, 402);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Later to removing";
            // 
            // chBWiederholung
            // 
            this.chBWiederholung.AutoSize = true;
            this.chBWiederholung.Checked = true;
            this.chBWiederholung.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBWiederholung.Location = new System.Drawing.Point(748, 91);
            this.chBWiederholung.Name = "chBWiederholung";
            this.chBWiederholung.Size = new System.Drawing.Size(92, 17);
            this.chBWiederholung.TabIndex = 46;
            this.chBWiederholung.Text = "Wiederholung";
            this.chBWiederholung.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 540);
            this.Controls.Add(this.chBWiederholung);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numUDSpeed);
            this.Controls.Add(this.chbDE2);
            this.Controls.Add(this.chbDE1);
            this.Controls.Add(this.chbSK);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblVerbs);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGerman2Transfer);
            this.Controls.Add(this.txtSlovakTransfer);
            this.Controls.Add(this.txtGerman1Transfer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGerman2Debug);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGerman1Debug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSlovakDebug);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chBoxWithSlovak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Das Deutsch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBoxWithSlovak;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox txtSlovakDebug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGerman1Debug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGerman2Debug;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGerman1Transfer;
        private System.Windows.Forms.TextBox txtGerman2Transfer;
        private System.Windows.Forms.TextBox txtSlovakTransfer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblVerbs;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chbSK;
        private System.Windows.Forms.CheckBox chbDE1;
        private System.Windows.Forms.CheckBox chbDE2;
        private System.Windows.Forms.NumericUpDown numUDSpeed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chBWiederholung;
    }
}

