namespace Lab3_v2
{
    partial class Comparison_
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_user1 = new System.Windows.Forms.ComboBox();
            this.cb_user2 = new System.Windows.Forms.ComboBox();
            this.cb_programm2 = new System.Windows.Forms.ComboBox();
            this.cb_programm1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_equal1 = new System.Windows.Forms.Button();
            this.b_equal2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User 2";
            // 
            // cb_user1
            // 
            this.cb_user1.FormattingEnabled = true;
            this.cb_user1.Location = new System.Drawing.Point(15, 26);
            this.cb_user1.Name = "cb_user1";
            this.cb_user1.Size = new System.Drawing.Size(121, 21);
            this.cb_user1.TabIndex = 2;
            // 
            // cb_user2
            // 
            this.cb_user2.FormattingEnabled = true;
            this.cb_user2.Location = new System.Drawing.Point(161, 26);
            this.cb_user2.Name = "cb_user2";
            this.cb_user2.Size = new System.Drawing.Size(121, 21);
            this.cb_user2.TabIndex = 3;
            // 
            // cb_programm2
            // 
            this.cb_programm2.FormattingEnabled = true;
            this.cb_programm2.Location = new System.Drawing.Point(161, 78);
            this.cb_programm2.Name = "cb_programm2";
            this.cb_programm2.Size = new System.Drawing.Size(121, 21);
            this.cb_programm2.TabIndex = 7;
            // 
            // cb_programm1
            // 
            this.cb_programm1.FormattingEnabled = true;
            this.cb_programm1.Location = new System.Drawing.Point(15, 78);
            this.cb_programm1.Name = "cb_programm1";
            this.cb_programm1.Size = new System.Drawing.Size(121, 21);
            this.cb_programm1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Programm 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Programm 1";
            // 
            // b_equal1
            // 
            this.b_equal1.Location = new System.Drawing.Point(297, 26);
            this.b_equal1.Name = "b_equal1";
            this.b_equal1.Size = new System.Drawing.Size(75, 23);
            this.b_equal1.TabIndex = 8;
            this.b_equal1.Text = "Equal";
            this.b_equal1.UseVisualStyleBackColor = true;
            this.b_equal1.Click += new System.EventHandler(this.Equal1_Click);
            // 
            // b_equal2
            // 
            this.b_equal2.Location = new System.Drawing.Point(297, 78);
            this.b_equal2.Name = "b_equal2";
            this.b_equal2.Size = new System.Drawing.Size(75, 23);
            this.b_equal2.TabIndex = 9;
            this.b_equal2.Text = "Equal";
            this.b_equal2.UseVisualStyleBackColor = true;
            this.b_equal2.Click += new System.EventHandler(this.Equal2_Click);
            // 
            // Comparison_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 113);
            this.Controls.Add(this.b_equal2);
            this.Controls.Add(this.b_equal1);
            this.Controls.Add(this.cb_programm2);
            this.Controls.Add(this.cb_programm1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_user2);
            this.Controls.Add(this.cb_user1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Comparison_";
            this.Text = "Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_user1;
        private System.Windows.Forms.ComboBox cb_user2;
        private System.Windows.Forms.ComboBox cb_programm2;
        private System.Windows.Forms.ComboBox cb_programm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_equal1;
        private System.Windows.Forms.Button b_equal2;
    }
}