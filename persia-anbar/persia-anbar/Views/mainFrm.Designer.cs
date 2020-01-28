namespace persia_anbar
{
    partial class MainFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.انبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رسیدانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حوالهانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انتقالبینانبارهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.انبارToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // انبارToolStripMenuItem
            // 
            this.انبارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.رسیدانبارToolStripMenuItem,
            this.حوالهانبارToolStripMenuItem,
            this.انتقالبینانبارهاToolStripMenuItem});
            this.انبارToolStripMenuItem.Name = "انبارToolStripMenuItem";
            this.انبارToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.انبارToolStripMenuItem.Text = "انبار";
            // 
            // رسیدانبارToolStripMenuItem
            // 
            this.رسیدانبارToolStripMenuItem.Name = "رسیدانبارToolStripMenuItem";
            this.رسیدانبارToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.رسیدانبارToolStripMenuItem.Text = "رسید انبار";
            this.رسیدانبارToolStripMenuItem.Click += new System.EventHandler(this.رسیدانبارToolStripMenuItem_Click);
            // 
            // حوالهانبارToolStripMenuItem
            // 
            this.حوالهانبارToolStripMenuItem.Name = "حوالهانبارToolStripMenuItem";
            this.حوالهانبارToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.حوالهانبارToolStripMenuItem.Text = "حواله انبار";
            // 
            // انتقالبینانبارهاToolStripMenuItem
            // 
            this.انتقالبینانبارهاToolStripMenuItem.Name = "انتقالبینانبارهاToolStripMenuItem";
            this.انتقالبینانبارهاToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.انتقالبینانبارهاToolStripMenuItem.Text = "انتقال بین انبارها";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 440);
            this.panel1.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem انبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رسیدانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حوالهانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انتقالبینانبارهاToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

