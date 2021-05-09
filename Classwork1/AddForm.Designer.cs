
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
            this.priceLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(14, 49);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(290, 27);
            this.nameTxtBox.TabIndex = 0;
            // 
            // descTxtBox
            // 
            this.descTxtBox.Location = new System.Drawing.Point(14, 128);
            this.descTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descTxtBox.Name = "descTxtBox";
            this.descTxtBox.Size = new System.Drawing.Size(290, 27);
            this.descTxtBox.TabIndex = 1;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(14, 201);
            this.authorTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(290, 27);
            this.authorTxtBox.TabIndex = 2;
            // 
            // priceNUP
            // 
            this.priceNUP.Location = new System.Drawing.Point(14, 271);
            this.priceNUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceNUP.Name = "priceNUP";
            this.priceNUP.Size = new System.Drawing.Size(290, 27);
            this.priceNUP.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Crimson;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.Azure;
            this.addBtn.Location = new System.Drawing.Point(14, 321);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(290, 71);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(15, 247);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(49, 24);
            this.priceLbl.TabIndex = 17;
            this.priceLbl.Text = "Price:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.BackColor = System.Drawing.Color.Transparent;
            this.authorLbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorLbl.Location = new System.Drawing.Point(15, 177);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(62, 24);
            this.authorLbl.TabIndex = 16;
            this.authorLbl.Text = "Author:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLbl.Location = new System.Drawing.Point(15, 104);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(92, 24);
            this.descriptionLbl.TabIndex = 15;
            this.descriptionLbl.Text = "Description:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(14, 21);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 24);
            this.nameLbl.TabIndex = 14;
            this.nameLbl.Text = "Name:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::Classwork1.Properties.Resources.flat_bg;
            this.ClientSize = new System.Drawing.Size(743, 447);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.priceNUP);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.descTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.ForeColor = System.Drawing.Color.PowderBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
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
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label nameLbl;
    }
}