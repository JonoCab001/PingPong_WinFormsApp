namespace PingPong_WinFormsApp
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.CPU = new System.Windows.Forms.PictureBox();
            this.PongBall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.CPUScoreLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PongBall)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.White;
            this.Player.Location = new System.Drawing.Point(12, 162);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(14, 82);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // CPU
            // 
            this.CPU.BackColor = System.Drawing.Color.White;
            this.CPU.Location = new System.Drawing.Point(774, 162);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(14, 82);
            this.CPU.TabIndex = 1;
            this.CPU.TabStop = false;
            // 
            // PongBall
            // 
            this.PongBall.BackColor = System.Drawing.Color.White;
            this.PongBall.Location = new System.Drawing.Point(390, 206);
            this.PongBall.Name = "PongBall";
            this.PongBall.Size = new System.Drawing.Size(15, 16);
            this.PongBall.TabIndex = 2;
            this.PongBall.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pong";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.ForeColor = System.Drawing.Color.White;
            this.playerScoreLabel.Location = new System.Drawing.Point(187, 9);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(40, 42);
            this.playerScoreLabel.TabIndex = 4;
            this.playerScoreLabel.Text = "0";
            this.playerScoreLabel.UseWaitCursor = true;
            // 
            // CPUScoreLabel
            // 
            this.CPUScoreLabel.AutoSize = true;
            this.CPUScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUScoreLabel.ForeColor = System.Drawing.Color.White;
            this.CPUScoreLabel.Location = new System.Drawing.Point(584, 9);
            this.CPUScoreLabel.Name = "CPUScoreLabel";
            this.CPUScoreLabel.Size = new System.Drawing.Size(40, 42);
            this.CPUScoreLabel.TabIndex = 5;
            this.CPUScoreLabel.Text = "0";
            this.CPUScoreLabel.UseWaitCursor = true;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CPUScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PongBall);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Ping Pong (Created in WinForms)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PongBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox CPU;
        private System.Windows.Forms.PictureBox PongBall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label CPUScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
    }
}

