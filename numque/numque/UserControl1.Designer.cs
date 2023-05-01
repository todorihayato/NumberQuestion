namespace numque
{
    partial class UserControl1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LButton = new System.Windows.Forms.Button();
            this.sitelabel = new System.Windows.Forms.Label();
            this.rule = new System.Windows.Forms.Button();
            this.RBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(134, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "1人プレイ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(563, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "2人プレイ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Question (数字当て   ヌメロン)";
            // 
            // LButton
            // 
            this.LButton.AutoSize = true;
            this.LButton.Location = new System.Drawing.Point(702, 201);
            this.LButton.Name = "LButton";
            this.LButton.Size = new System.Drawing.Size(75, 28);
            this.LButton.TabIndex = 3;
            this.LButton.Text = "link";
            this.LButton.UseVisualStyleBackColor = true;
            this.LButton.Click += new System.EventHandler(this.LButton_Click);
            // 
            // sitelabel
            // 
            this.sitelabel.AutoSize = true;
            this.sitelabel.Location = new System.Drawing.Point(661, 143);
            this.sitelabel.Name = "sitelabel";
            this.sitelabel.Size = new System.Drawing.Size(116, 18);
            this.sitelabel.TabIndex = 4;
            this.sitelabel.Text = "Numer0n 情報";
            // 
            // rule
            // 
            this.rule.AutoSize = true;
            this.rule.Location = new System.Drawing.Point(21, 133);
            this.rule.Name = "rule";
            this.rule.Size = new System.Drawing.Size(75, 28);
            this.rule.TabIndex = 6;
            this.rule.Text = "ルール";
            this.rule.UseVisualStyleBackColor = true;
            this.rule.Click += new System.EventHandler(this.rule_Click);
            // 
            // RBox
            // 
            this.RBox.AcceptsReturn = true;
            this.RBox.Location = new System.Drawing.Point(99, 164);
            this.RBox.Multiline = true;
            this.RBox.Name = "RBox";
            this.RBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RBox.Size = new System.Drawing.Size(503, 150);
            this.RBox.TabIndex = 7;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RBox);
            this.Controls.Add(this.rule);
            this.Controls.Add(this.sitelabel);
            this.Controls.Add(this.LButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Usercontrol1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LButton;
        private System.Windows.Forms.Label sitelabel;
        private System.Windows.Forms.Button rule;
        private System.Windows.Forms.TextBox RBox;
    }
}