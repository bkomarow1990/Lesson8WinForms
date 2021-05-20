
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
            this.components = new System.ComponentModel.Container();
            this.editBtn = new System.Windows.Forms.Button();
            this.priceNUP = new System.Windows.Forms.NumericUpDown();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.descTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Crimson;
            this.editBtn.CausesValidation = false;
            this.editBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.editBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.Azure;
            this.editBtn.Location = new System.Drawing.Point(29, 357);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(291, 71);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // priceNUP
            // 
            this.priceNUP.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.priceNUP.Location = new System.Drawing.Point(29, 307);
            this.priceNUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceNUP.Name = "priceNUP";
            this.priceNUP.Size = new System.Drawing.Size(291, 27);
            this.priceNUP.TabIndex = 8;
            this.priceNUP.ValueChanged += new System.EventHandler(this.priceNUP_ValueChanged);
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(29, 237);
            this.authorTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(289, 27);
            this.authorTxtBox.TabIndex = 7;
            // 
            // descTxtBox
            // 
            this.descTxtBox.Location = new System.Drawing.Point(29, 164);
            this.descTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descTxtBox.Name = "descTxtBox";
            this.descTxtBox.Size = new System.Drawing.Size(289, 27);
            this.descTxtBox.TabIndex = 6;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(29, 85);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(289, 27);
            this.nameTxtBox.TabIndex = 5;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(29, 57);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 24);
            this.nameLbl.TabIndex = 10;
            this.nameLbl.Text = "Name:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLbl.Location = new System.Drawing.Point(30, 140);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(92, 24);
            this.descriptionLbl.TabIndex = 11;
            this.descriptionLbl.Text = "Description:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.BackColor = System.Drawing.Color.Transparent;
            this.authorLbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorLbl.Location = new System.Drawing.Point(30, 213);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(62, 24);
            this.authorLbl.TabIndex = 12;
            this.authorLbl.Text = "Author:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Bebas Neue Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(30, 283);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(49, 24);
            this.priceLbl.TabIndex = 13;
            this.priceLbl.Text = "Price:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Classwork1.Properties.Resources.flat_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.priceNUP);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.descTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.NumericUpDown priceNUP;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.TextBox descTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}