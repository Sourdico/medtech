namespace Medtech
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
            this.log_btn = new System.Windows.Forms.Button();
            this.sign_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Usr_name = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_btn
            // 
            this.log_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.Location = new System.Drawing.Point(373, 522);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(173, 71);
            this.log_btn.TabIndex = 0;
            this.log_btn.Text = "Login";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // sign_btn
            // 
            this.sign_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_btn.Location = new System.Drawing.Point(743, 522);
            this.sign_btn.Name = "sign_btn";
            this.sign_btn.Size = new System.Drawing.Size(150, 71);
            this.sign_btn.TabIndex = 1;
            this.sign_btn.Text = "SignUp";
            this.sign_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 89);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEDTECH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Usr_name
            // 
            this.textBox_Usr_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Usr_name.Location = new System.Drawing.Point(581, 220);
            this.textBox_Usr_name.Name = "textBox_Usr_name";
            this.textBox_Usr_name.Size = new System.Drawing.Size(422, 35);
            this.textBox_Usr_name.TabIndex = 3;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(581, 288);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(422, 35);
            this.textBox_pass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 866);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_Usr_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign_btn);
            this.Controls.Add(this.log_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Button sign_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Usr_name;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

