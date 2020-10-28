#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Search
{
    partial class SearchPanel
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
            this.chkHighlightSearchText = new System.Windows.Forms.CheckBox();
            this.chkSearchColumn = new System.Windows.Forms.CheckBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkApplyFilter = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkHighlightSearchText
            // 
            this.chkHighlightSearchText.AutoSize = true;
            this.chkHighlightSearchText.Checked = true;
            this.chkHighlightSearchText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHighlightSearchText.Location = new System.Drawing.Point(18, 114);
            this.chkHighlightSearchText.Name = "chkHighlightSearchText";
            this.chkHighlightSearchText.Size = new System.Drawing.Size(128, 17);
            this.chkHighlightSearchText.TabIndex = 18;
            this.chkHighlightSearchText.Text = "Highlight Search Text";
            this.chkHighlightSearchText.UseVisualStyleBackColor = false;
            // 
            // chkSearchColumn
            // 
            this.chkSearchColumn.AutoSize = true;
            this.chkSearchColumn.Location = new System.Drawing.Point(151, 114);
            this.chkSearchColumn.Name = "chkSearchColumn";
            this.chkSearchColumn.Size = new System.Drawing.Size(164, 17);
            this.chkSearchColumn.TabIndex = 15;
            this.chkSearchColumn.Text = "Search only in Product Name";
            this.chkSearchColumn.UseVisualStyleBackColor = false;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(151, 88);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkMatchCase.TabIndex = 14;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = false;
            // 
            // chkApplyFilter
            // 
            this.chkApplyFilter.AutoSize = true;
            this.chkApplyFilter.Location = new System.Drawing.Point(18, 88);
            this.chkApplyFilter.Name = "chkApplyFilter";
            this.chkApplyFilter.Size = new System.Drawing.Size(77, 17);
            this.chkApplyFilter.TabIndex = 13;
            this.chkApplyFilter.Text = "Apply Filter";
            this.chkApplyFilter.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(214, 38);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(151, 38);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 23);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(18, 39);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(122, 20);
            this.txtSearchText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search Panel";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkHighlightSearchText);
            this.Controls.Add(this.chkSearchColumn);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.chkApplyFilter);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtSearchText);
            this.Name = "SearchPanel";
            this.Size = new System.Drawing.Size(345, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHighlightSearchText;
        private System.Windows.Forms.CheckBox chkSearchColumn;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkApplyFilter;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;

    }
}
