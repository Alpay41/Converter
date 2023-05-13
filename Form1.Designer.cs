namespace Converter
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
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(38, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 38);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 145);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 4;
            label1.Text = "Converter";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 39);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(38, 246);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 39);
            comboBox2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(38, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 38);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(231, 326);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "AlpayCa";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
    }
}