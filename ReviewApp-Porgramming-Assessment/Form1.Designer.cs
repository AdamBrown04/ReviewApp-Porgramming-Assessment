namespace ReviewApp_Porgramming_Assessment
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
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.lblStarReview = new System.Windows.Forms.Label();
            this.txbStarReview = new System.Windows.Forms.TextBox();
            this.lblWrittenReview = new System.Windows.Forms.Label();
            this.txbWrittenReview = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(129, 21);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(216, 27);
            this.txbUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(9, 82);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(111, 20);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "company name";
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(129, 82);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(216, 27);
            this.txbCompanyName.TabIndex = 3;
            // 
            // lblStarReview
            // 
            this.lblStarReview.AutoSize = true;
            this.lblStarReview.Location = new System.Drawing.Point(9, 146);
            this.lblStarReview.Name = "lblStarReview";
            this.lblStarReview.Size = new System.Drawing.Size(80, 20);
            this.lblStarReview.TabIndex = 4;
            this.lblStarReview.Text = "star review";
            // 
            // txbStarReview
            // 
            this.txbStarReview.Location = new System.Drawing.Point(129, 143);
            this.txbStarReview.Name = "txbStarReview";
            this.txbStarReview.Size = new System.Drawing.Size(216, 27);
            this.txbStarReview.TabIndex = 5;
            // 
            // lblWrittenReview
            // 
            this.lblWrittenReview.AutoSize = true;
            this.lblWrittenReview.Location = new System.Drawing.Point(9, 230);
            this.lblWrittenReview.Name = "lblWrittenReview";
            this.lblWrittenReview.Size = new System.Drawing.Size(102, 20);
            this.lblWrittenReview.TabIndex = 6;
            this.lblWrittenReview.Text = "written review";
            // 
            // txbWrittenReview
            // 
            this.txbWrittenReview.Location = new System.Drawing.Point(129, 223);
            this.txbWrittenReview.Multiline = true;
            this.txbWrittenReview.Name = "txbWrittenReview";
            this.txbWrittenReview.Size = new System.Drawing.Size(216, 162);
            this.txbWrittenReview.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(9, 413);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(333, 67);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit review";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 498);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbWrittenReview);
            this.Controls.Add(this.lblWrittenReview);
            this.Controls.Add(this.txbStarReview);
            this.Controls.Add(this.lblStarReview);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txbUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbUsername;
        private Label lblUsername;
        private Label lblCompanyName;
        private TextBox txbCompanyName;
        private Label lblStarReview;
        private TextBox txbStarReview;
        private Label lblWrittenReview;
        private TextBox txbWrittenReview;
        private Button btnSubmit;
    }
}