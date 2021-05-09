
namespace Lesson8WinForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.showBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.showDialogBtn = new System.Windows.Forms.Button();
            this.showOverloadBtn = new System.Windows.Forms.Button();
            this.setTextForChildrenBtn = new System.Windows.Forms.Button();
            this.CloseAllBtn = new System.Windows.Forms.Button();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(58, 148);
            this.showBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(264, 56);
            this.showBtn.TabIndex = 0;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(58, 109);
            this.colorComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(263, 28);
            this.colorComboBox.TabIndex = 2;
            // 
            // showDialogBtn
            // 
            this.showDialogBtn.Location = new System.Drawing.Point(58, 212);
            this.showDialogBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showDialogBtn.Name = "showDialogBtn";
            this.showDialogBtn.Size = new System.Drawing.Size(264, 56);
            this.showDialogBtn.TabIndex = 3;
            this.showDialogBtn.Text = "ShowDialog";
            this.showDialogBtn.UseVisualStyleBackColor = true;
            this.showDialogBtn.Click += new System.EventHandler(this.showDialogBtn_Click);
            // 
            // showOverloadBtn
            // 
            this.showOverloadBtn.Location = new System.Drawing.Point(58, 276);
            this.showOverloadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showOverloadBtn.Name = "showOverloadBtn";
            this.showOverloadBtn.Size = new System.Drawing.Size(264, 56);
            this.showOverloadBtn.TabIndex = 4;
            this.showOverloadBtn.Text = "Show(Overload)";
            this.showOverloadBtn.UseVisualStyleBackColor = true;
            this.showOverloadBtn.Click += new System.EventHandler(this.showOverloadBtn_Click);
            // 
            // setTextForChildrenBtn
            // 
            this.setTextForChildrenBtn.Location = new System.Drawing.Point(58, 340);
            this.setTextForChildrenBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setTextForChildrenBtn.Name = "setTextForChildrenBtn";
            this.setTextForChildrenBtn.Size = new System.Drawing.Size(264, 56);
            this.setTextForChildrenBtn.TabIndex = 5;
            this.setTextForChildrenBtn.Text = "Set text for children";
            this.setTextForChildrenBtn.UseVisualStyleBackColor = true;
            // 
            // CloseAllBtn
            // 
            this.CloseAllBtn.Location = new System.Drawing.Point(58, 404);
            this.CloseAllBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseAllBtn.Name = "CloseAllBtn";
            this.CloseAllBtn.Size = new System.Drawing.Size(264, 56);
            this.CloseAllBtn.TabIndex = 6;
            this.CloseAllBtn.Text = "Close All";
            this.CloseAllBtn.UseVisualStyleBackColor = true;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(58, 71);
            this.titleTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(263, 27);
            this.titleTxtBox.TabIndex = 7;
            this.titleTxtBox.TextChanged += new System.EventHandler(this.titleTxtBox_TextChanged);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(330, 71);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(121, 20);
            this.infoLbl.TabIndex = 8;
            this.infoLbl.Text = "Info from dialog:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.CloseAllBtn);
            this.Controls.Add(this.setTextForChildrenBtn);
            this.Controls.Add(this.showOverloadBtn);
            this.Controls.Add(this.showDialogBtn);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.showBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button showDialogBtn;
        private System.Windows.Forms.Button showOverloadBtn;
        private System.Windows.Forms.Button setTextForChildrenBtn;
        private System.Windows.Forms.Button CloseAllBtn;
        private System.Windows.Forms.TextBox titleTxtBox;
        protected internal System.Windows.Forms.Label infoLbl;
    }
}

