
namespace Classwork1
{
    partial class AddForm
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.descTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.priceNUP = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(12, 37);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(254, 23);
            this.nameTxtBox.TabIndex = 0;
            // 
            // descTxtBox
            // 
            this.descTxtBox.Location = new System.Drawing.Point(12, 96);
            this.descTxtBox.Name = "descTxtBox";
            this.descTxtBox.Size = new System.Drawing.Size(254, 23);
            this.descTxtBox.TabIndex = 1;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(12, 151);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(254, 23);
            this.authorTxtBox.TabIndex = 2;
            // 
            // priceNUP
            // 
            this.priceNUP.Location = new System.Drawing.Point(12, 203);
            this.priceNUP.Name = "priceNUP";
            this.priceNUP.Size = new System.Drawing.Size(254, 23);
            this.priceNUP.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.Azure;
            this.addBtn.Location = new System.Drawing.Point(12, 241);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(254, 53);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(650, 335);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.priceNUP);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.descTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.ForeColor = System.Drawing.Color.PowderBlue;
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox descTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.NumericUpDown priceNUP;
        private System.Windows.Forms.Button addBtn;
    }
}