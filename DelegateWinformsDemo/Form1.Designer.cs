
namespace DelegateWinformsDemo
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
            this.lstPerson = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPerson
            // 
            this.lstPerson.FormattingEnabled = true;
            this.lstPerson.ItemHeight = 16;
            this.lstPerson.Location = new System.Drawing.Point(379, 55);
            this.lstPerson.Name = "lstPerson";
            this.lstPerson.Size = new System.Drawing.Size(409, 260);
            this.lstPerson.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(451, 344);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(271, 50);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOption4);
            this.groupBox1.Controls.Add(this.rbOption3);
            this.groupBox1.Controls.Add(this.rbOption2);
            this.groupBox1.Controls.Add(this.rbOption1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 260);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possible options";
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(6, 21);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(93, 26);
            this.rbOption1.TabIndex = 3;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "Default";
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(6, 59);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(121, 26);
            this.rbOption2.TabIndex = 4;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "Last Name";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(6, 103);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(121, 26);
            this.rbOption3.TabIndex = 5;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "First Name";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(6, 145);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(115, 26);
            this.rbOption4.TabIndex = 6;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "Full Name";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPerson;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption1;
    }
}

