namespace Project
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
            this.startGameBtn = new System.Windows.Forms.Button();
            this.htpGameBtn = new System.Windows.Forms.Button();
            this.aboutGameBtn = new System.Windows.Forms.Button();
            this.returnToMenuBtn = new System.Windows.Forms.Button();
            this.startCountingBtn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gameBtn3 = new System.Windows.Forms.Button();
            this.gameBtn1 = new System.Windows.Forms.Button();
            this.gameBtn2 = new System.Windows.Forms.Button();
            this.gameBtn4 = new System.Windows.Forms.Button();
            this.gameBtn6 = new System.Windows.Forms.Button();
            this.gameBtn5 = new System.Windows.Forms.Button();
            this.gameBtn9 = new System.Windows.Forms.Button();
            this.gameBtn8 = new System.Windows.Forms.Button();
            this.gameBtn7 = new System.Windows.Forms.Button();
            this.exitGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(261, 73);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(100, 42);
            this.startGameBtn.TabIndex = 0;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // htpGameBtn
            // 
            this.htpGameBtn.Location = new System.Drawing.Point(261, 163);
            this.htpGameBtn.Name = "htpGameBtn";
            this.htpGameBtn.Size = new System.Drawing.Size(100, 40);
            this.htpGameBtn.TabIndex = 1;
            this.htpGameBtn.Text = "How to play";
            this.htpGameBtn.UseVisualStyleBackColor = true;
            this.htpGameBtn.Click += new System.EventHandler(this.htpGameBtn_Click);
            // 
            // aboutGameBtn
            // 
            this.aboutGameBtn.Location = new System.Drawing.Point(261, 256);
            this.aboutGameBtn.Name = "aboutGameBtn";
            this.aboutGameBtn.Size = new System.Drawing.Size(100, 40);
            this.aboutGameBtn.TabIndex = 2;
            this.aboutGameBtn.Text = "About";
            this.aboutGameBtn.UseVisualStyleBackColor = true;
            this.aboutGameBtn.Click += new System.EventHandler(this.aboutGameBtn_Click);
            // 
            // returnToMenuBtn
            // 
            this.returnToMenuBtn.Location = new System.Drawing.Point(261, 403);
            this.returnToMenuBtn.Name = "returnToMenuBtn";
            this.returnToMenuBtn.Size = new System.Drawing.Size(100, 39);
            this.returnToMenuBtn.TabIndex = 4;
            this.returnToMenuBtn.Text = "Return to Menu";
            this.returnToMenuBtn.UseVisualStyleBackColor = true;
            this.returnToMenuBtn.Click += new System.EventHandler(this.returnToMenuBtn_Click);
            // 
            // startCountingBtn
            // 
            this.startCountingBtn.Location = new System.Drawing.Point(271, 352);
            this.startCountingBtn.Name = "startCountingBtn";
            this.startCountingBtn.Size = new System.Drawing.Size(75, 23);
            this.startCountingBtn.TabIndex = 14;
            this.startCountingBtn.Text = "Start";
            this.startCountingBtn.UseVisualStyleBackColor = true;
            this.startCountingBtn.Click += new System.EventHandler(this.startCountingBtn_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // gameBtn3
            // 
            this.gameBtn3.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn3.Location = new System.Drawing.Point(444, 256);
            this.gameBtn3.Name = "gameBtn3";
            this.gameBtn3.Size = new System.Drawing.Size(139, 90);
            this.gameBtn3.TabIndex = 13;
            this.gameBtn3.UseVisualStyleBackColor = true;
            this.gameBtn3.Click += new System.EventHandler(this.gameBtn3_Click);
            // 
            // gameBtn1
            // 
            this.gameBtn1.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn1.Location = new System.Drawing.Point(41, 256);
            this.gameBtn1.Name = "gameBtn1";
            this.gameBtn1.Size = new System.Drawing.Size(139, 90);
            this.gameBtn1.TabIndex = 12;
            this.gameBtn1.UseVisualStyleBackColor = true;
            this.gameBtn1.Click += new System.EventHandler(this.gameBtn1_Click);
            // 
            // gameBtn2
            // 
            this.gameBtn2.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn2.Location = new System.Drawing.Point(239, 256);
            this.gameBtn2.Name = "gameBtn2";
            this.gameBtn2.Size = new System.Drawing.Size(139, 90);
            this.gameBtn2.TabIndex = 11;
            this.gameBtn2.UseVisualStyleBackColor = true;
            this.gameBtn2.Click += new System.EventHandler(this.gameBtn2_Click);
            // 
            // gameBtn4
            // 
            this.gameBtn4.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn4.Location = new System.Drawing.Point(41, 138);
            this.gameBtn4.Name = "gameBtn4";
            this.gameBtn4.Size = new System.Drawing.Size(139, 90);
            this.gameBtn4.TabIndex = 10;
            this.gameBtn4.UseVisualStyleBackColor = true;
            this.gameBtn4.Click += new System.EventHandler(this.gameBtn4_Click);
            // 
            // gameBtn6
            // 
            this.gameBtn6.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn6.Location = new System.Drawing.Point(444, 138);
            this.gameBtn6.Name = "gameBtn6";
            this.gameBtn6.Size = new System.Drawing.Size(139, 90);
            this.gameBtn6.TabIndex = 9;
            this.gameBtn6.UseVisualStyleBackColor = true;
            this.gameBtn6.Click += new System.EventHandler(this.gameBtn6_Click);
            // 
            // gameBtn5
            // 
            this.gameBtn5.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn5.Location = new System.Drawing.Point(239, 138);
            this.gameBtn5.Name = "gameBtn5";
            this.gameBtn5.Size = new System.Drawing.Size(139, 90);
            this.gameBtn5.TabIndex = 8;
            this.gameBtn5.UseVisualStyleBackColor = true;
            this.gameBtn5.Click += new System.EventHandler(this.gameBtn5_Click);
            // 
            // gameBtn9
            // 
            this.gameBtn9.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn9.Location = new System.Drawing.Point(444, 12);
            this.gameBtn9.Name = "gameBtn9";
            this.gameBtn9.Size = new System.Drawing.Size(139, 90);
            this.gameBtn9.TabIndex = 7;
            this.gameBtn9.UseVisualStyleBackColor = true;
            this.gameBtn9.Click += new System.EventHandler(this.gameBtn9_Click);
            // 
            // gameBtn8
            // 
            this.gameBtn8.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn8.Location = new System.Drawing.Point(239, 12);
            this.gameBtn8.Name = "gameBtn8";
            this.gameBtn8.Size = new System.Drawing.Size(139, 90);
            this.gameBtn8.TabIndex = 6;
            this.gameBtn8.UseVisualStyleBackColor = true;
            this.gameBtn8.Click += new System.EventHandler(this.gameBtn8_Click);
            // 
            // gameBtn7
            // 
            this.gameBtn7.Image = global::Project.Properties.Resources._180px_Goblin_face;
            this.gameBtn7.Location = new System.Drawing.Point(41, 12);
            this.gameBtn7.Name = "gameBtn7";
            this.gameBtn7.Size = new System.Drawing.Size(139, 90);
            this.gameBtn7.TabIndex = 5;
            this.gameBtn7.UseVisualStyleBackColor = true;
            this.gameBtn7.Click += new System.EventHandler(this.gameBtn7_Click);
            // 
            // exitGameBtn
            // 
            this.exitGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.exitGameBtn.BackgroundImage = global::Project.Properties.Resources.orc_001;
            this.exitGameBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitGameBtn.Location = new System.Drawing.Point(261, 404);
            this.exitGameBtn.Name = "exitGameBtn";
            this.exitGameBtn.Size = new System.Drawing.Size(100, 38);
            this.exitGameBtn.TabIndex = 3;
            this.exitGameBtn.Text = "Exit";
            this.exitGameBtn.UseVisualStyleBackColor = true;
            this.exitGameBtn.Click += new System.EventHandler(this.exitGameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Project.Properties.Resources.orc_001;
            this.ClientSize = new System.Drawing.Size(628, 455);
            this.Controls.Add(this.startCountingBtn);
            this.Controls.Add(this.gameBtn3);
            this.Controls.Add(this.gameBtn1);
            this.Controls.Add(this.gameBtn2);
            this.Controls.Add(this.gameBtn4);
            this.Controls.Add(this.gameBtn6);
            this.Controls.Add(this.gameBtn5);
            this.Controls.Add(this.gameBtn9);
            this.Controls.Add(this.gameBtn8);
            this.Controls.Add(this.gameBtn7);
            this.Controls.Add(this.returnToMenuBtn);
            this.Controls.Add(this.exitGameBtn);
            this.Controls.Add(this.aboutGameBtn);
            this.Controls.Add(this.htpGameBtn);
            this.Controls.Add(this.startGameBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hit The Orc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button htpGameBtn;
        private System.Windows.Forms.Button aboutGameBtn;
        private System.Windows.Forms.Button exitGameBtn;
        private System.Windows.Forms.Button returnToMenuBtn;
        private System.Windows.Forms.Button gameBtn7;
        private System.Windows.Forms.Button gameBtn8;
        private System.Windows.Forms.Button gameBtn9;
        private System.Windows.Forms.Button gameBtn5;
        private System.Windows.Forms.Button gameBtn6;
        private System.Windows.Forms.Button gameBtn4;
        private System.Windows.Forms.Button gameBtn2;
        private System.Windows.Forms.Button gameBtn1;
        private System.Windows.Forms.Button gameBtn3;
        private System.Windows.Forms.Button startCountingBtn;
        private System.Windows.Forms.Timer timer2;
    }
}

