
namespace ModularizingInputValidation
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
            this.label1 = new System.Windows.Forms.Label();
            this.payBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bonusBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Gross Pay:";
            // 
            // payBox
            // 
            this.payBox.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBox.Location = new System.Drawing.Point(373, 39);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(290, 41);
            this.payBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bonus Amount:";
            // 
            // bonusBox
            // 
            this.bonusBox.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusBox.Location = new System.Drawing.Point(374, 125);
            this.bonusBox.Name = "bonusBox";
            this.bonusBox.Size = new System.Drawing.Size(290, 41);
            this.bonusBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Retirement\r\nContribution:";
            // 
            // contributionLabel
            // 
            this.contributionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributionLabel.Location = new System.Drawing.Point(374, 210);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(290, 69);
            this.contributionLabel.TabIndex = 5;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.calcBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(126, 327);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(245, 90);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calculate Contribution";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(417, 327);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(245, 90);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bonusBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pay and Bonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bonusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

