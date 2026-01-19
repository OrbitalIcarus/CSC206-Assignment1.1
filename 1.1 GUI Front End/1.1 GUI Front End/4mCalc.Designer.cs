namespace _1._1_GUI_Front_End
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
            BTadd = new Button();
            BTsub = new Button();
            BTdiv = new Button();
            BTmult = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTadd
            // 
            BTadd.Location = new Point(12, 300);
            BTadd.Name = "BTadd";
            BTadd.Size = new Size(75, 23);
            BTadd.TabIndex = 0;
            BTadd.Text = "ADD";
            BTadd.UseVisualStyleBackColor = true;
            // 
            // BTsub
            // 
            BTsub.Location = new Point(110, 300);
            BTsub.Name = "BTsub";
            BTsub.Size = new Size(75, 23);
            BTsub.TabIndex = 1;
            BTsub.Text = "SUB";
            BTsub.UseVisualStyleBackColor = true;
            // 
            // BTdiv
            // 
            BTdiv.Location = new Point(12, 347);
            BTdiv.Name = "BTdiv";
            BTdiv.Size = new Size(75, 23);
            BTdiv.TabIndex = 2;
            BTdiv.Text = "DIV";
            BTdiv.UseVisualStyleBackColor = true;
            // 
            // BTmult
            // 
            BTmult.Location = new Point(110, 347);
            BTmult.Name = "BTmult";
            BTmult.Size = new Size(75, 23);
            BTmult.TabIndex = 3;
            BTmult.Text = "MULT";
            BTmult.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 250);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 104);
            textBox1.TabIndex = 5;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(602, 285);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(196, 65);
            lblTimer.TabIndex = 6;
            lblTimer.Text = "000000";
            lblTimer.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(625, 220);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 62);
            textBox2.TabIndex = 7;
            textBox2.Text = "SECONDS SPENT ROTATING VIRTUAL BOVINE";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(lblTimer);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(BTmult);
            Controls.Add(BTdiv);
            Controls.Add(BTsub);
            Controls.Add(BTadd);
            Name = "Form1";
            Text = "Calculator App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTadd;
        private Button BTsub;
        private Button BTdiv;
        private Button BTmult;

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private TextBox textBox2;
    }
}
