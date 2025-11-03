namespace CarGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBoxCar = new PictureBox();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnBreak = new Button();
            btnGas = new Button();
            btnRight = new Button();
            btnLeft = new Button();
            btnDown = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(pictureBoxCar);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 885);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBoxCar
            // 
            pictureBoxCar.Image = Properties.Resources.Car_Back_Red_26353;
            pictureBoxCar.Location = new Point(238, 776);
            pictureBoxCar.Name = "pictureBoxCar";
            pictureBoxCar.Size = new Size(139, 106);
            pictureBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCar.TabIndex = 1;
            pictureBoxCar.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(185, 384);
            panel7.Name = "panel7";
            panel7.Size = new Size(18, 47);
            panel7.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(185, 315);
            panel6.Name = "panel6";
            panel6.Size = new Size(18, 47);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(185, 244);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 47);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(185, 174);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 47);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(185, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 47);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(185, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 47);
            panel2.TabIndex = 0;
            // 
            // btnBreak
            // 
            btnBreak.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBreak.ForeColor = Color.Red;
            btnBreak.Location = new Point(541, 301);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(120, 47);
            btnBreak.TabIndex = 1;
            btnBreak.Text = "BREAK";
            btnBreak.UseVisualStyleBackColor = true;
            btnBreak.Click += btnBreak_Click;
            // 
            // btnGas
            // 
            btnGas.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGas.ForeColor = Color.FromArgb(0, 192, 0);
            btnGas.Location = new Point(541, 381);
            btnGas.Name = "btnGas";
            btnGas.Size = new Size(120, 47);
            btnGas.TabIndex = 2;
            btnGas.Text = "GAS";
            btnGas.UseVisualStyleBackColor = true;
            btnGas.Click += btnGas_Click;
            // 
            // btnRight
            // 
            btnRight.Font = new Font("Impact", 15F, FontStyle.Bold);
            btnRight.ForeColor = Color.Maroon;
            btnRight.Location = new Point(661, 562);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(68, 65);
            btnRight.TabIndex = 3;
            btnRight.Text = "→";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.Font = new Font("Impact", 15F, FontStyle.Bold);
            btnLeft.ForeColor = Color.Maroon;
            btnLeft.Location = new Point(470, 562);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(68, 65);
            btnLeft.TabIndex = 4;
            btnLeft.Text = "←";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnDown
            // 
            btnDown.Font = new Font("Impact", 15F, FontStyle.Bold);
            btnDown.ForeColor = Color.Maroon;
            btnDown.Location = new Point(565, 614);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(68, 65);
            btnDown.TabIndex = 6;
            btnDown.Text = "↓";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(551, 535);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 7;
            label1.Text = "CONTROL";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(185, 813);
            panel8.Name = "panel8";
            panel8.Size = new Size(18, 47);
            panel8.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(185, 744);
            panel9.Name = "panel9";
            panel9.Size = new Size(18, 47);
            panel9.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Location = new Point(185, 673);
            panel10.Name = "panel10";
            panel10.Size = new Size(18, 47);
            panel10.TabIndex = 5;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(185, 603);
            panel11.Name = "panel11";
            panel11.Size = new Size(18, 47);
            panel11.TabIndex = 6;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Location = new Point(185, 532);
            panel12.Name = "panel12";
            panel12.Size = new Size(18, 47);
            panel12.TabIndex = 7;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.Location = new Point(185, 457);
            panel13.Name = "panel13";
            panel13.Size = new Size(18, 47);
            panel13.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 885);
            Controls.Add(label1);
            Controls.Add(btnDown);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(btnGas);
            Controls.Add(btnBreak);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Game";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnBreak;
        private Button btnGas;
        private Button btnRight;
        private Button btnLeft;
        private Button btnDown;
        private Label label1;
        private PictureBox pictureBoxCar;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
    }
}
