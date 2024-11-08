namespace UTS_PBO_PR
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            Judul = new Label();
            Deskripsi = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PEMROGRAMAN BERBASIS OBJECT", "ANALISIS VISUALISASI DATA", "OBJECT ORINETED DESIGN" });
            comboBox1.Location = new Point(206, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 31);
            textBox1.TabIndex = 2;
            // 
            // Judul
            // 
            Judul.AutoSize = true;
            Judul.Location = new Point(85, 109);
            Judul.Name = "Judul";
            Judul.Size = new Size(59, 25);
            Judul.TabIndex = 3;
            Judul.Text = "label1";
            Judul.Click += Judul_Click_2;
            // 
            // Deskripsi
            // 
            Deskripsi.AutoSize = true;
            Deskripsi.Location = new Point(85, 164);
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Size = new Size(59, 25);
            Deskripsi.TabIndex = 4;
            Deskripsi.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Deskripsi);
            Controls.Add(Judul);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label Judul;
        private Label Deskripsi;
    }
}
