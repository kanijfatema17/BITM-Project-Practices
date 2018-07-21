namespace CalculetorsInfo
{
    partial class CalculaterUi
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
            this.firstLabel1 = new System.Windows.Forms.Label();
            this.scendLabel2 = new System.Windows.Forms.Label();
            this.firstTextBox1 = new System.Windows.Forms.TextBox();
            this.secondTextBox2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultInLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstLabel1
            // 
            this.firstLabel1.AutoSize = true;
            this.firstLabel1.Location = new System.Drawing.Point(29, 23);
            this.firstLabel1.Name = "firstLabel1";
            this.firstLabel1.Size = new System.Drawing.Size(66, 13);
            this.firstLabel1.TabIndex = 0;
            this.firstLabel1.Text = "First Number";
            // 
            // scendLabel2
            // 
            this.scendLabel2.AutoSize = true;
            this.scendLabel2.Location = new System.Drawing.Point(29, 62);
            this.scendLabel2.Name = "scendLabel2";
            this.scendLabel2.Size = new System.Drawing.Size(84, 13);
            this.scendLabel2.TabIndex = 1;
            this.scendLabel2.Text = "Second Number";
            // 
            // firstTextBox1
            // 
            this.firstTextBox1.Location = new System.Drawing.Point(129, 23);
            this.firstTextBox1.Name = "firstTextBox1";
            this.firstTextBox1.Size = new System.Drawing.Size(201, 20);
            this.firstTextBox1.TabIndex = 2;
            // 
            // secondTextBox2
            // 
            this.secondTextBox2.Location = new System.Drawing.Point(129, 59);
            this.secondTextBox2.Name = "secondTextBox2";
            this.secondTextBox2.Size = new System.Drawing.Size(201, 20);
            this.secondTextBox2.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(220, 117);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(58, 174);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Result";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(112, 174);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Visible = false;
            // 
            // resultInLabel
            // 
            this.resultInLabel.AutoSize = true;
            this.resultInLabel.Location = new System.Drawing.Point(102, 173);
            this.resultInLabel.Name = "resultInLabel";
            this.resultInLabel.Size = new System.Drawing.Size(0, 13);
            this.resultInLabel.TabIndex = 7;
            // 
            // CalculaterUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 218);
            this.Controls.Add(this.resultInLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondTextBox2);
            this.Controls.Add(this.firstTextBox1);
            this.Controls.Add(this.scendLabel2);
            this.Controls.Add(this.firstLabel1);
            this.Name = "CalculaterUi";
            this.Text = "Calculator Info";
            this.Load += new System.EventHandler(this.CalculaterUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLabel1;
        private System.Windows.Forms.Label scendLabel2;
        private System.Windows.Forms.TextBox firstTextBox1;
        private System.Windows.Forms.TextBox secondTextBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultInLabel;
    }
}

