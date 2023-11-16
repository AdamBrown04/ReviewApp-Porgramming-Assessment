namespace ReviewApp_Porgramming_Assessment
{
    partial class MakeReview
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
            this.lblWrittenReview = new System.Windows.Forms.Label();
            this.txbWrittenReview = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pcbStarFive = new System.Windows.Forms.PictureBox();
            this.pcbStarFour = new System.Windows.Forms.PictureBox();
            this.pcbStarThree = new System.Windows.Forms.PictureBox();
            this.pcbStarTwo = new System.Windows.Forms.PictureBox();
            this.pcbStarOne = new System.Windows.Forms.PictureBox();
            this.btnViewReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarOne)).BeginInit();
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
            this.btnSubmit.Size = new System.Drawing.Size(336, 67);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit review";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pcbStarFive
            // 
            this.pcbStarFive.Image = global::ReviewApp_Porgramming_Assessment.Properties.Resources.whiteStar;
            this.pcbStarFive.Location = new System.Drawing.Point(305, 146);
            this.pcbStarFive.Name = "pcbStarFive";
            this.pcbStarFive.Size = new System.Drawing.Size(40, 41);
            this.pcbStarFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStarFive.TabIndex = 13;
            this.pcbStarFive.TabStop = false;
            this.pcbStarFive.Click += new System.EventHandler(this.pcbStarFive_Click);
            // 
            // pcbStarFour
            // 
            this.pcbStarFour.Image = global::ReviewApp_Porgramming_Assessment.Properties.Resources.whiteStar;
            this.pcbStarFour.Location = new System.Drawing.Point(259, 146);
            this.pcbStarFour.Name = "pcbStarFour";
            this.pcbStarFour.Size = new System.Drawing.Size(40, 41);
            this.pcbStarFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStarFour.TabIndex = 14;
            this.pcbStarFour.TabStop = false;
            this.pcbStarFour.Click += new System.EventHandler(this.pcbStarFour_Click);
            // 
            // pcbStarThree
            // 
            this.pcbStarThree.Image = global::ReviewApp_Porgramming_Assessment.Properties.Resources.whiteStar;
            this.pcbStarThree.Location = new System.Drawing.Point(213, 146);
            this.pcbStarThree.Name = "pcbStarThree";
            this.pcbStarThree.Size = new System.Drawing.Size(40, 41);
            this.pcbStarThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStarThree.TabIndex = 15;
            this.pcbStarThree.TabStop = false;
            this.pcbStarThree.Click += new System.EventHandler(this.pcbStarThree_Click);
            // 
            // pcbStarTwo
            // 
            this.pcbStarTwo.Image = global::ReviewApp_Porgramming_Assessment.Properties.Resources.whiteStar;
            this.pcbStarTwo.Location = new System.Drawing.Point(167, 146);
            this.pcbStarTwo.Name = "pcbStarTwo";
            this.pcbStarTwo.Size = new System.Drawing.Size(40, 41);
            this.pcbStarTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStarTwo.TabIndex = 16;
            this.pcbStarTwo.TabStop = false;
            this.pcbStarTwo.Click += new System.EventHandler(this.pcbStarTwo_Click);
            // 
            // pcbStarOne
            // 
            this.pcbStarOne.Image = global::ReviewApp_Porgramming_Assessment.Properties.Resources.whiteStar;
            this.pcbStarOne.Location = new System.Drawing.Point(121, 146);
            this.pcbStarOne.Name = "pcbStarOne";
            this.pcbStarOne.Size = new System.Drawing.Size(40, 41);
            this.pcbStarOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStarOne.TabIndex = 17;
            this.pcbStarOne.TabStop = false;
            this.pcbStarOne.Click += new System.EventHandler(this.pcbStarOne_Click);
            // 
            // btnViewReview
            // 
            this.btnViewReview.Location = new System.Drawing.Point(9, 486);
            this.btnViewReview.Name = "btnViewReview";
            this.btnViewReview.Size = new System.Drawing.Size(336, 67);
            this.btnViewReview.TabIndex = 18;
            this.btnViewReview.Text = "View review";
            this.btnViewReview.UseVisualStyleBackColor = true;
            this.btnViewReview.Click += new System.EventHandler(this.btnViewReview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 573);
            this.Controls.Add(this.btnViewReview);
            this.Controls.Add(this.pcbStarOne);
            this.Controls.Add(this.pcbStarTwo);
            this.Controls.Add(this.pcbStarThree);
            this.Controls.Add(this.pcbStarFour);
            this.Controls.Add(this.pcbStarFive);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbWrittenReview);
            this.Controls.Add(this.lblWrittenReview);
            this.Controls.Add(this.lblStarReview);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txbUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStarOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbUsername;
        private Label lblUsername;
        private Label lblCompanyName;
        private TextBox txbCompanyName;
        private Label lblStarReview;
        private Label lblWrittenReview;
        private TextBox txbWrittenReview;
        private Button btnSubmit;
        private PictureBox pcbStarFive;
        private PictureBox pcbStarFour;
        private PictureBox pcbStarThree;
        private PictureBox pcbStarTwo;
        private PictureBox pcbStarOne;
        private Button btnViewReview;
    }
}