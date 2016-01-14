namespace SRECCreator
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
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.generate = new System.Windows.Forms.ToolStripSplitButton();
            this.autoGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.ToolStripDropDownButton();
            this.motorolaHEXSRECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.paddingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lFCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRLFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blankToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nULLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.byteWidth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textboxASCII = new System.Windows.Forms.RichTextBox();
            this.textboxHEX = new System.Windows.Forms.RichTextBox();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.save,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.generate,
            this.format,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.byteWidth,
            this.toolStripSeparator4,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::SRECCreator.Icons.newFile;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "New";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Enabled = false;
            this.save.Image = global::SRECCreator.Icons.save;
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 22);
            this.save.Text = "Save";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SRECCreator.Icons.open;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = global::SRECCreator.Icons.export;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Export";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // generate
            // 
            this.generate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.generate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoGenerateToolStripMenuItem});
            this.generate.Image = global::SRECCreator.Icons.play;
            this.generate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(32, 22);
            this.generate.Text = "Generate";
            this.generate.ButtonClick += new System.EventHandler(this.generate_ButtonClick);
            this.generate.DropDownOpening += new System.EventHandler(this.generate_DropDownOpening);
            // 
            // autoGenerateToolStripMenuItem
            // 
            this.autoGenerateToolStripMenuItem.Image = global::SRECCreator.Icons.check;
            this.autoGenerateToolStripMenuItem.Name = "autoGenerateToolStripMenuItem";
            this.autoGenerateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autoGenerateToolStripMenuItem.Text = "Auto-Generate";
            this.autoGenerateToolStripMenuItem.Click += new System.EventHandler(this.autoGenerateToolStripMenuItem_Click);
            // 
            // format
            // 
            this.format.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorolaHEXSRECToolStripMenuItem,
            this.toolStripSeparator3,
            this.paddingToolStripMenuItem,
            this.mergeLinesToolStripMenuItem});
            this.format.Image = global::SRECCreator.Icons.properties;
            this.format.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(29, 22);
            this.format.Text = "toolStripDropDownButton1";
            this.format.ToolTipText = "Preferences";
            // 
            // motorolaHEXSRECToolStripMenuItem
            // 
            this.motorolaHEXSRECToolStripMenuItem.Image = global::SRECCreator.Icons.check;
            this.motorolaHEXSRECToolStripMenuItem.Name = "motorolaHEXSRECToolStripMenuItem";
            this.motorolaHEXSRECToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.motorolaHEXSRECToolStripMenuItem.Text = "Motorola HEX (SREC)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // paddingToolStripMenuItem
            // 
            this.paddingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem2,
            this.toolStripMenuItem3,
            this.fFToolStripMenuItem1});
            this.paddingToolStripMenuItem.Name = "paddingToolStripMenuItem";
            this.paddingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.paddingToolStripMenuItem.Text = "Padding";
            this.paddingToolStripMenuItem.DropDownOpening += new System.EventHandler(this.paddingToolStripMenuItem_DropDownOpening);
            // 
            // noneToolStripMenuItem2
            // 
            this.noneToolStripMenuItem2.Name = "noneToolStripMenuItem2";
            this.noneToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.noneToolStripMenuItem2.Text = "None";
            this.noneToolStripMenuItem2.Click += new System.EventHandler(this.noneToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem3.Text = "00";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // fFToolStripMenuItem1
            // 
            this.fFToolStripMenuItem1.Name = "fFToolStripMenuItem1";
            this.fFToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.fFToolStripMenuItem1.Text = "FF";
            this.fFToolStripMenuItem1.Click += new System.EventHandler(this.fFToolStripMenuItem1_Click);
            // 
            // mergeLinesToolStripMenuItem
            // 
            this.mergeLinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem1,
            this.lFToolStripMenuItem1,
            this.cRToolStripMenuItem,
            this.lFCRToolStripMenuItem,
            this.cRLFToolStripMenuItem,
            this.blankToolStripMenuItem1,
            this.nULLToolStripMenuItem});
            this.mergeLinesToolStripMenuItem.Name = "mergeLinesToolStripMenuItem";
            this.mergeLinesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.mergeLinesToolStripMenuItem.Text = "Merge Lines";
            this.mergeLinesToolStripMenuItem.DropDownOpening += new System.EventHandler(this.mergeLinesToolStripMenuItem_DropDownOpening);
            // 
            // noneToolStripMenuItem1
            // 
            this.noneToolStripMenuItem1.Name = "noneToolStripMenuItem1";
            this.noneToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.noneToolStripMenuItem1.Text = "None";
            this.noneToolStripMenuItem1.Click += new System.EventHandler(this.noneToolStripMenuItem1_Click);
            // 
            // lFToolStripMenuItem1
            // 
            this.lFToolStripMenuItem1.Name = "lFToolStripMenuItem1";
            this.lFToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.lFToolStripMenuItem1.Text = "LF";
            this.lFToolStripMenuItem1.Click += new System.EventHandler(this.lFToolStripMenuItem1_Click);
            // 
            // cRToolStripMenuItem
            // 
            this.cRToolStripMenuItem.Name = "cRToolStripMenuItem";
            this.cRToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cRToolStripMenuItem.Text = "CR";
            this.cRToolStripMenuItem.Click += new System.EventHandler(this.cRToolStripMenuItem_Click);
            // 
            // lFCRToolStripMenuItem
            // 
            this.lFCRToolStripMenuItem.Name = "lFCRToolStripMenuItem";
            this.lFCRToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.lFCRToolStripMenuItem.Text = "LF CR";
            this.lFCRToolStripMenuItem.Click += new System.EventHandler(this.lFCRToolStripMenuItem_Click);
            // 
            // cRLFToolStripMenuItem
            // 
            this.cRLFToolStripMenuItem.Name = "cRLFToolStripMenuItem";
            this.cRLFToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cRLFToolStripMenuItem.Text = "CR LF";
            this.cRLFToolStripMenuItem.Click += new System.EventHandler(this.cRLFToolStripMenuItem_Click);
            // 
            // blankToolStripMenuItem1
            // 
            this.blankToolStripMenuItem1.Name = "blankToolStripMenuItem1";
            this.blankToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.blankToolStripMenuItem1.Text = "Blank";
            this.blankToolStripMenuItem1.Click += new System.EventHandler(this.blankToolStripMenuItem1_Click);
            // 
            // nULLToolStripMenuItem
            // 
            this.nULLToolStripMenuItem.Name = "nULLToolStripMenuItem";
            this.nULLToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.nULLToolStripMenuItem.Text = "NULL";
            this.nULLToolStripMenuItem.Click += new System.EventHandler(this.nULLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel1.Text = "Byte width limit";
            // 
            // byteWidth
            // 
            this.byteWidth.Name = "byteWidth";
            this.byteWidth.Size = new System.Drawing.Size(100, 25);
            this.byteWidth.Text = "Inf";
            this.byteWidth.Leave += new System.EventHandler(this.byteWidth_Leave);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::SRECCreator.Icons.help;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textboxASCII);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textboxHEX);
            this.splitContainer1.Size = new System.Drawing.Size(784, 565);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 2;
            // 
            // textboxASCII
            // 
            this.textboxASCII.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxASCII.Location = new System.Drawing.Point(0, 0);
            this.textboxASCII.Name = "textboxASCII";
            this.textboxASCII.Size = new System.Drawing.Size(374, 565);
            this.textboxASCII.TabIndex = 0;
            this.textboxASCII.Text = "";
            this.textboxASCII.WordWrap = false;
            this.textboxASCII.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxASCII_KeyUp);
            // 
            // textboxHEX
            // 
            this.textboxHEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxHEX.Location = new System.Drawing.Point(0, 0);
            this.textboxHEX.Name = "textboxHEX";
            this.textboxHEX.Size = new System.Drawing.Size(406, 565);
            this.textboxHEX.TabIndex = 0;
            this.textboxHEX.Text = "";
            this.textboxHEX.WordWrap = false;
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.DefaultExt = "hex";
            this.exportFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "HEX Creator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton save;
        private System.Windows.Forms.ToolStripSplitButton generate;
        private System.Windows.Forms.ToolStripMenuItem autoGenerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton format;
        private System.Windows.Forms.ToolStripMenuItem motorolaHEXSRECToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox textboxASCII;
        private System.Windows.Forms.RichTextBox textboxHEX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox byteWidth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem paddingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mergeLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lFCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRLFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blankToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nULLToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;

    }
}

