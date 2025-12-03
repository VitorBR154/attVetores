namespace vetores
{
    partial class frmex1
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
            lblentrada = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblentrada
            // 
            lblentrada.AutoSize = true;
            lblentrada.Location = new Point(56, 62);
            lblentrada.Name = "lblentrada";
            lblentrada.Size = new Size(47, 15);
            lblentrada.TabIndex = 0;
            lblentrada.Text = "Entrada";
            lblentrada.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // frmex1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lblentrada);
            Name = "frmex1";
            Text = "ex1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblentrada;
        private TextBox textBox1;
    }
}