namespace MemoryGame
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
        ///  Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            btnJouer = new Button();
            btnOptions = new Button();
            btnQuitter = new Button();
            btnRejouer = new Button();
            lblAttempts = new Label();
            lblTime = new Label();
            SuspendLayout();
            // 
            // btnJouer
            // 
            btnJouer.Location = new Point(30, 24);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(94, 29);
            btnJouer.TabIndex = 0;
            btnJouer.Text = "Jouer";
            btnJouer.UseVisualStyleBackColor = true;
            btnJouer.Click += btnJouer_Click;
            // 
            // btnOptions
            // 
            btnOptions.Location = new Point(140, 24);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(94, 29);
            btnOptions.TabIndex = 1;
            btnOptions.Text = "Options";
            btnOptions.UseVisualStyleBackColor = true;
            btnOptions.Click += btnOptions_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(250, 24);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(94, 29);
            btnQuitter.TabIndex = 2;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnRejouer
            // 
            btnRejouer.Location = new Point(360, 24);
            btnRejouer.Name = "btnRejouer";
            btnRejouer.Size = new Size(94, 29);
            btnRejouer.TabIndex = 3;
            btnRejouer.Text = "Rejouer";
            btnRejouer.UseVisualStyleBackColor = true;
            btnRejouer.Click += btnRejouer_Click;
            // 
            // lblAttempts
            // 
            lblAttempts.Location = new Point(370, 20);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(150, 20);
            lblAttempts.Text = "Essais : 0";
            // 
            // lblTime
            // 
            lblTime.Location = new Point(370, 40);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(150, 20);
            lblTime.Text = "Temps : 00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(lblTime);
            Controls.Add(lblAttempts);
            Controls.Add(btnRejouer);
            Controls.Add(btnQuitter);
            Controls.Add(btnOptions);
            Controls.Add(btnJouer);
            Name = "Form1";
            Text = "Memory Cybersecurity";
            ResumeLayout(false);
        }

        #endregion

        private Button btnJouer;
        private Button btnOptions;
        private Button btnQuitter;
        private Button btnRejouer;
        private Label lblAttempts;
        private Label lblTime;
    }
}