namespace WebRequest
{
    partial class Form1
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
            mainSplit = new SplitContainer();
            centerSplit = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            requestToolBox1 = new ToolBox.requestToolBox();
            ((System.ComponentModel.ISupportInitialize)mainSplit).BeginInit();
            mainSplit.Panel2.SuspendLayout();
            mainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)centerSplit).BeginInit();
            centerSplit.Panel1.SuspendLayout();
            centerSplit.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // mainSplit
            // 
            mainSplit.Dock = DockStyle.Fill;
            mainSplit.Location = new Point(0, 0);
            mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel2
            // 
            mainSplit.Panel2.Controls.Add(centerSplit);
            mainSplit.Size = new Size(1154, 690);
            mainSplit.SplitterDistance = 184;
            mainSplit.TabIndex = 0;
            // 
            // centerSplit
            // 
            centerSplit.Dock = DockStyle.Fill;
            centerSplit.Location = new Point(0, 0);
            centerSplit.Name = "centerSplit";
            centerSplit.Orientation = Orientation.Horizontal;
            // 
            // centerSplit.Panel1
            // 
            centerSplit.Panel1.Controls.Add(tabControl1);
            centerSplit.Size = new Size(966, 690);
            centerSplit.SplitterDistance = 635;
            centerSplit.TabIndex = 0;
            centerSplit.SplitterMoved += centerSplit_SplitterMoved;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 635);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(requestToolBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(958, 607);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // requestToolBox1
            // 
            requestToolBox1.Dock = DockStyle.Fill;
            requestToolBox1.Location = new Point(3, 3);
            requestToolBox1.Name = "requestToolBox1";
            requestToolBox1.Size = new Size(952, 601);
            requestToolBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 690);
            Controls.Add(mainSplit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplit).EndInit();
            mainSplit.ResumeLayout(false);
            centerSplit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)centerSplit).EndInit();
            centerSplit.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer mainSplit;
        private SplitContainer centerSplit;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ToolBox.requestToolBox requestToolBox1;
        private TabPage tabPage2;
    }
}