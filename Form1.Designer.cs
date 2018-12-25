namespace emguproj2
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
            this.button1 = new System.Windows.Forms.Button();
            this.circleImageBox = new System.Windows.Forms.PictureBox();
            this.lineImageBox = new System.Windows.Forms.PictureBox();
            this.triangleRectangleImageBox = new System.Windows.Forms.PictureBox();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.circleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleRectangleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "on";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // circleImageBox
            // 
            this.circleImageBox.Location = new System.Drawing.Point(7, 384);
            this.circleImageBox.Name = "circleImageBox";
            this.circleImageBox.Size = new System.Drawing.Size(432, 328);
            this.circleImageBox.TabIndex = 1;
            this.circleImageBox.TabStop = false;
            // 
            // lineImageBox
            // 
            this.lineImageBox.Location = new System.Drawing.Point(456, 384);
            this.lineImageBox.Name = "lineImageBox";
            this.lineImageBox.Size = new System.Drawing.Size(413, 328);
            this.lineImageBox.TabIndex = 2;
            this.lineImageBox.TabStop = false;
            // 
            // triangleRectangleImageBox
            // 
            this.triangleRectangleImageBox.Location = new System.Drawing.Point(456, 65);
            this.triangleRectangleImageBox.Name = "triangleRectangleImageBox";
            this.triangleRectangleImageBox.Size = new System.Drawing.Size(413, 313);
            this.triangleRectangleImageBox.TabIndex = 4;
            this.triangleRectangleImageBox.TabStop = false;
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(7, 65);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(432, 313);
            this.originalImageBox.TabIndex = 3;
            this.originalImageBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(23, 12);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(585, 20);
            this.fileNameTextBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.triangleRectangleImageBox);
            this.Controls.Add(this.originalImageBox);
            this.Controls.Add(this.lineImageBox);
            this.Controls.Add(this.circleImageBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.circleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleRectangleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox circleImageBox;
        private System.Windows.Forms.PictureBox lineImageBox;
        private System.Windows.Forms.PictureBox triangleRectangleImageBox;
        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button button2;
    }
}

