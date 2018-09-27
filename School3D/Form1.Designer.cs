namespace School3D
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.fullExtent = new System.Windows.Forms.ToolStripButton();
            this.Pan = new System.Windows.Forms.ToolStripButton();
            this.navigation = new System.Windows.Forms.ToolStripButton();
            this.navagationMode = new System.Windows.Forms.ToolStripButton();
            this.inOut = new System.Windows.Forms.ToolStripButton();
            this.identify = new System.Windows.Forms.ToolStripButton();
            this.measure = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.axGlobeControl1 = new ESRI.ArcGIS.Controls.AxGlobeControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClearBookmarks = new System.Windows.Forms.Button();
            this.btnZoomToBookmark = new System.Windows.Forms.Button();
            this.btnRemoveBookmark = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddBookmark = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnZoomToGlobeLayer = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGlobeControl1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.fullExtent,
            this.Pan,
            this.navigation,
            this.navagationMode,
            this.inOut,
            this.identify,
            this.measure,
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1040, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // open
            // 
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(76, 22);
            this.open.Text = "打开文件";
            this.open.Click += new System.EventHandler(this.open_Click_1);
            // 
            // fullExtent
            // 
            this.fullExtent.Image = ((System.Drawing.Image)(resources.GetObject("fullExtent.Image")));
            this.fullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fullExtent.Name = "fullExtent";
            this.fullExtent.Size = new System.Drawing.Size(76, 22);
            this.fullExtent.Text = "地图全览";
            this.fullExtent.Click += new System.EventHandler(this.fullExtent_Click_1);
            // 
            // Pan
            // 
            this.Pan.Image = ((System.Drawing.Image)(resources.GetObject("Pan.Image")));
            this.Pan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pan.Name = "Pan";
            this.Pan.Size = new System.Drawing.Size(52, 22);
            this.Pan.Text = "移动";
            this.Pan.Click += new System.EventHandler(this.Pan_Click_1);
            // 
            // navigation
            // 
            this.navigation.Image = ((System.Drawing.Image)(resources.GetObject("navigation.Image")));
            this.navigation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(52, 22);
            this.navigation.Text = "导航";
            this.navigation.Click += new System.EventHandler(this.navigation_Click_1);
            // 
            // navagationMode
            // 
            this.navagationMode.Image = ((System.Drawing.Image)(resources.GetObject("navagationMode.Image")));
            this.navagationMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navagationMode.Name = "navagationMode";
            this.navagationMode.Size = new System.Drawing.Size(52, 22);
            this.navagationMode.Text = "模式";
            this.navagationMode.Click += new System.EventHandler(this.navagationMode_Click_1);
            // 
            // inOut
            // 
            this.inOut.Image = ((System.Drawing.Image)(resources.GetObject("inOut.Image")));
            this.inOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inOut.Name = "inOut";
            this.inOut.Size = new System.Drawing.Size(52, 22);
            this.inOut.Text = "放缩";
            this.inOut.Click += new System.EventHandler(this.inOut_Click_1);
            // 
            // identify
            // 
            this.identify.Image = ((System.Drawing.Image)(resources.GetObject("identify.Image")));
            this.identify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.identify.Name = "identify";
            this.identify.Size = new System.Drawing.Size(76, 22);
            this.identify.Text = "信息概览";
            this.identify.Click += new System.EventHandler(this.identify_Click);
            // 
            // measure
            // 
            this.measure.Image = ((System.Drawing.Image)(resources.GetObject("measure.Image")));
            this.measure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(76, 22);
            this.measure.Text = "测量模式";
            this.measure.Click += new System.EventHandler(this.measure_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "帮助";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // axGlobeControl1
            // 
            this.axGlobeControl1.Location = new System.Drawing.Point(404, 50);
            this.axGlobeControl1.Name = "axGlobeControl1";
            this.axGlobeControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGlobeControl1.OcxState")));
            this.axGlobeControl1.Size = new System.Drawing.Size(624, 612);
            this.axGlobeControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axLicenseControl1);
            this.tabPage2.Controls.Add(this.axTOCControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 608);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "图层";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(334, 15);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 4;
            this.axLicenseControl1.Enter += new System.EventHandler(this.axLicenseControl1_Enter);
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Location = new System.Drawing.Point(6, 6);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(370, 596);
            this.axTOCControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(382, 608);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 28);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 59);
            this.textBox2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "放大查询结果";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "清除选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 207);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "结果显示";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axMapControl1);
            this.tabPage1.Controls.Add(this.axToolbarControl1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnClearBookmarks);
            this.tabPage1.Controls.Add(this.btnZoomToBookmark);
            this.tabPage1.Controls.Add(this.btnRemoveBookmark);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.btnAddBookmark);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btnZoomToGlobeLayer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "功能";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(6, 344);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(319, 238);
            this.axMapControl1.TabIndex = 8;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(6, 296);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(319, 28);
            this.axToolbarControl1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 21);
            this.textBox1.TabIndex = 3;
            // 
            // btnClearBookmarks
            // 
            this.btnClearBookmarks.Location = new System.Drawing.Point(171, 252);
            this.btnClearBookmarks.Name = "btnClearBookmarks";
            this.btnClearBookmarks.Size = new System.Drawing.Size(85, 23);
            this.btnClearBookmarks.TabIndex = 7;
            this.btnClearBookmarks.Text = "清除所有书签";
            this.btnClearBookmarks.UseVisualStyleBackColor = true;
            this.btnClearBookmarks.Click += new System.EventHandler(this.btnClearBookmarks_Click);
            // 
            // btnZoomToBookmark
            // 
            this.btnZoomToBookmark.Location = new System.Drawing.Point(87, 252);
            this.btnZoomToBookmark.Name = "btnZoomToBookmark";
            this.btnZoomToBookmark.Size = new System.Drawing.Size(75, 23);
            this.btnZoomToBookmark.TabIndex = 6;
            this.btnZoomToBookmark.Text = "放大至书签";
            this.btnZoomToBookmark.UseVisualStyleBackColor = true;
            this.btnZoomToBookmark.Click += new System.EventHandler(this.btnZoomToBookmark_Click);
            // 
            // btnRemoveBookmark
            // 
            this.btnRemoveBookmark.Location = new System.Drawing.Point(6, 252);
            this.btnRemoveBookmark.Name = "btnRemoveBookmark";
            this.btnRemoveBookmark.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBookmark.TabIndex = 5;
            this.btnRemoveBookmark.Text = "删除该书签";
            this.btnRemoveBookmark.UseVisualStyleBackColor = true;
            this.btnRemoveBookmark.Click += new System.EventHandler(this.btnRemoveBookmark_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 124);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAddBookmark
            // 
            this.btnAddBookmark.Location = new System.Drawing.Point(230, 76);
            this.btnAddBookmark.Name = "btnAddBookmark";
            this.btnAddBookmark.Size = new System.Drawing.Size(75, 23);
            this.btnAddBookmark.TabIndex = 2;
            this.btnAddBookmark.Text = "添加书签";
            this.btnAddBookmark.UseVisualStyleBackColor = true;
            this.btnAddBookmark.Click += new System.EventHandler(this.btnAddBookmark_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "教学楼"});
            this.comboBox1.Location = new System.Drawing.Point(6, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // btnZoomToGlobeLayer
            // 
            this.btnZoomToGlobeLayer.Location = new System.Drawing.Point(230, 32);
            this.btnZoomToGlobeLayer.Name = "btnZoomToGlobeLayer";
            this.btnZoomToGlobeLayer.Size = new System.Drawing.Size(75, 23);
            this.btnZoomToGlobeLayer.TabIndex = 0;
            this.btnZoomToGlobeLayer.Text = "放大至图层";
            this.btnZoomToGlobeLayer.UseVisualStyleBackColor = true;
            this.btnZoomToGlobeLayer.Click += new System.EventHandler(this.btnZoomToGlobeLayer_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 634);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 687);
            this.Controls.Add(this.axGlobeControl1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGlobeControl1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton open;
        private System.Windows.Forms.ToolStripButton fullExtent;
        private System.Windows.Forms.ToolStripButton Pan;
        private System.Windows.Forms.ToolStripButton navigation;
        private System.Windows.Forms.ToolStripButton navagationMode;
        private System.Windows.Forms.ToolStripButton inOut;
        private System.Windows.Forms.ToolStripButton identify;
        private System.Windows.Forms.ToolStripButton measure;
        private ESRI.ArcGIS.Controls.AxGlobeControl axGlobeControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClearBookmarks;
        private System.Windows.Forms.Button btnZoomToBookmark;
        private System.Windows.Forms.Button btnRemoveBookmark;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddBookmark;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnZoomToGlobeLayer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}

