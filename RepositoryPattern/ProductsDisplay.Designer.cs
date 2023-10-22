namespace RepositoryPattern
{
    partial class ProductsDisplay
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SerachTxtBx = new System.Windows.Forms.TextBox();
            this.NewBtn = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.ProductDisplayDGV = new System.Windows.Forms.DataGridView();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PervBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.LastBtn = new System.Windows.Forms.Button();
            this.FirstPageBtn = new System.Windows.Forms.Button();
            this.DisplayRecordPerPageCb = new System.Windows.Forms.ComboBox();
            this.TotalRecordsLbl = new System.Windows.Forms.Label();
            this.CurrentPageLbl = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDisplayDGV)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.SerachTxtBx);
            this.topPanel.Controls.Add(this.NewBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(884, 64);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serach:";
            // 
            // SerachTxtBx
            // 
            this.SerachTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerachTxtBx.Location = new System.Drawing.Point(175, 19);
            this.SerachTxtBx.MaxLength = 100;
            this.SerachTxtBx.Multiline = true;
            this.SerachTxtBx.Name = "SerachTxtBx";
            this.SerachTxtBx.Size = new System.Drawing.Size(174, 29);
            this.SerachTxtBx.TabIndex = 1;
            this.SerachTxtBx.TextChanged += new System.EventHandler(this.SerachTxtBx_TextChanged);
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(24, 19);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 29);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.ProductDisplayDGV);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 64);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(884, 457);
            this.CenterPanel.TabIndex = 1;
            // 
            // ProductDisplayDGV
            // 
            this.ProductDisplayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDisplayDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDisplayDGV.Location = new System.Drawing.Point(0, 0);
            this.ProductDisplayDGV.Name = "ProductDisplayDGV";
            this.ProductDisplayDGV.Size = new System.Drawing.Size(884, 457);
            this.ProductDisplayDGV.TabIndex = 0;
            this.ProductDisplayDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDisplayDGV_CellContentClick);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.CurrentPageLbl);
            this.BottomPanel.Controls.Add(this.label2);
            this.BottomPanel.Controls.Add(this.PervBtn);
            this.BottomPanel.Controls.Add(this.NextBtn);
            this.BottomPanel.Controls.Add(this.LastBtn);
            this.BottomPanel.Controls.Add(this.FirstPageBtn);
            this.BottomPanel.Controls.Add(this.DisplayRecordPerPageCb);
            this.BottomPanel.Controls.Add(this.TotalRecordsLbl);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 439);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(884, 82);
            this.BottomPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(58, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Show";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PervBtn
            // 
            this.PervBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PervBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PervBtn.Location = new System.Drawing.Point(408, 33);
            this.PervBtn.Name = "PervBtn";
            this.PervBtn.Size = new System.Drawing.Size(37, 31);
            this.PervBtn.TabIndex = 12;
            this.PervBtn.Text = "<";
            this.PervBtn.UseVisualStyleBackColor = false;
            this.PervBtn.Click += new System.EventHandler(this.PervBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Location = new System.Drawing.Point(451, 33);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(37, 31);
            this.NextBtn.TabIndex = 11;
            this.NextBtn.Text = ">";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // LastBtn
            // 
            this.LastBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LastBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastBtn.Location = new System.Drawing.Point(494, 33);
            this.LastBtn.Name = "LastBtn";
            this.LastBtn.Size = new System.Drawing.Size(37, 31);
            this.LastBtn.TabIndex = 10;
            this.LastBtn.Text = ">>";
            this.LastBtn.UseVisualStyleBackColor = false;
            this.LastBtn.Click += new System.EventHandler(this.LastBtn_Click);
            // 
            // FirstPageBtn
            // 
            this.FirstPageBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FirstPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstPageBtn.Location = new System.Drawing.Point(365, 33);
            this.FirstPageBtn.Name = "FirstPageBtn";
            this.FirstPageBtn.Size = new System.Drawing.Size(37, 31);
            this.FirstPageBtn.TabIndex = 9;
            this.FirstPageBtn.Text = "<<";
            this.FirstPageBtn.UseVisualStyleBackColor = false;
            this.FirstPageBtn.Click += new System.EventHandler(this.FirstPageBtn_Click);
            // 
            // DisplayRecordPerPageCb
            // 
            this.DisplayRecordPerPageCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisplayRecordPerPageCb.FormattingEnabled = true;
            this.DisplayRecordPerPageCb.ItemHeight = 13;
            this.DisplayRecordPerPageCb.Location = new System.Drawing.Point(126, 43);
            this.DisplayRecordPerPageCb.Name = "DisplayRecordPerPageCb";
            this.DisplayRecordPerPageCb.Size = new System.Drawing.Size(121, 21);
            this.DisplayRecordPerPageCb.TabIndex = 8;
            this.DisplayRecordPerPageCb.SelectedIndexChanged += new System.EventHandler(this.DisplayRecordPerPageCb_SelectedIndexChanged);
            // 
            // TotalRecordsLbl
            // 
            this.TotalRecordsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalRecordsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalRecordsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalRecordsLbl.Location = new System.Drawing.Point(253, 33);
            this.TotalRecordsLbl.Name = "TotalRecordsLbl";
            this.TotalRecordsLbl.Size = new System.Drawing.Size(106, 31);
            this.TotalRecordsLbl.TabIndex = 7;
            this.TotalRecordsLbl.Text = "Total Records : ??";
            this.TotalRecordsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentPageLbl
            // 
            this.CurrentPageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentPageLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentPageLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentPageLbl.Location = new System.Drawing.Point(548, 33);
            this.CurrentPageLbl.Name = "CurrentPageLbl";
            this.CurrentPageLbl.Size = new System.Drawing.Size(106, 31);
            this.CurrentPageLbl.TabIndex = 14;
            this.CurrentPageLbl.Text = "Total Records : ??";
            this.CurrentPageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "ProductsDisplay";
            this.Text = "ProductsDisplay";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.CenterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDisplayDGV)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView ProductDisplayDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SerachTxtBx;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PervBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button LastBtn;
        private System.Windows.Forms.Button FirstPageBtn;
        private System.Windows.Forms.ComboBox DisplayRecordPerPageCb;
        private System.Windows.Forms.Label TotalRecordsLbl;
        private System.Windows.Forms.Label CurrentPageLbl;
    }
}