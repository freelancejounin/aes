namespace AES
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblKeyExpand = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblR3 = new System.Windows.Forms.Label();
            this.lblR4 = new System.Windows.Forms.Label();
            this.lblR5 = new System.Windows.Forms.Label();
            this.lblR6 = new System.Windows.Forms.Label();
            this.lblR7 = new System.Windows.Forms.Label();
            this.bCipher = new System.Windows.Forms.Button();
            this.bDecipher = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.lblKeyTitle = new System.Windows.Forms.Label();
            this.lblR8 = new System.Windows.Forms.Label();
            this.lblR9 = new System.Windows.Forms.Label();
            this.lblR10 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(49, 12);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(280, 20);
            this.tbInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 85);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(146, 85);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Key";
            // 
            // lblKeyExpand
            // 
            this.lblKeyExpand.AutoSize = true;
            this.lblKeyExpand.Location = new System.Drawing.Point(12, 225);
            this.lblKeyExpand.Name = "lblKeyExpand";
            this.lblKeyExpand.Size = new System.Drawing.Size(77, 13);
            this.lblKeyExpand.TabIndex = 3;
            this.lblKeyExpand.Text = "Key Expansion";
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(217, 177);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(45, 13);
            this.lblR1.TabIndex = 4;
            this.lblR1.Text = "Round1";
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(351, 177);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(45, 13);
            this.lblR2.TabIndex = 5;
            this.lblR2.Text = "Round2";
            // 
            // lblR3
            // 
            this.lblR3.AutoSize = true;
            this.lblR3.Location = new System.Drawing.Point(488, 177);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(45, 13);
            this.lblR3.TabIndex = 6;
            this.lblR3.Text = "Round3";
            // 
            // lblR4
            // 
            this.lblR4.AutoSize = true;
            this.lblR4.Location = new System.Drawing.Point(630, 177);
            this.lblR4.Name = "lblR4";
            this.lblR4.Size = new System.Drawing.Size(45, 13);
            this.lblR4.TabIndex = 7;
            this.lblR4.Text = "Round4";
            // 
            // lblR5
            // 
            this.lblR5.AutoSize = true;
            this.lblR5.Location = new System.Drawing.Point(217, 307);
            this.lblR5.Name = "lblR5";
            this.lblR5.Size = new System.Drawing.Size(45, 13);
            this.lblR5.TabIndex = 8;
            this.lblR5.Text = "Round5";
            // 
            // lblR6
            // 
            this.lblR6.AutoSize = true;
            this.lblR6.Location = new System.Drawing.Point(351, 307);
            this.lblR6.Name = "lblR6";
            this.lblR6.Size = new System.Drawing.Size(45, 13);
            this.lblR6.TabIndex = 9;
            this.lblR6.Text = "Round6";
            // 
            // lblR7
            // 
            this.lblR7.AutoSize = true;
            this.lblR7.Location = new System.Drawing.Point(488, 307);
            this.lblR7.Name = "lblR7";
            this.lblR7.Size = new System.Drawing.Size(45, 13);
            this.lblR7.TabIndex = 10;
            this.lblR7.Text = "Round7";
            // 
            // bCipher
            // 
            this.bCipher.Location = new System.Drawing.Point(335, 40);
            this.bCipher.Name = "bCipher";
            this.bCipher.Size = new System.Drawing.Size(97, 21);
            this.bCipher.TabIndex = 12;
            this.bCipher.Text = "Cipher";
            this.bCipher.UseVisualStyleBackColor = true;
            // 
            // bDecipher
            // 
            this.bDecipher.Location = new System.Drawing.Point(438, 40);
            this.bDecipher.Name = "bDecipher";
            this.bDecipher.Size = new System.Drawing.Size(99, 21);
            this.bDecipher.TabIndex = 13;
            this.bDecipher.Text = "Decipher";
            this.bDecipher.UseVisualStyleBackColor = true;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(50, 43);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(278, 20);
            this.tbKey.TabIndex = 14;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Location = new System.Drawing.Point(12, 12);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(31, 13);
            this.lblInputTitle.TabIndex = 15;
            this.lblInputTitle.Text = "Input";
            // 
            // lblKeyTitle
            // 
            this.lblKeyTitle.AutoSize = true;
            this.lblKeyTitle.Location = new System.Drawing.Point(12, 44);
            this.lblKeyTitle.Name = "lblKeyTitle";
            this.lblKeyTitle.Size = new System.Drawing.Size(25, 13);
            this.lblKeyTitle.TabIndex = 16;
            this.lblKeyTitle.Text = "Key";
            // 
            // lblR8
            // 
            this.lblR8.AutoSize = true;
            this.lblR8.Location = new System.Drawing.Point(630, 307);
            this.lblR8.Name = "lblR8";
            this.lblR8.Size = new System.Drawing.Size(45, 13);
            this.lblR8.TabIndex = 17;
            this.lblR8.Text = "Round8";
            // 
            // lblR9
            // 
            this.lblR9.AutoSize = true;
            this.lblR9.Location = new System.Drawing.Point(217, 431);
            this.lblR9.Name = "lblR9";
            this.lblR9.Size = new System.Drawing.Size(45, 13);
            this.lblR9.TabIndex = 18;
            this.lblR9.Text = "Round9";
            // 
            // lblR10
            // 
            this.lblR10.AutoSize = true;
            this.lblR10.Location = new System.Drawing.Point(351, 431);
            this.lblR10.Name = "lblR10";
            this.lblR10.Size = new System.Drawing.Size(51, 13);
            this.lblR10.TabIndex = 19;
            this.lblR10.Text = "Round10";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(488, 431);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 20;
            this.lblOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 876);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblR10);
            this.Controls.Add(this.lblR9);
            this.Controls.Add(this.lblR8);
            this.Controls.Add(this.lblKeyTitle);
            this.Controls.Add(this.lblInputTitle);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.bDecipher);
            this.Controls.Add(this.bCipher);
            this.Controls.Add(this.lblR7);
            this.Controls.Add(this.lblR6);
            this.Controls.Add(this.lblR5);
            this.Controls.Add(this.lblR4);
            this.Controls.Add(this.lblR3);
            this.Controls.Add(this.lblR2);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.lblKeyExpand);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblKeyExpand;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Label lblR4;
        private System.Windows.Forms.Label lblR5;
        private System.Windows.Forms.Label lblR6;
        private System.Windows.Forms.Label lblR7;
        private System.Windows.Forms.Button bCipher;
        private System.Windows.Forms.Button bDecipher;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label lblKeyTitle;
        private System.Windows.Forms.Label lblR8;
        private System.Windows.Forms.Label lblR9;
        private System.Windows.Forms.Label lblR10;
        private System.Windows.Forms.Label lblOutput;
    }
}

