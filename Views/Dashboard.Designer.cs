namespace Gimnasio.Views
{
    partial class Dashboard
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
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLASESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSTRUCTORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSISTENCIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.iNSTRUCTORESToolStripMenuItem,
            this.cLASESToolStripMenuItem,
            this.aSISTENCIASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // cLASESToolStripMenuItem
            // 
            this.cLASESToolStripMenuItem.Name = "cLASESToolStripMenuItem";
            this.cLASESToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.cLASESToolStripMenuItem.Text = "CLASES";
            this.cLASESToolStripMenuItem.Click += new System.EventHandler(this.cLASESToolStripMenuItem_Click);
            // 
            // iNSTRUCTORESToolStripMenuItem
            // 
            this.iNSTRUCTORESToolStripMenuItem.Name = "iNSTRUCTORESToolStripMenuItem";
            this.iNSTRUCTORESToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.iNSTRUCTORESToolStripMenuItem.Text = "INSTRUCTORES";
            this.iNSTRUCTORESToolStripMenuItem.Click += new System.EventHandler(this.iNSTRUCTORESToolStripMenuItem_Click);
            // 
            // aSISTENCIASToolStripMenuItem
            // 
            this.aSISTENCIASToolStripMenuItem.Name = "aSISTENCIASToolStripMenuItem";
            this.aSISTENCIASToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.aSISTENCIASToolStripMenuItem.Text = "ASISTENCIAS";
            this.aSISTENCIASToolStripMenuItem.Click += new System.EventHandler(this.aSISTENCIASToolStripMenuItem_Click);
            // 
            // picture
            // 
            this.picture.Image = global::Gimnasio.Properties.Resources.OOOOOOOOOOOOO;
            this.picture.Location = new System.Drawing.Point(12, 59);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(546, 457);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            this.picture.SizeChanged += new System.EventHandler(this.picture_SizeChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(530, 352);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SizeChanged += new System.EventHandler(this.Dashboard_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLASESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSTRUCTORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSISTENCIASToolStripMenuItem;
        private System.Windows.Forms.PictureBox picture;
    }
}