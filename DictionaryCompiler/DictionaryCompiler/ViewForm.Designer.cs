namespace DictionaryCompiler
{
    partial class ViewForm
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
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.ewqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdwaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdwaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.materialContextMenuStrip1.AllowDrop = true;
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ewqToolStripMenuItem,
            this.cdwaToolStripMenuItem,
            this.cdwaToolStripMenuItem1});
            this.materialContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(103, 70);
            // 
            // ewqToolStripMenuItem
            // 
            this.ewqToolStripMenuItem.Name = "ewqToolStripMenuItem";
            this.ewqToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.ewqToolStripMenuItem.Text = "ewq";
            // 
            // cdwaToolStripMenuItem
            // 
            this.cdwaToolStripMenuItem.Name = "cdwaToolStripMenuItem";
            this.cdwaToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cdwaToolStripMenuItem.Text = "cdwa";
            // 
            // cdwaToolStripMenuItem1
            // 
            this.cdwaToolStripMenuItem1.Name = "cdwaToolStripMenuItem1";
            this.cdwaToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.cdwaToolStripMenuItem1.Text = "cdwa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(538, 267);
            this.dataGridView1.TabIndex = 1;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 329);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View ";
            this.Load += new System.EventHandler(this.View_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ewqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cdwaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cdwaToolStripMenuItem1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}