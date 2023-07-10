namespace DunGen
{
    partial class DunGenForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DunGenForm));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            numericUpDown6 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            numericUpDown7 = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(numericUpDown7);
            panel1.Controls.Add(numericUpDown6);
            panel1.Controls.Add(numericUpDown5);
            panel1.Controls.Add(numericUpDown4);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 620);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(15, 403);
            button2.Name = "button2";
            button2.Size = new Size(167, 31);
            button2.TabIndex = 2;
            button2.Text = "QUIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DG_quit;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 32, 0);
            button1.Location = new Point(15, 355);
            button1.Name = "button1";
            button1.Size = new Size(167, 31);
            button1.TabIndex = 2;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += DG_Generate;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(120, 240);
            numericUpDown6.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown6.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(62, 27);
            numericUpDown6.TabIndex = 1;
            numericUpDown6.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(120, 195);
            numericUpDown5.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(62, 27);
            numericUpDown5.TabIndex = 1;
            numericUpDown5.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(120, 152);
            numericUpDown4.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(62, 27);
            numericUpDown4.TabIndex = 1;
            numericUpDown4.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(120, 108);
            numericUpDown3.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(62, 27);
            numericUpDown3.TabIndex = 1;
            numericUpDown3.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(120, 61);
            numericUpDown2.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(62, 27);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(120, 16);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 242);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 0;
            label6.Text = "bits / unit:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 197);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 0;
            label5.Text = "max high:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 154);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 0;
            label4.Text = "min high:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 110);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 0;
            label3.Text = "max wide:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "min wide:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "# rooms:";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(216, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 620);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(13, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(754, 578);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 289);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 0;
            label7.Text = "% random:";
            // 
            // numericUpDown7
            // 
            numericUpDown7.Location = new Point(120, 287);
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(62, 27);
            numericUpDown7.TabIndex = 1;
            numericUpDown7.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // DunGenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1010, 641);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DunGenForm";
            Text = "DUNgeon GENerator";
            FormClosing += DG_Closing;
            Load += DG_Load;
            Resize += DG_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown7;
        private Label label7;
    }
}