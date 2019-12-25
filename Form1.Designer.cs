namespace spinningchicken
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2Score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Panel();
            this.figure1 = new System.Windows.Forms.PictureBox();
            this.block7 = new System.Windows.Forms.PictureBox();
            this.block8 = new System.Windows.Forms.PictureBox();
            this.block6 = new System.Windows.Forms.PictureBox();
            this.block5 = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.moveSpeed = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(0, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 13);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score: ";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label2Score);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(279, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 79);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // label2Score
            // 
            this.label2Score.AutoSize = true;
            this.label2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2Score.ForeColor = System.Drawing.Color.White;
            this.label2Score.Location = new System.Drawing.Point(49, 46);
            this.label2Score.Name = "label2Score";
            this.label2Score.Size = new System.Drawing.Size(86, 31);
            this.label2Score.TabIndex = 1;
            this.label2Score.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter to restart";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.White;
            this.screen.BackgroundImage = global::spinningchicken.Properties.Resources._80086823_799651893884033_8478695059292684288_n;
            this.screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.screen.Controls.Add(this.figure1);
            this.screen.Controls.Add(this.scoreLabel);
            this.screen.Controls.Add(this.block7);
            this.screen.Controls.Add(this.block8);
            this.screen.Controls.Add(this.block6);
            this.screen.Controls.Add(this.block5);
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.block1);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.panel1);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(800, 420);
            this.screen.TabIndex = 1;
            // 
            // figure1
            // 
            this.figure1.BackColor = System.Drawing.Color.Transparent;
            this.figure1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figure1.Image = global::spinningchicken.Properties.Resources.kurkaaa;
            this.figure1.Location = new System.Drawing.Point(12, 333);
            this.figure1.Name = "figure1";
            this.figure1.Size = new System.Drawing.Size(60, 44);
            this.figure1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.figure1.TabIndex = 0;
            this.figure1.TabStop = false;
            this.figure1.Tag = "";
            // 
            // block7
            // 
            this.block7.BackColor = System.Drawing.Color.Fuchsia;
            this.block7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.block7.Enabled = false;
            this.block7.Image = global::spinningchicken.Properties.Resources.Bez_nazwy_1;
            this.block7.Location = new System.Drawing.Point(30, 333);
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(60, 117);
            this.block7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block7.TabIndex = 12;
            this.block7.TabStop = false;
            // 
            // block8
            // 
            this.block8.BackColor = System.Drawing.Color.Fuchsia;
            this.block8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.block8.Enabled = false;
            this.block8.Image = global::spinningchicken.Properties.Resources.Bez_nazwy_1;
            this.block8.Location = new System.Drawing.Point(30, 0);
            this.block8.Name = "block8";
            this.block8.Size = new System.Drawing.Size(60, 100);
            this.block8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block8.TabIndex = 11;
            this.block8.TabStop = false;
            // 
            // block6
            // 
            this.block6.BackColor = System.Drawing.Color.Fuchsia;
            this.block6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.block6.Image = global::spinningchicken.Properties.Resources.Bez_nazwy_1;
            this.block6.Location = new System.Drawing.Point(263, 371);
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(60, 79);
            this.block6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block6.TabIndex = 9;
            this.block6.TabStop = false;
            // 
            // block5
            // 
            this.block5.BackColor = System.Drawing.Color.Fuchsia;
            this.block5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.block5.Image = global::spinningchicken.Properties.Resources.Bez_nazwy_1;
            this.block5.Location = new System.Drawing.Point(263, 0);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(60, 129);
            this.block5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block5.TabIndex = 8;
            this.block5.TabStop = false;
            // 
            // block4
            // 
            this.block4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.block4.BackColor = System.Drawing.Color.Fuchsia;
            this.block4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.block4.Image = global::spinningchicken.Properties.Resources.Bez_nazwy_1;
            this.block4.Location = new System.Drawing.Point(740, 353);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(60, 67);
            this.block4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block4.TabIndex = 4;
            this.block4.TabStop = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.Fuchsia;
            this.block3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.block3.Image = global::spinningchicken.Properties.Resources.Bez_nazwy_1;
            this.block3.Location = new System.Drawing.Point(740, 0);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(60, 119);
            this.block3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block3.TabIndex = 3;
            this.block3.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Transparent;
            this.block1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.block1.Image = global::spinningchicken.Properties.Resources.Bez_nazwy_1;
            this.block1.Location = new System.Drawing.Point(503, 0);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(60, 100);
            this.block1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block1.TabIndex = 2;
            this.block1.TabStop = false;
            // 
            // block2
            // 
            this.block2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.block2.BackColor = System.Drawing.Color.Fuchsia;
            this.block2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.block2.Image = global::spinningchicken.Properties.Resources.Bez_nazwy_1;
            this.block2.Location = new System.Drawing.Point(503, 321);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(60, 99);
            this.block2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block2.TabIndex = 1;
            this.block2.TabStop = false;
            // 
            // moveSpeed
            // 
            this.moveSpeed.Enabled = true;
            this.moveSpeed.Interval = 4000;
            this.moveSpeed.Tick += new System.EventHandler(this.moveSpeed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.screen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Spinning Chicken";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox figure1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox block5;
        private System.Windows.Forms.PictureBox block6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox block7;
        private System.Windows.Forms.PictureBox block8;
        private System.Windows.Forms.Timer moveSpeed;
    }
}

