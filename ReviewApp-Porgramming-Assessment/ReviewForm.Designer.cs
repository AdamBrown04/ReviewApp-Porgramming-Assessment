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
            btnViewReview = new Button();
            lblCharacterCount = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pcbStarFive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStarOne).BeginInit();
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
            txbCompanyName.Location = new Point(129, 12);
            txbCompanyName.Name = "txbCompanyName";
            txbCompanyName.Size = new Size(216, 27);
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
            txbWrittenReview.Location = new Point(129, 153);
            txbWrittenReview.Multiline = true;
            txbWrittenReview.Name = "txbWrittenReview";
            txbWrittenReview.Size = new Size(216, 162);
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
            pcbStarOne.MouseHover += pcbStarOne_MouseHover;
            // 
            // btnViewReview
            // 
            btnViewReview.Location = new Point(9, 424);
            btnViewReview.Name = "btnViewReview";
            btnViewReview.Size = new Size(336, 67);
            btnViewReview.TabIndex = 18;
            btnViewReview.Text = "View review";
            btnViewReview.UseVisualStyleBackColor = true;
            btnViewReview.Click += btnViewReview_Click;
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(371, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(416, 484);
            listBox1.TabIndex = 20;
            // 
            // ReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(815, 506);
            Controls.Add(listBox1);
            Controls.Add(lblCharacterCount);
            Controls.Add(btnViewReview);
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
        private Button btnViewReview;
        private Label lblCharacterCount;
        private ListBox listBox1;
    }
}