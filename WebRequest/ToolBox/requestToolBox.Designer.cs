namespace WebRequest.ToolBox
{
    partial class requestToolBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            reqTextBoxUrl = new TextBox();
            btnSend = new Button();
            cmbReqMethod = new ComboBox();
            splitContainer2 = new SplitContainer();
            requestTab = new TabControl();
            tabParams = new TabPage();
            reqParamsDataTable = new DataGridView();
            Enable = new DataGridViewCheckBoxColumn();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            tabAuth = new TabPage();
            tabHeaders = new TabPage();
            headGridDataTable = new DataGridView();
            headVisible = new DataGridViewCheckBoxColumn();
            headKey = new DataGridViewTextBoxColumn();
            headValue = new DataGridViewTextBoxColumn();
            headDescription = new DataGridViewTextBoxColumn();
            tabBody = new TabPage();
            reqTextBox = new TextBox();
            tabResponse = new TabControl();
            tabRespBody = new TabPage();
            respBodyTab = new TabControl();
            respTextTab = new TabPage();
            respTextBox = new TextBox();
            respWebTab = new TabPage();
            tabRespHeaders = new TabPage();
            respHeaderDataTable = new DataGridView();
            respKey = new DataGridViewTextBoxColumn();
            respValue = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            stripProgress = new ToolStripProgressBar();
            webStatusLbl = new ToolStripStatusLabel();
            webWaitTimelbl = new ToolStripStatusLabel();
            responseWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            requestTab.SuspendLayout();
            tabParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reqParamsDataTable).BeginInit();
            tabHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)headGridDataTable).BeginInit();
            tabBody.SuspendLayout();
            tabResponse.SuspendLayout();
            tabRespBody.SuspendLayout();
            respBodyTab.SuspendLayout();
            respTextTab.SuspendLayout();
            respWebTab.SuspendLayout();
            tabRespHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)respHeaderDataTable).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)responseWebView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(reqTextBoxUrl);
            splitContainer1.Panel1.Controls.Add(btnSend);
            splitContainer1.Panel1.Controls.Add(cmbReqMethod);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            splitContainer1.Size = new Size(880, 545);
            splitContainer1.SplitterDistance = 29;
            splitContainer1.TabIndex = 0;
            // 
            // reqTextBoxUrl
            // 
            reqTextBoxUrl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            reqTextBoxUrl.Location = new Point(130, 4);
            reqTextBoxUrl.Name = "reqTextBoxUrl";
            reqTextBoxUrl.Size = new Size(673, 23);
            reqTextBoxUrl.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Dock = DockStyle.Right;
            btnSend.Location = new Point(809, 0);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(71, 29);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cmbReqMethod
            // 
            cmbReqMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReqMethod.FormattingEnabled = true;
            cmbReqMethod.Items.AddRange(new object[] { "Get", "Post", "Put", "Delete", "Head" });
            cmbReqMethod.Location = new Point(3, 3);
            cmbReqMethod.Name = "cmbReqMethod";
            cmbReqMethod.Size = new Size(121, 23);
            cmbReqMethod.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(requestTab);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tabResponse);
            splitContainer2.Size = new Size(880, 490);
            splitContainer2.SplitterDistance = 358;
            splitContainer2.TabIndex = 1;
            // 
            // requestTab
            // 
            requestTab.Controls.Add(tabParams);
            requestTab.Controls.Add(tabAuth);
            requestTab.Controls.Add(tabHeaders);
            requestTab.Controls.Add(tabBody);
            requestTab.Dock = DockStyle.Fill;
            requestTab.Location = new Point(0, 0);
            requestTab.Name = "requestTab";
            requestTab.SelectedIndex = 0;
            requestTab.Size = new Size(358, 490);
            requestTab.TabIndex = 0;
            // 
            // tabParams
            // 
            tabParams.Controls.Add(reqParamsDataTable);
            tabParams.Location = new Point(4, 24);
            tabParams.Name = "tabParams";
            tabParams.Padding = new Padding(3);
            tabParams.Size = new Size(350, 462);
            tabParams.TabIndex = 0;
            tabParams.Text = "Params";
            tabParams.UseVisualStyleBackColor = true;
            // 
            // reqParamsDataTable
            // 
            reqParamsDataTable.BackgroundColor = SystemColors.ButtonFace;
            reqParamsDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reqParamsDataTable.Columns.AddRange(new DataGridViewColumn[] { Enable, Key, Value, Description });
            reqParamsDataTable.Dock = DockStyle.Fill;
            reqParamsDataTable.GridColor = SystemColors.Control;
            reqParamsDataTable.Location = new Point(3, 3);
            reqParamsDataTable.Name = "reqParamsDataTable";
            reqParamsDataTable.RowTemplate.Height = 25;
            reqParamsDataTable.Size = new Size(344, 456);
            reqParamsDataTable.TabIndex = 0;
            // 
            // Enable
            // 
            Enable.HeaderText = "Enable";
            Enable.Name = "Enable";
            Enable.Resizable = DataGridViewTriState.True;
            Enable.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Key
            // 
            Key.HeaderText = "Key";
            Key.Name = "Key";
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            // 
            // Description
            // 
            Description.HeaderText = "description";
            Description.Name = "Description";
            // 
            // tabAuth
            // 
            tabAuth.Location = new Point(4, 24);
            tabAuth.Name = "tabAuth";
            tabAuth.Padding = new Padding(3);
            tabAuth.Size = new Size(350, 462);
            tabAuth.TabIndex = 1;
            tabAuth.Text = "Auth";
            tabAuth.UseVisualStyleBackColor = true;
            // 
            // tabHeaders
            // 
            tabHeaders.Controls.Add(headGridDataTable);
            tabHeaders.Location = new Point(4, 24);
            tabHeaders.Name = "tabHeaders";
            tabHeaders.Padding = new Padding(3);
            tabHeaders.Size = new Size(350, 462);
            tabHeaders.TabIndex = 2;
            tabHeaders.Text = "Headers";
            tabHeaders.UseVisualStyleBackColor = true;
            // 
            // headGridDataTable
            // 
            headGridDataTable.BackgroundColor = SystemColors.Control;
            headGridDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            headGridDataTable.Columns.AddRange(new DataGridViewColumn[] { headVisible, headKey, headValue, headDescription });
            headGridDataTable.Dock = DockStyle.Fill;
            headGridDataTable.GridColor = SystemColors.Control;
            headGridDataTable.Location = new Point(3, 3);
            headGridDataTable.Name = "headGridDataTable";
            headGridDataTable.RowTemplate.Height = 25;
            headGridDataTable.Size = new Size(344, 456);
            headGridDataTable.TabIndex = 0;
            // 
            // headVisible
            // 
            headVisible.Frozen = true;
            headVisible.HeaderText = "Visible";
            headVisible.Name = "headVisible";
            // 
            // headKey
            // 
            headKey.Frozen = true;
            headKey.HeaderText = "Key";
            headKey.Name = "headKey";
            // 
            // headValue
            // 
            headValue.Frozen = true;
            headValue.HeaderText = "Value";
            headValue.Name = "headValue";
            // 
            // headDescription
            // 
            headDescription.Frozen = true;
            headDescription.HeaderText = "Description";
            headDescription.Name = "headDescription";
            // 
            // tabBody
            // 
            tabBody.Controls.Add(reqTextBox);
            tabBody.Location = new Point(4, 24);
            tabBody.Name = "tabBody";
            tabBody.Size = new Size(350, 462);
            tabBody.TabIndex = 3;
            tabBody.Text = "Body";
            tabBody.UseVisualStyleBackColor = true;
            // 
            // reqTextBox
            // 
            reqTextBox.Dock = DockStyle.Fill;
            reqTextBox.Location = new Point(0, 0);
            reqTextBox.Multiline = true;
            reqTextBox.Name = "reqTextBox";
            reqTextBox.Size = new Size(350, 462);
            reqTextBox.TabIndex = 0;
            // 
            // tabResponse
            // 
            tabResponse.Controls.Add(tabRespBody);
            tabResponse.Controls.Add(tabRespHeaders);
            tabResponse.Dock = DockStyle.Fill;
            tabResponse.Location = new Point(0, 0);
            tabResponse.Name = "tabResponse";
            tabResponse.SelectedIndex = 0;
            tabResponse.Size = new Size(518, 490);
            tabResponse.TabIndex = 0;
            // 
            // tabRespBody
            // 
            tabRespBody.Controls.Add(respBodyTab);
            tabRespBody.Location = new Point(4, 24);
            tabRespBody.Name = "tabRespBody";
            tabRespBody.Padding = new Padding(3);
            tabRespBody.Size = new Size(510, 462);
            tabRespBody.TabIndex = 0;
            tabRespBody.Text = "Body";
            tabRespBody.UseVisualStyleBackColor = true;
            // 
            // respBodyTab
            // 
            respBodyTab.Controls.Add(respTextTab);
            respBodyTab.Controls.Add(respWebTab);
            respBodyTab.Dock = DockStyle.Fill;
            respBodyTab.Location = new Point(3, 3);
            respBodyTab.Name = "respBodyTab";
            respBodyTab.SelectedIndex = 0;
            respBodyTab.Size = new Size(504, 456);
            respBodyTab.TabIndex = 0;
            // 
            // respTextTab
            // 
            respTextTab.Controls.Add(respTextBox);
            respTextTab.Location = new Point(4, 24);
            respTextTab.Name = "respTextTab";
            respTextTab.Padding = new Padding(3);
            respTextTab.Size = new Size(496, 428);
            respTextTab.TabIndex = 0;
            respTextTab.Text = "Response Text";
            respTextTab.UseVisualStyleBackColor = true;
            // 
            // respTextBox
            // 
            respTextBox.Dock = DockStyle.Fill;
            respTextBox.Location = new Point(3, 3);
            respTextBox.Multiline = true;
            respTextBox.Name = "respTextBox";
            respTextBox.ScrollBars = ScrollBars.Both;
            respTextBox.Size = new Size(490, 422);
            respTextBox.TabIndex = 0;
            // 
            // respWebTab
            // 
            respWebTab.Controls.Add(responseWebView);
            respWebTab.Location = new Point(4, 24);
            respWebTab.Name = "respWebTab";
            respWebTab.Padding = new Padding(3);
            respWebTab.Size = new Size(496, 428);
            respWebTab.TabIndex = 1;
            respWebTab.Text = "Response Web";
            respWebTab.UseVisualStyleBackColor = true;
            // 
            // tabRespHeaders
            // 
            tabRespHeaders.Controls.Add(respHeaderDataTable);
            tabRespHeaders.Location = new Point(4, 24);
            tabRespHeaders.Name = "tabRespHeaders";
            tabRespHeaders.Padding = new Padding(3);
            tabRespHeaders.Size = new Size(510, 462);
            tabRespHeaders.TabIndex = 1;
            tabRespHeaders.Text = "Headers";
            tabRespHeaders.UseVisualStyleBackColor = true;
            // 
            // respHeaderDataTable
            // 
            respHeaderDataTable.BackgroundColor = SystemColors.Control;
            respHeaderDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            respHeaderDataTable.Columns.AddRange(new DataGridViewColumn[] { respKey, respValue });
            respHeaderDataTable.Dock = DockStyle.Fill;
            respHeaderDataTable.Location = new Point(3, 3);
            respHeaderDataTable.Name = "respHeaderDataTable";
            respHeaderDataTable.ReadOnly = true;
            respHeaderDataTable.RowTemplate.Height = 25;
            respHeaderDataTable.Size = new Size(504, 456);
            respHeaderDataTable.TabIndex = 0;
            // 
            // respKey
            // 
            respKey.HeaderText = "Key";
            respKey.Name = "respKey";
            respKey.ReadOnly = true;
            // 
            // respValue
            // 
            respValue.HeaderText = "Value";
            respValue.Name = "respValue";
            respValue.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { stripProgress, webStatusLbl, webWaitTimelbl });
            statusStrip1.Location = new Point(0, 490);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(880, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // stripProgress
            // 
            stripProgress.Name = "stripProgress";
            stripProgress.Size = new Size(100, 16);
            // 
            // webStatusLbl
            // 
            webStatusLbl.Name = "webStatusLbl";
            webStatusLbl.Size = new Size(0, 17);
            // 
            // webWaitTimelbl
            // 
            webWaitTimelbl.Name = "webWaitTimelbl";
            webWaitTimelbl.Size = new Size(0, 17);
            // 
            // responseWebView
            // 
            responseWebView.AllowExternalDrop = true;
            responseWebView.CreationProperties = null;
            responseWebView.DefaultBackgroundColor = Color.Transparent;
            responseWebView.Dock = DockStyle.Fill;
            responseWebView.Location = new Point(3, 3);
            responseWebView.Name = "responseWebView";
            responseWebView.Size = new Size(490, 422);
            responseWebView.TabIndex = 0;
            responseWebView.ZoomFactor = 1D;
            // 
            // requestToolBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "requestToolBox";
            Size = new Size(880, 545);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            requestTab.ResumeLayout(false);
            tabParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reqParamsDataTable).EndInit();
            tabHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)headGridDataTable).EndInit();
            tabBody.ResumeLayout(false);
            tabBody.PerformLayout();
            tabResponse.ResumeLayout(false);
            tabRespBody.ResumeLayout(false);
            respBodyTab.ResumeLayout(false);
            respTextTab.ResumeLayout(false);
            respTextTab.PerformLayout();
            respWebTab.ResumeLayout(false);
            tabRespHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)respHeaderDataTable).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)responseWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ComboBox cmbReqMethod;
        private TextBox reqTextBoxUrl;
        private Button btnSend;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar stripProgress;
        private SplitContainer splitContainer2;
        private TabControl requestTab;
        private TabPage tabParams;
        private TabPage tabAuth;
        private TabPage tabHeaders;
        private TabPage tabBody;
        private DataGridView reqParamsDataTable;
        private TabControl tabResponse;
        private TabPage tabRespBody;
        private TabPage tabRespHeaders;
        private DataGridView respHeaderDataTable;
        private DataGridViewTextBoxColumn respKey;
        private DataGridViewTextBoxColumn respValue;
        private TabControl respBodyTab;
        private TabPage respTextTab;
        private TextBox respTextBox;
        private TabPage respWebTab;
        private TextBox reqTextBox;
        private DataGridViewCheckBoxColumn Enable;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn Description;
        private DataGridView headGridDataTable;
        private DataGridViewCheckBoxColumn headVisible;
        private DataGridViewTextBoxColumn headKey;
        private DataGridViewTextBoxColumn headValue;
        private DataGridViewTextBoxColumn headDescription;
        private ToolStripStatusLabel webStatusLbl;
        private ToolStripStatusLabel webWaitTimelbl;
        private Microsoft.Web.WebView2.WinForms.WebView2 responseWebView;
    }
}
