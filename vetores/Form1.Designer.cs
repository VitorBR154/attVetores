namespace vetores
{
    partial class frmmenu
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
            menuStrip1 = new MenuStrip();
            exercíciosToolStripMenuItem = new ToolStripMenuItem();
            ex1ToolStripMenuItem = new ToolStripMenuItem();
            ex2ToolStripMenuItem = new ToolStripMenuItem();
            ex3ToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exercíciosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            exercíciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ex1ToolStripMenuItem, ex2ToolStripMenuItem, ex3ToolStripMenuItem });
            exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            exercíciosToolStripMenuItem.Size = new Size(70, 20);
            exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // ex1ToolStripMenuItem
            // 
            ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            ex1ToolStripMenuItem.Size = new Size(180, 22);
            ex1ToolStripMenuItem.Text = "ex1";
            // 
            // ex2ToolStripMenuItem
            // 
            ex2ToolStripMenuItem.Name = "ex2ToolStripMenuItem";
            ex2ToolStripMenuItem.Size = new Size(180, 22);
            ex2ToolStripMenuItem.Text = "ex2";
            // 
            // ex3ToolStripMenuItem
            // 
            ex3ToolStripMenuItem.Name = "ex3ToolStripMenuItem";
            ex3ToolStripMenuItem.Size = new Size(180, 22);
            ex3ToolStripMenuItem.Text = "ex3";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmmenu";
            Text = "Menu - Vetores";
            Load += frmmenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exercíciosToolStripMenuItem;
        private ToolStripMenuItem ex1ToolStripMenuItem;
        private ToolStripMenuItem ex2ToolStripMenuItem;
        private ToolStripMenuItem ex3ToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
