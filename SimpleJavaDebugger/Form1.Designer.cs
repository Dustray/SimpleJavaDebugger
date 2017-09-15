namespace SimpleJavaDebugger
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFile = new System.Windows.Forms.Button();
            this.compileAndRun = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.compile = new System.Windows.Forms.Button();
            this.saveJavaFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.debugStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.AcceptsTab = true;
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputBox.Location = new System.Drawing.Point(10, 27);
            this.inputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(424, 457);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.AcceptsTab = true;
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Location = new System.Drawing.Point(437, 171);
            this.outputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(313, 313);
            this.outputBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.saveFile);
            this.groupBox1.Controls.Add(this.compileAndRun);
            this.groupBox1.Controls.Add(this.run);
            this.groupBox1.Controls.Add(this.compile);
            this.groupBox1.Location = new System.Drawing.Point(438, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(311, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(232, 28);
            this.saveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 24);
            this.saveFile.TabIndex = 3;
            this.saveFile.Text = "保存文件";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // compileAndRun
            // 
            this.compileAndRun.Location = new System.Drawing.Point(5, 86);
            this.compileAndRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.compileAndRun.Name = "compileAndRun";
            this.compileAndRun.Size = new System.Drawing.Size(75, 24);
            this.compileAndRun.TabIndex = 2;
            this.compileAndRun.Text = "编译并运行";
            this.compileAndRun.UseVisualStyleBackColor = true;
            this.compileAndRun.Click += new System.EventHandler(this.compileAndRun_Click);
            // 
            // run
            // 
            this.run.Enabled = false;
            this.run.Location = new System.Drawing.Point(5, 57);
            this.run.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 24);
            this.run.TabIndex = 1;
            this.run.Text = "运行";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // compile
            // 
            this.compile.Location = new System.Drawing.Point(5, 28);
            this.compile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(75, 24);
            this.compile.TabIndex = 0;
            this.compile.Text = "编译";
            this.compile.UseVisualStyleBackColor = true;
            this.compile.Click += new System.EventHandler(this.compile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStatusLabel,
            this.debugStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // saveStatusLabel
            // 
            this.saveStatusLabel.Name = "saveStatusLabel";
            this.saveStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.saveStatusLabel.Text = "文件未保存";
            // 
            // debugStatusLabel
            // 
            this.debugStatusLabel.Name = "debugStatusLabel";
            this.debugStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.debugStatusLabel.Text = "未开始调试";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 508);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button compileAndRun;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button compile;
        private System.Windows.Forms.SaveFileDialog saveJavaFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel saveStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel debugStatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

