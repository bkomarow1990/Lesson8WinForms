
namespace Classwork1
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
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.basketListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addBtn.Location = new System.Drawing.Point(12, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(146, 52);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editBtn.Location = new System.Drawing.Point(12, 70);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(146, 52);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // basketListBox
            // 
            this.basketListBox.FormattingEnabled = true;
            this.basketListBox.ItemHeight = 15;
            this.basketListBox.Location = new System.Drawing.Point(187, 12);
            this.basketListBox.Name = "basketListBox";
            this.basketListBox.Size = new System.Drawing.Size(594, 409);
            this.basketListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.basketListBox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "ShopAdmin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        protected internal System.Windows.Forms.ListBox basketListBox;
    }
}

