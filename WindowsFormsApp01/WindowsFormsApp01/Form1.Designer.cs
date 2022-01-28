namespace WindowsFormsApp01
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.withdrawButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawButton.Location = new System.Drawing.Point(553, 25);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(220, 133);
            this.withdrawButton.TabIndex = 0;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            // 
            // transferButton
            // 
            this.transferButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferButton.Location = new System.Drawing.Point(558, 268);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(215, 133);
            this.transferButton.TabIndex = 1;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpButton.Location = new System.Drawing.Point(558, 514);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(215, 133);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(1150, 12);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 23);
            this.timeBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1262, 700);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.withdrawButton);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TextBox timeBox;
    }
}

