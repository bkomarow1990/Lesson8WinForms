
namespace Classwork1
{
    partial class EditForm
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
            this.editBtn = new System.Windows.Forms.Button();
            this.priceNUP = new System.Windows.Forms.NumericUpDown();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.descTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.editBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.Azure;
            this.editBtn.Location = new System.Drawing.Point(26, 268);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(254, 53);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // priceNUP
            // 
            this.priceNUP.Location = new System.Drawing.Point(26, 230);
            this.priceNUP.Name = "priceNUP";
            this.priceNUP.Size = new System.Drawing.Size(254, 23);
            this.priceNUP.TabIndex = 8;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(26, 178);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(254, 23);
            this.authorTxtBox.TabIndex = 7;
            // 
            // descTxtBox
            // 
            this.descTxtBox.Location = new System.Drawing.Point(26, 123);
            this.descTxtBox.Name = "descTxtBox";
            this.descTxtBox.Size = new System.Drawing.Size(254, 23);
            this.descTxtBox.TabIndex = 6;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(26, 64);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(254, 23);
            this.nameTxtBox.TabIndex = 5;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.priceNUP);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.descTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.NumericUpDown priceNUP;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.TextBox descTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
    }
}