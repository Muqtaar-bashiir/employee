namespace employee
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
            this.btntotal = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.bbtndelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsub7 = new System.Windows.Forms.TextBox();
            this.txtsub8 = new System.Windows.Forms.TextBox();
            this.txtsub5 = new System.Windows.Forms.TextBox();
            this.txtsub6 = new System.Windows.Forms.TextBox();
            this.txtsub2 = new System.Windows.Forms.TextBox();
            this.txtsub3 = new System.Windows.Forms.TextBox();
            this.txtsub4 = new System.Windows.Forms.TextBox();
            this.txtsub1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntotal
            // 
            this.btntotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btntotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntotal.Location = new System.Drawing.Point(49, 402);
            this.btntotal.Margin = new System.Windows.Forms.Padding(4);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(136, 44);
            this.btntotal.TabIndex = 0;
            this.btntotal.Text = "CALCULATE";
            this.btntotal.UseVisualStyleBackColor = false;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclear.Location = new System.Drawing.Point(218, 402);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(134, 44);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // bbtndelete
            // 
            this.bbtndelete.BackColor = System.Drawing.Color.Red;
            this.bbtndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bbtndelete.Location = new System.Drawing.Point(397, 402);
            this.bbtndelete.Margin = new System.Windows.Forms.Padding(4);
            this.bbtndelete.Name = "bbtndelete";
            this.bbtndelete.Size = new System.Drawing.Size(114, 44);
            this.bbtndelete.TabIndex = 2;
            this.bbtndelete.Text = "CANCEL";
            this.bbtndelete.UseVisualStyleBackColor = false;
            this.bbtndelete.Click += new System.EventHandler(this.bbtndelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtsub7);
            this.panel1.Controls.Add(this.txtsub8);
            this.panel1.Controls.Add(this.txtsub5);
            this.panel1.Controls.Add(this.txtsub6);
            this.panel1.Controls.Add(this.txtsub2);
            this.panel1.Controls.Add(this.txtsub3);
            this.panel1.Controls.Add(this.txtsub4);
            this.panel1.Controls.Add(this.txtsub1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bbtndelete);
            this.panel1.Controls.Add(this.btntotal);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 478);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(-42, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(776, 37);
            this.label10.TabIndex = 21;
            this.label10.Text = "               CHECK FROM STUDENT MARKS";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(214, 339);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(15, 24);
            this.lbltotal.TabIndex = 20;
            this.lbltotal.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "total marks is :";
            // 
            // txtsub7
            // 
            this.txtsub7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsub7.Location = new System.Drawing.Point(177, 253);
            this.txtsub7.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub7.Name = "txtsub7";
            this.txtsub7.Size = new System.Drawing.Size(306, 22);
            this.txtsub7.TabIndex = 18;
            // 
            // txtsub8
            // 
            this.txtsub8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsub8.Location = new System.Drawing.Point(177, 282);
            this.txtsub8.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub8.Name = "txtsub8";
            this.txtsub8.Size = new System.Drawing.Size(306, 22);
            this.txtsub8.TabIndex = 17;
            // 
            // txtsub5
            // 
            this.txtsub5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsub5.Location = new System.Drawing.Point(177, 194);
            this.txtsub5.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub5.Name = "txtsub5";
            this.txtsub5.Size = new System.Drawing.Size(306, 22);
            this.txtsub5.TabIndex = 16;
            // 
            // txtsub6
            // 
            this.txtsub6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsub6.Location = new System.Drawing.Point(177, 223);
            this.txtsub6.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub6.Name = "txtsub6";
            this.txtsub6.Size = new System.Drawing.Size(306, 22);
            this.txtsub6.TabIndex = 15;
            // 
            // txtsub2
            // 
            this.txtsub2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsub2.Location = new System.Drawing.Point(177, 106);
            this.txtsub2.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub2.Name = "txtsub2";
            this.txtsub2.Size = new System.Drawing.Size(306, 22);
            this.txtsub2.TabIndex = 14;
            // 
            // txtsub3
            // 
            this.txtsub3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsub3.Location = new System.Drawing.Point(177, 136);
            this.txtsub3.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub3.Name = "txtsub3";
            this.txtsub3.Size = new System.Drawing.Size(306, 22);
            this.txtsub3.TabIndex = 13;
            // 
            // txtsub4
            // 
            this.txtsub4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsub4.Location = new System.Drawing.Point(177, 166);
            this.txtsub4.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub4.Name = "txtsub4";
            this.txtsub4.Size = new System.Drawing.Size(306, 22);
            this.txtsub4.TabIndex = 12;
            // 
            // txtsub1
            // 
            this.txtsub1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsub1.Location = new System.Drawing.Point(177, 76);
            this.txtsub1.Margin = new System.Windows.Forms.Padding(4);
            this.txtsub1.Name = "txtsub1";
            this.txtsub1.Size = new System.Drawing.Size(306, 22);
            this.txtsub1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "sub8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "sub3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "sub4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "sub5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "sub6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "sub7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "sub2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "sub1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button bbtndelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsub7;
        private System.Windows.Forms.TextBox txtsub8;
        private System.Windows.Forms.TextBox txtsub5;
        private System.Windows.Forms.TextBox txtsub6;
        private System.Windows.Forms.TextBox txtsub2;
        private System.Windows.Forms.TextBox txtsub3;
        private System.Windows.Forms.TextBox txtsub4;
        private System.Windows.Forms.TextBox txtsub1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}

