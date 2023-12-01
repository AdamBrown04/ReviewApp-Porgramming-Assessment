namespace ReviewApp_Porgramming_Assessment
{
    partial class ReviewForm
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
            lblCompanyName = new Label();
            txbCompanyName = new TextBox();
            lblStarReview = new Label();
            lblWrittenReview = new Label();
            txbWrittenReview = new TextBox();
            btnSubmit = new Button();
            pcbStarFive = new PictureBox();
            pcbStarFour = new PictureBox();
            pcbStarThree = new PictureBox();
            pcbStarTwo = new PictureBox();
            pcbStarOne = new PictureBox();
            lblCharacterCount = new Label();
            LsbViewReview = new ListBox();
            lblShowWrittenReview = new Label();
            lblShowStars = new Label();
            lblShowCompanyName = new Label();
            lblShowUsername = new Label();
            pcbShowStars1 = new PictureBox();
            pcbShowStars2 = new PictureBox();
            pcbShowStars3 = new PictureBox();
            pcbShowStars4 = new PictureBox();
            pcbShowStars5 = new PictureBox();
            txbShowWrittenReview = new TextBox();
            txbShowCompanyName = new TextBox();
            txbShowUsername = new TextBox();
            btnUpdateReview = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbStarFive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars5).BeginInit();
            SuspendLayout();
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(9, 12);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(111, 20);
            lblCompanyName.TabIndex = 2;
            lblCompanyName.Text = "company name";
            // 
            // txbCompanyName
            // 
            txbCompanyName.Location = new Point(121, 12);
            txbCompanyName.Name = "txbCompanyName";
            txbCompanyName.Size = new Size(224, 27);
            txbCompanyName.TabIndex = 3;
            // 
            // lblStarReview
            // 
            lblStarReview.AutoSize = true;
            lblStarReview.Location = new Point(9, 76);
            lblStarReview.Name = "lblStarReview";
            lblStarReview.Size = new Size(80, 20);
            lblStarReview.TabIndex = 4;
            lblStarReview.Text = "star review";
            // 
            // lblWrittenReview
            // 
            lblWrittenReview.AutoSize = true;
            lblWrittenReview.Location = new Point(9, 160);
            lblWrittenReview.Name = "lblWrittenReview";
            lblWrittenReview.Size = new Size(102, 20);
            lblWrittenReview.TabIndex = 6;
            lblWrittenReview.Text = "written review";
            // 
            // txbWrittenReview
            // 
            txbWrittenReview.Location = new Point(121, 153);
            txbWrittenReview.Multiline = true;
            txbWrittenReview.Name = "txbWrittenReview";
            txbWrittenReview.Size = new Size(224, 162);
            txbWrittenReview.TabIndex = 7;
            txbWrittenReview.TextChanged += txbWrittenReview_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(9, 341);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(336, 67);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit review";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pcbStarFive
            // 
            pcbStarFive.Image = Properties.Resources.whiteStar;
            pcbStarFive.Location = new Point(305, 76);
            pcbStarFive.Name = "pcbStarFive";
            pcbStarFive.Size = new Size(40, 41);
            pcbStarFive.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbStarFive.TabIndex = 13;
            pcbStarFive.TabStop = false;
            pcbStarFive.Click += pcbStarFive_Click;
            pcbStarFive.MouseLeave += pcbStarFive_MouseLeave;
            pcbStarFive.MouseHover += pcbStarFive_MouseHover;
            // 
            // pcbStarFour
            // 
            pcbStarFour.Image = Properties.Resources.whiteStar;
            pcbStarFour.Location = new Point(259, 76);
            pcbStarFour.Name = "pcbStarFour";
            pcbStarFour.Size = new Size(40, 41);
            pcbStarFour.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbStarFour.TabIndex = 14;
            pcbStarFour.TabStop = false;
            pcbStarFour.Click += pcbStarFour_Click;
            pcbStarFour.MouseLeave += pcbStarFour_MouseLeave;
            pcbStarFour.MouseHover += pcbStarFour_MouseHover;
            // 
            // pcbStarThree
            // 
            pcbStarThree.Image = Properties.Resources.whiteStar;
            pcbStarThree.Location = new Point(213, 76);
            pcbStarThree.Name = "pcbStarThree";
            pcbStarThree.Size = new Size(40, 41);
            pcbStarThree.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbStarThree.TabIndex = 15;
            pcbStarThree.TabStop = false;
            pcbStarThree.Click += pcbStarThree_Click;
            pcbStarThree.MouseLeave += pcbStarThree_MouseLeave;
            pcbStarThree.MouseHover += pcbStarThree_MouseHover;
            // 
            // pcbStarTwo
            // 
            pcbStarTwo.Image = Properties.Resources.whiteStar;
            pcbStarTwo.Location = new Point(167, 76);
            pcbStarTwo.Name = "pcbStarTwo";
            pcbStarTwo.Size = new Size(40, 41);
            pcbStarTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbStarTwo.TabIndex = 16;
            pcbStarTwo.TabStop = false;
            pcbStarTwo.Click += pcbStarTwo_Click;
            pcbStarTwo.MouseLeave += pcbStarTwo_MouseLeave;
            pcbStarTwo.MouseHover += pcbStarTwo_MouseHover;
            // 
            // pcbStarOne
            // 
            pcbStarOne.Image = Properties.Resources.whiteStar;
            pcbStarOne.Location = new Point(121, 76);
            pcbStarOne.Name = "pcbStarOne";
            pcbStarOne.Size = new Size(40, 41);
            pcbStarOne.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbStarOne.TabIndex = 17;
            pcbStarOne.TabStop = false;
            pcbStarOne.Click += pcbStarOne_Click;
            pcbStarOne.MouseLeave += pcbStarOne_MouseLeave;
            pcbStarOne.MouseHover += pcbStarOne_MouseHover;
            // 
            // lblCharacterCount
            // 
            lblCharacterCount.AutoSize = true;
            lblCharacterCount.Location = new Point(298, 318);
            lblCharacterCount.Name = "lblCharacterCount";
            lblCharacterCount.Size = new Size(47, 20);
            lblCharacterCount.TabIndex = 19;
            lblCharacterCount.Text = "0/256";
            // 
            // LsbViewReview
            // 
            LsbViewReview.FormattingEnabled = true;
            LsbViewReview.ItemHeight = 20;
            LsbViewReview.Location = new Point(368, 7);
            LsbViewReview.Name = "LsbViewReview";
            LsbViewReview.Size = new Size(222, 404);
            LsbViewReview.TabIndex = 20;
            LsbViewReview.SelectedIndexChanged += LsbViewReview_SelectedIndexChanged;
            // 
            // lblShowWrittenReview
            // 
            lblShowWrittenReview.AutoSize = true;
            lblShowWrittenReview.Location = new Point(616, 220);
            lblShowWrittenReview.Name = "lblShowWrittenReview";
            lblShowWrittenReview.Size = new Size(102, 20);
            lblShowWrittenReview.TabIndex = 23;
            lblShowWrittenReview.Text = "written review";
            lblShowWrittenReview.Click += label1_Click;
            // 
            // lblShowStars
            // 
            lblShowStars.AutoSize = true;
            lblShowStars.Location = new Point(616, 153);
            lblShowStars.Name = "lblShowStars";
            lblShowStars.Size = new Size(80, 20);
            lblShowStars.TabIndex = 22;
            lblShowStars.Text = "star review";
            // 
            // lblShowCompanyName
            // 
            lblShowCompanyName.AutoSize = true;
            lblShowCompanyName.Location = new Point(616, 76);
            lblShowCompanyName.Name = "lblShowCompanyName";
            lblShowCompanyName.Size = new Size(111, 20);
            lblShowCompanyName.TabIndex = 21;
            lblShowCompanyName.Text = "company name";
            // 
            // lblShowUsername
            // 
            lblShowUsername.AutoSize = true;
            lblShowUsername.Location = new Point(616, 26);
            lblShowUsername.Name = "lblShowUsername";
            lblShowUsername.Size = new Size(73, 20);
            lblShowUsername.TabIndex = 24;
            lblShowUsername.Text = "username";
            // 
            // pcbShowStars1
            // 
            pcbShowStars1.Image = Properties.Resources.whiteStar;
            pcbShowStars1.Location = new Point(725, 140);
            pcbShowStars1.Name = "pcbShowStars1";
            pcbShowStars1.Size = new Size(40, 41);
            pcbShowStars1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbShowStars1.TabIndex = 31;
            pcbShowStars1.TabStop = false;
            // 
            // pcbShowStars2
            // 
            pcbShowStars2.Image = Properties.Resources.whiteStar;
            pcbShowStars2.Location = new Point(771, 140);
            pcbShowStars2.Name = "pcbShowStars2";
            pcbShowStars2.Size = new Size(40, 41);
            pcbShowStars2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbShowStars2.TabIndex = 30;
            pcbShowStars2.TabStop = false;
            // 
            // pcbShowStars3
            // 
            pcbShowStars3.Image = Properties.Resources.whiteStar;
            pcbShowStars3.Location = new Point(817, 140);
            pcbShowStars3.Name = "pcbShowStars3";
            pcbShowStars3.Size = new Size(40, 41);
            pcbShowStars3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbShowStars3.TabIndex = 29;
            pcbShowStars3.TabStop = false;
            // 
            // pcbShowStars4
            // 
            pcbShowStars4.Image = Properties.Resources.whiteStar;
            pcbShowStars4.Location = new Point(863, 140);
            pcbShowStars4.Name = "pcbShowStars4";
            pcbShowStars4.Size = new Size(40, 41);
            pcbShowStars4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbShowStars4.TabIndex = 28;
            pcbShowStars4.TabStop = false;
            // 
            // pcbShowStars5
            // 
            pcbShowStars5.Image = Properties.Resources.whiteStar;
            pcbShowStars5.Location = new Point(909, 140);
            pcbShowStars5.Name = "pcbShowStars5";
            pcbShowStars5.Size = new Size(40, 41);
            pcbShowStars5.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbShowStars5.TabIndex = 27;
            pcbShowStars5.TabStop = false;
            // 
            // txbShowWrittenReview
            // 
            txbShowWrittenReview.Location = new Point(725, 217);
            txbShowWrittenReview.Multiline = true;
            txbShowWrittenReview.Name = "txbShowWrittenReview";
            txbShowWrittenReview.Size = new Size(224, 121);
            txbShowWrittenReview.TabIndex = 26;
            // 
            // txbShowCompanyName
            // 
            txbShowCompanyName.Location = new Point(725, 76);
            txbShowCompanyName.Name = "txbShowCompanyName";
            txbShowCompanyName.Size = new Size(224, 27);
            txbShowCompanyName.TabIndex = 25;
            // 
            // txbShowUsername
            // 
            txbShowUsername.Location = new Point(725, 26);
            txbShowUsername.Name = "txbShowUsername";
            txbShowUsername.ReadOnly = true;
            txbShowUsername.Size = new Size(224, 27);
            txbShowUsername.TabIndex = 32;
            // 
            // btnUpdateReview
            // 
            btnUpdateReview.Location = new Point(616, 349);
            btnUpdateReview.Name = "btnUpdateReview";
            btnUpdateReview.Size = new Size(336, 67);
            btnUpdateReview.TabIndex = 33;
            btnUpdateReview.Text = "Update review";
            btnUpdateReview.UseVisualStyleBackColor = true;
            btnUpdateReview.Visible = false;
            btnUpdateReview.Click += btnUpdateReview_Click;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(970, 428);
            Controls.Add(btnUpdateReview);
            Controls.Add(txbShowUsername);
            Controls.Add(pcbShowStars1);
            Controls.Add(pcbShowStars2);
            Controls.Add(pcbShowStars3);
            Controls.Add(pcbShowStars4);
            Controls.Add(pcbShowStars5);
            Controls.Add(txbShowWrittenReview);
            Controls.Add(txbShowCompanyName);
            Controls.Add(lblShowUsername);
            Controls.Add(lblShowWrittenReview);
            Controls.Add(lblShowStars);
            Controls.Add(lblShowCompanyName);
            Controls.Add(LsbViewReview);
            Controls.Add(lblCharacterCount);
            Controls.Add(pcbStarOne);
            Controls.Add(pcbStarTwo);
            Controls.Add(pcbStarThree);
            Controls.Add(pcbStarFour);
            Controls.Add(pcbStarFive);
            Controls.Add(btnSubmit);
            Controls.Add(txbWrittenReview);
            Controls.Add(lblWrittenReview);
            Controls.Add(lblStarReview);
            Controls.Add(txbCompanyName);
            Controls.Add(lblCompanyName);
            ForeColor = SystemColors.ControlText;
            Name = "ReviewForm";
            Text = "Make a review";
            ((System.ComponentModel.ISupportInitialize)pcbStarFive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarFour).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbShowStars5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label lblCharacterCount;
        private ListBox LsbViewReview;
        private Label lblShowWrittenReview;
        private Label lblShowStars;
        private Label lblShowCompanyName;
        private Label lblShowUsername;
        private PictureBox pcbShowStars1;
        private PictureBox pcbShowStars2;
        private PictureBox pcbShowStars3;
        private PictureBox pcbShowStars4;
        private PictureBox pcbShowStars5;
        private TextBox txbShowWrittenReview;
        private TextBox txbShowCompanyName;
        private TextBox txbShowUsername;
        private Button btnUpdateReview;
    }
}