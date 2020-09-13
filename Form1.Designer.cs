namespace CraftopiaWorldTransferApp
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
            this.BrowseButton1 = new System.Windows.Forms.Button();
            this.srcSaveDataTxt = new System.Windows.Forms.TextBox();
            this.dstSaveDataTxt = new System.Windows.Forms.TextBox();
            this.BrowseButton2 = new System.Windows.Forms.Button();
            this.srcSaveTransferLbl = new System.Windows.Forms.Label();
            this.dstSaveTransferLbl = new System.Windows.Forms.Label();
            this.srcLabel = new System.Windows.Forms.Label();
            this.dstLabel = new System.Windows.Forms.Label();
            this.srcList = new System.Windows.Forms.ListBox();
            this.dstList = new System.Windows.Forms.ListBox();
            this.transferWorldBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrowseButton1
            // 
            this.BrowseButton1.Location = new System.Drawing.Point(272, 40);
            this.BrowseButton1.Name = "BrowseButton1";
            this.BrowseButton1.Size = new System.Drawing.Size(100, 23);
            this.BrowseButton1.TabIndex = 0;
            this.BrowseButton1.Text = "Browse";
            this.BrowseButton1.UseVisualStyleBackColor = true;
            this.BrowseButton1.Click += new System.EventHandler(this.BrowseButton1_Click);
            // 
            // srcSaveDataTxt
            // 
            this.srcSaveDataTxt.Location = new System.Drawing.Point(12, 40);
            this.srcSaveDataTxt.Name = "srcSaveDataTxt";
            this.srcSaveDataTxt.PlaceholderText = "Enter path of Source SaveData";
            this.srcSaveDataTxt.Size = new System.Drawing.Size(254, 23);
            this.srcSaveDataTxt.TabIndex = 1;
            this.srcSaveDataTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dstSaveDataTxt
            // 
            this.dstSaveDataTxt.Location = new System.Drawing.Point(12, 92);
            this.dstSaveDataTxt.Name = "dstSaveDataTxt";
            this.dstSaveDataTxt.PlaceholderText = "Enter path of Destination SaveData";
            this.dstSaveDataTxt.Size = new System.Drawing.Size(254, 23);
            this.dstSaveDataTxt.TabIndex = 1;
            this.dstSaveDataTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BrowseButton2
            // 
            this.BrowseButton2.Location = new System.Drawing.Point(272, 92);
            this.BrowseButton2.Name = "BrowseButton2";
            this.BrowseButton2.Size = new System.Drawing.Size(100, 23);
            this.BrowseButton2.TabIndex = 0;
            this.BrowseButton2.Text = "Browse";
            this.BrowseButton2.UseVisualStyleBackColor = true;
            this.BrowseButton2.Click += new System.EventHandler(this.BrowseButton2_Click);
            // 
            // srcSaveTransferLbl
            // 
            this.srcSaveTransferLbl.AutoSize = true;
            this.srcSaveTransferLbl.Location = new System.Drawing.Point(12, 22);
            this.srcSaveTransferLbl.Name = "srcSaveTransferLbl";
            this.srcSaveTransferLbl.Size = new System.Drawing.Size(157, 15);
            this.srcSaveTransferLbl.TabIndex = 2;
            this.srcSaveTransferLbl.Text = "Source Save to Transfer from";
            // 
            // dstSaveTransferLbl
            // 
            this.dstSaveTransferLbl.AutoSize = true;
            this.dstSaveTransferLbl.Location = new System.Drawing.Point(12, 74);
            this.dstSaveTransferLbl.Name = "dstSaveTransferLbl";
            this.dstSaveTransferLbl.Size = new System.Drawing.Size(166, 15);
            this.dstSaveTransferLbl.TabIndex = 2;
            this.dstSaveTransferLbl.Text = "Destination Save to Transfer to";
            // 
            // srcLabel
            // 
            this.srcLabel.AutoSize = true;
            this.srcLabel.Location = new System.Drawing.Point(43, 127);
            this.srcLabel.Name = "srcLabel";
            this.srcLabel.Size = new System.Drawing.Size(43, 15);
            this.srcLabel.TabIndex = 4;
            this.srcLabel.Text = "Source";
            // 
            // dstLabel
            // 
            this.dstLabel.AutoSize = true;
            this.dstLabel.Location = new System.Drawing.Point(285, 127);
            this.dstLabel.Name = "dstLabel";
            this.dstLabel.Size = new System.Drawing.Size(67, 15);
            this.dstLabel.TabIndex = 4;
            this.dstLabel.Text = "Destination";
            // 
            // srcList
            // 
            this.srcList.FormattingEnabled = true;
            this.srcList.ItemHeight = 15;
            this.srcList.Location = new System.Drawing.Point(13, 149);
            this.srcList.Name = "srcList";
            this.srcList.Size = new System.Drawing.Size(110, 274);
            this.srcList.TabIndex = 5;
            // 
            // dstList
            // 
            this.dstList.FormattingEnabled = true;
            this.dstList.ItemHeight = 15;
            this.dstList.Location = new System.Drawing.Point(262, 149);
            this.dstList.Name = "dstList";
            this.dstList.Size = new System.Drawing.Size(110, 274);
            this.dstList.TabIndex = 5;
            // 
            // transferWorldBtn
            // 
            this.transferWorldBtn.Location = new System.Drawing.Point(131, 248);
            this.transferWorldBtn.Name = "transferWorldBtn";
            this.transferWorldBtn.Size = new System.Drawing.Size(123, 23);
            this.transferWorldBtn.TabIndex = 6;
            this.transferWorldBtn.Text = "Transfer World →";
            this.transferWorldBtn.UseVisualStyleBackColor = true;
            this.transferWorldBtn.Click += new System.EventHandler(this.transferWorldBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(131, 278);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(123, 23);
            this.ExportBtn.TabIndex = 7;
            this.ExportBtn.Text = "Export World";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 425);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.transferWorldBtn);
            this.Controls.Add(this.dstList);
            this.Controls.Add(this.srcList);
            this.Controls.Add(this.dstLabel);
            this.Controls.Add(this.srcLabel);
            this.Controls.Add(this.dstSaveTransferLbl);
            this.Controls.Add(this.srcSaveTransferLbl);
            this.Controls.Add(this.BrowseButton2);
            this.Controls.Add(this.dstSaveDataTxt);
            this.Controls.Add(this.srcSaveDataTxt);
            this.Controls.Add(this.BrowseButton1);
            this.Name = "Form1";
            this.Text = "World Transfer App";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton1;
        private System.Windows.Forms.TextBox srcSaveDataTxt;
        private System.Windows.Forms.TextBox dstSaveDataTxt;
        private System.Windows.Forms.Label srcSaveTransferLbl;
        private System.Windows.Forms.Label dstSaveTransferLbl;
        private System.Windows.Forms.Label srcLabel;
        private System.Windows.Forms.Label dstLabel;
        private System.Windows.Forms.Button BrowseButton2;
        private System.Windows.Forms.ListBox srcList;
        private System.Windows.Forms.ListBox dstList;
        private System.Windows.Forms.Button transferWorldBtn;
        private System.Windows.Forms.Button ExportBtn;
    }
}

