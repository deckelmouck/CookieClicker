namespace CookieClicker
{
    partial class CookieClicker
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
            this.components = new System.ComponentModel.Container();
            this.CookieClickButton = new System.Windows.Forms.Button();
            this.CookiePoints = new System.Windows.Forms.Label();
            this.BoxMoreCookies = new System.Windows.Forms.GroupBox();
            this.Cookies100 = new System.Windows.Forms.Button();
            this.Cookies50 = new System.Windows.Forms.Button();
            this.Cookies25 = new System.Windows.Forms.Button();
            this.Cookies10 = new System.Windows.Forms.Button();
            this.CookieTimer = new System.Windows.Forms.Timer(this.components);
            this.BoxMoreCookies.SuspendLayout();
            this.SuspendLayout();
            // 
            // CookieClickButton
            // 
            this.CookieClickButton.Location = new System.Drawing.Point(287, 9);
            this.CookieClickButton.Name = "CookieClickButton";
            this.CookieClickButton.Size = new System.Drawing.Size(133, 56);
            this.CookieClickButton.TabIndex = 0;
            this.CookieClickButton.Text = "Click";
            this.CookieClickButton.UseVisualStyleBackColor = true;
            this.CookieClickButton.Click += new System.EventHandler(this.CookieClickButton_Click);
            // 
            // CookiePoints
            // 
            this.CookiePoints.AutoSize = true;
            this.CookiePoints.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CookiePoints.Location = new System.Drawing.Point(12, 9);
            this.CookiePoints.Name = "CookiePoints";
            this.CookiePoints.Size = new System.Drawing.Size(102, 30);
            this.CookiePoints.TabIndex = 1;
            this.CookiePoints.Text = "0 Cookies";
            // 
            // BoxMoreCookies
            // 
            this.BoxMoreCookies.Controls.Add(this.Cookies100);
            this.BoxMoreCookies.Controls.Add(this.Cookies50);
            this.BoxMoreCookies.Controls.Add(this.Cookies25);
            this.BoxMoreCookies.Controls.Add(this.Cookies10);
            this.BoxMoreCookies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BoxMoreCookies.Location = new System.Drawing.Point(0, 71);
            this.BoxMoreCookies.Name = "BoxMoreCookies";
            this.BoxMoreCookies.Size = new System.Drawing.Size(440, 170);
            this.BoxMoreCookies.TabIndex = 2;
            this.BoxMoreCookies.TabStop = false;
            this.BoxMoreCookies.Text = "More Cookies";
            // 
            // Cookies100
            // 
            this.Cookies100.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cookies100.Location = new System.Drawing.Point(3, 130);
            this.Cookies100.Name = "Cookies100";
            this.Cookies100.Size = new System.Drawing.Size(434, 37);
            this.Cookies100.TabIndex = 3;
            this.Cookies100.Text = "100 Cookies";
            this.Cookies100.UseVisualStyleBackColor = true;
            this.Cookies100.Click += new System.EventHandler(this.Cookies100_Click);
            // 
            // Cookies50
            // 
            this.Cookies50.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cookies50.Location = new System.Drawing.Point(3, 93);
            this.Cookies50.Name = "Cookies50";
            this.Cookies50.Size = new System.Drawing.Size(434, 37);
            this.Cookies50.TabIndex = 2;
            this.Cookies50.Text = "50 Cookies";
            this.Cookies50.UseVisualStyleBackColor = true;
            this.Cookies50.Click += new System.EventHandler(this.Cookies50_Click);
            // 
            // Cookies25
            // 
            this.Cookies25.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cookies25.Location = new System.Drawing.Point(3, 56);
            this.Cookies25.Name = "Cookies25";
            this.Cookies25.Size = new System.Drawing.Size(434, 37);
            this.Cookies25.TabIndex = 1;
            this.Cookies25.Text = "25 Cookies";
            this.Cookies25.UseVisualStyleBackColor = true;
            this.Cookies25.Click += new System.EventHandler(this.Cookies25_Click);
            // 
            // Cookies10
            // 
            this.Cookies10.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cookies10.Location = new System.Drawing.Point(3, 19);
            this.Cookies10.Name = "Cookies10";
            this.Cookies10.Size = new System.Drawing.Size(434, 37);
            this.Cookies10.TabIndex = 0;
            this.Cookies10.Text = "10 Cookies";
            this.Cookies10.UseVisualStyleBackColor = true;
            this.Cookies10.Click += new System.EventHandler(this.Cookies10_Click);
            // 
            // CookieTimer
            // 
            this.CookieTimer.Enabled = true;
            this.CookieTimer.Tick += new System.EventHandler(this.CookieTimer_Tick);
            // 
            // CookieClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 241);
            this.Controls.Add(this.BoxMoreCookies);
            this.Controls.Add(this.CookiePoints);
            this.Controls.Add(this.CookieClickButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CookieClicker";
            this.Text = "CookieClicker";
            this.BoxMoreCookies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CookieClickButton;
        private System.Windows.Forms.Label CookiePoints;
        private System.Windows.Forms.GroupBox BoxMoreCookies;
        private System.Windows.Forms.Button Cookies100;
        private System.Windows.Forms.Button Cookies50;
        private System.Windows.Forms.Button Cookies25;
        private System.Windows.Forms.Button Cookies10;
        private System.Windows.Forms.Timer CookieTimer;
    }
}

