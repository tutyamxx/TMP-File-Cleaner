namespace TMP_File_Cleaner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_CleanTmp = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.lbl_JunkSize = new System.Windows.Forms.Label();
            this.btn_GoTo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CleanTmp
            // 
            this.btn_CleanTmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_CleanTmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CleanTmp.BackgroundImage")));
            this.btn_CleanTmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CleanTmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CleanTmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CleanTmp.Font = new System.Drawing.Font("GeForce", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CleanTmp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_CleanTmp.Location = new System.Drawing.Point(81, 205);
            this.btn_CleanTmp.Name = "btn_CleanTmp";
            this.btn_CleanTmp.Size = new System.Drawing.Size(108, 90);
            this.btn_CleanTmp.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_CleanTmp, "Clean temporary files");
            this.btn_CleanTmp.UseVisualStyleBackColor = false;
            this.btn_CleanTmp.Click += new System.EventHandler(this.btn_CleanTmp_Click);
            this.btn_CleanTmp.MouseHover += new System.EventHandler(this.btn_CleanTmp_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TMP_File_Cleaner.Properties.Resources.wipe;
            this.pictureBox3.Location = new System.Drawing.Point(81, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TMP_File_Cleaner.Properties.Resources.cuteclean;
            this.pictureBox2.Location = new System.Drawing.Point(162, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TMP_File_Cleaner.Properties.Resources.trash;
            this.pictureBox1.Location = new System.Drawing.Point(12, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(231, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(31, 28);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "X";
            this.toolTip1.SetToolTip(this.btn_Close, "Close the application");
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.AutoSize = true;
            this.lbl_Logo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logo.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Logo.Location = new System.Drawing.Point(12, 12);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(177, 30);
            this.lbl_Logo.TabIndex = 7;
            this.lbl_Logo.Text = "TMP File Cleaner";
            // 
            // lbl_JunkSize
            // 
            this.lbl_JunkSize.AutoSize = true;
            this.lbl_JunkSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JunkSize.ForeColor = System.Drawing.Color.White;
            this.lbl_JunkSize.Location = new System.Drawing.Point(17, 46);
            this.lbl_JunkSize.Name = "lbl_JunkSize";
            this.lbl_JunkSize.Size = new System.Drawing.Size(53, 13);
            this.lbl_JunkSize.TabIndex = 8;
            this.lbl_JunkSize.Text = "TestLabel";
            // 
            // btn_GoTo
            // 
            this.btn_GoTo.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_GoTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GoTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoTo.ForeColor = System.Drawing.Color.White;
            this.btn_GoTo.Location = new System.Drawing.Point(194, 12);
            this.btn_GoTo.Name = "btn_GoTo";
            this.btn_GoTo.Size = new System.Drawing.Size(31, 28);
            this.btn_GoTo.TabIndex = 9;
            this.btn_GoTo.Text = "?";
            this.toolTip1.SetToolTip(this.btn_GoTo, "Go to my GitHub");
            this.btn_GoTo.UseVisualStyleBackColor = false;
            this.btn_GoTo.Click += new System.EventHandler(this.btn_GoTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(270, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btn_GoTo);
            this.Controls.Add(this.lbl_JunkSize);
            this.Controls.Add(this.lbl_Logo);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CleanTmp);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(276, 313);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CleanTmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Logo;
        private System.Windows.Forms.Label lbl_JunkSize;
        private System.Windows.Forms.Button btn_GoTo;
    }
}

