namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem,
            this.issueGoodsToolStripMenuItem,
            this.createProductToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // viewInventoryToolStripMenuItem
            // 
            resources.ApplyResources(this.viewInventoryToolStripMenuItem, "viewInventoryToolStripMenuItem");
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            // 
            // issueGoodsToolStripMenuItem
            // 
            resources.ApplyResources(this.issueGoodsToolStripMenuItem, "issueGoodsToolStripMenuItem");
            this.issueGoodsToolStripMenuItem.Name = "issueGoodsToolStripMenuItem";
            this.issueGoodsToolStripMenuItem.Click += new System.EventHandler(this.issueGoodsToolStripMenuItem_Click);
            // 
            // createProductToolStripMenuItem
            // 
            resources.ApplyResources(this.createProductToolStripMenuItem, "createProductToolStripMenuItem");
            this.createProductToolStripMenuItem.Name = "createProductToolStripMenuItem";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProductToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

