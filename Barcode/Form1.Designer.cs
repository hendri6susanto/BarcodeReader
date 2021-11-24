
namespace Barcode
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
            this.generateBtn = new System.Windows.Forms.Button();
            this.barTB = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.decodeTB = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(457, 30);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // barTB
            // 
            this.barTB.Location = new System.Drawing.Point(29, 30);
            this.barTB.Name = "barTB";
            this.barTB.Size = new System.Drawing.Size(397, 20);
            this.barTB.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(29, 122);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(749, 316);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(571, 27);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // decodeBtn
            // 
            this.decodeBtn.Location = new System.Drawing.Point(457, 74);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(75, 23);
            this.decodeBtn.TabIndex = 4;
            this.decodeBtn.Text = "Decode";
            this.decodeBtn.UseVisualStyleBackColor = true;
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            // 
            // decodeTB
            // 
            this.decodeTB.Location = new System.Drawing.Point(29, 76);
            this.decodeTB.Name = "decodeTB";
            this.decodeTB.Size = new System.Drawing.Size(397, 20);
            this.decodeTB.TabIndex = 5;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(583, 76);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.decodeTB);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.barTB);
            this.Controls.Add(this.generateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox barTB;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button decodeBtn;
        private System.Windows.Forms.TextBox decodeTB;
        private System.Windows.Forms.Button clearBtn;
    }
}

