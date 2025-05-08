namespace HangmanGameDemo
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            btnSettings = new Button();
            btnExit = new Button();
            cbCategory = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-5, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(806, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(298, 131);
            label1.Name = "label1";
            label1.Size = new Size(212, 47);
            label1.TabIndex = 1;
            label1.Text = "HANGMAN";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(298, 263);
            button1.Name = "button1";
            button1.Size = new Size(78, 37);
            button1.TabIndex = 2;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Peru;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(432, 263);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(78, 37);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Ayarlar";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Tomato;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(361, 325);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 37);
            btnExit.TabIndex = 4;
            btnExit.Text = "Çıkış Yap";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.White;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Hayvan", "Ülke", "Meyve", "Spor", "Eşya" });
            cbCategory.Location = new Point(381, 209);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(129, 25);
            cbCategory.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(298, 213);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 6;
            label2.Text = "Kategori:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(cbCategory);
            Controls.Add(btnExit);
            Controls.Add(btnSettings);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button btnSettings;
        private Button btnExit;
        private ComboBox cbCategory;
        private Label label2;
    }
}
