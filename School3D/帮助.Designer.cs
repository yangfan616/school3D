namespace School3D
{
    partial class 帮助
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
            this.功能介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础功能介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.鹰眼模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标签功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询共功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能介绍ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 功能介绍ToolStripMenuItem
            // 
            this.功能介绍ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础功能介绍ToolStripMenuItem,
            this.鹰眼模式ToolStripMenuItem,
            this.标签功能ToolStripMenuItem,
            this.查询共功能ToolStripMenuItem});
            this.功能介绍ToolStripMenuItem.Name = "功能介绍ToolStripMenuItem";
            this.功能介绍ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.功能介绍ToolStripMenuItem.Text = "功能介绍";
            // 
            // 基础功能介绍ToolStripMenuItem
            // 
            this.基础功能介绍ToolStripMenuItem.Name = "基础功能介绍ToolStripMenuItem";
            this.基础功能介绍ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.基础功能介绍ToolStripMenuItem.Text = "基础功能介绍";
            this.基础功能介绍ToolStripMenuItem.Click += new System.EventHandler(this.基础功能介绍ToolStripMenuItem_Click);
            // 
            // 鹰眼模式ToolStripMenuItem
            // 
            this.鹰眼模式ToolStripMenuItem.Name = "鹰眼模式ToolStripMenuItem";
            this.鹰眼模式ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.鹰眼模式ToolStripMenuItem.Text = "鹰眼模式";
            this.鹰眼模式ToolStripMenuItem.Click += new System.EventHandler(this.鹰眼模式ToolStripMenuItem_Click);
            // 
            // 标签功能ToolStripMenuItem
            // 
            this.标签功能ToolStripMenuItem.Name = "标签功能ToolStripMenuItem";
            this.标签功能ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.标签功能ToolStripMenuItem.Text = "标签功能";
            this.标签功能ToolStripMenuItem.Click += new System.EventHandler(this.标签功能ToolStripMenuItem_Click);
            // 
            // 查询共功能ToolStripMenuItem
            // 
            this.查询共功能ToolStripMenuItem.Name = "查询共功能ToolStripMenuItem";
            this.查询共功能ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查询共功能ToolStripMenuItem.Text = "查询功能";
            this.查询共功能ToolStripMenuItem.Click += new System.EventHandler(this.查询共功能ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(406, 165);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // 帮助
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 206);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "帮助";
            this.Text = "帮助";
            this.Load += new System.EventHandler(this.帮助_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基础功能介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 鹰眼模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标签功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询共功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;


    }
}