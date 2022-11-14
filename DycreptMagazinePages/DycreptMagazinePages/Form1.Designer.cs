namespace DycreptMagazinePages
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
            this.SearchPathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SavePathTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.saveLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SPNumberTextBox = new System.Windows.Forms.TextBox();
            this.EPNumberTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchPathTextBox
            // 
            this.SearchPathTextBox.Location = new System.Drawing.Point(44, 63);
            this.SearchPathTextBox.Multiline = true;
            this.SearchPathTextBox.Name = "SearchPathTextBox";
            this.SearchPathTextBox.Size = new System.Drawing.Size(696, 30);
            this.SearchPathTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reorder - PocketShounen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SavePathTextBox
            // 
            this.SavePathTextBox.Location = new System.Drawing.Point(44, 163);
            this.SavePathTextBox.Multiline = true;
            this.SavePathTextBox.Name = "SavePathTextBox";
            this.SavePathTextBox.Size = new System.Drawing.Size(695, 30);
            this.SavePathTextBox.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.Location = new System.Drawing.Point(44, 22);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(355, 26);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search for images in this Folder Path";
            // 
            // saveLabel
            // 
            this.saveLabel.Location = new System.Drawing.Point(44, 131);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(286, 29);
            this.saveLabel.TabIndex = 4;
            this.saveLabel.Text = "Save reordered images in this folder path";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Made By Laith Alqaisi\r\nMay 2021\r\n\r\n\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Rename and convert to png";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SPNumberTextBox
            // 
            this.SPNumberTextBox.Location = new System.Drawing.Point(44, 361);
            this.SPNumberTextBox.Name = "SPNumberTextBox";
            this.SPNumberTextBox.Size = new System.Drawing.Size(54, 20);
            this.SPNumberTextBox.TabIndex = 7;
            // 
            // EPNumberTextBox
            // 
            this.EPNumberTextBox.Location = new System.Drawing.Point(126, 361);
            this.EPNumberTextBox.Name = "EPNumberTextBox";
            this.EPNumberTextBox.Size = new System.Drawing.Size(54, 20);
            this.EPNumberTextBox.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "GenerateDoc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "StartingPage\r\nNumber";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "EndingPage\r\nNumber";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EPNumberTextBox);
            this.Controls.Add(this.SPNumberTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.SavePathTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchPathTextBox);
            this.Name = "Form1";
            this.Text = "Itsafineday Soft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox EPNumberTextBox;

        private System.Windows.Forms.TextBox SavePathTextBox;
        private System.Windows.Forms.TextBox SearchPathTextBox;
        private System.Windows.Forms.TextBox SPNumberTextBox;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.Label searchLabel;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}