namespace ProjekatEsdnevnik
{
    partial class Login
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
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.Lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_pass = new System.Windows.Forms.Label();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_name
            // 
            this.Txt_name.Location = new System.Drawing.Point(239, 107);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(337, 22);
            this.Txt_name.TabIndex = 0;
            // 
            // Txt_pass
            // 
            this.Txt_pass.Location = new System.Drawing.Point(239, 152);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.Size = new System.Drawing.Size(337, 22);
            this.Txt_pass.TabIndex = 0;
            // 
            // Lbl_name
            // 
            this.Lbl_name.AutoSize = true;
            this.Lbl_name.Location = new System.Drawing.Point(109, 107);
            this.Lbl_name.Name = "Lbl_name";
            this.Lbl_name.Size = new System.Drawing.Size(45, 16);
            this.Lbl_name.TabIndex = 1;
            this.Lbl_name.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dobrodosli! Da biste nastavili unesite sledece";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl_pass
            // 
            this.Lbl_pass.AutoSize = true;
            this.Lbl_pass.Location = new System.Drawing.Point(109, 152);
            this.Lbl_pass.Name = "Lbl_pass";
            this.Lbl_pass.Size = new System.Drawing.Size(67, 16);
            this.Lbl_pass.TabIndex = 1;
            this.Lbl_pass.Text = "Password";
            // 
            // Btn_ok
            // 
            this.Btn_ok.Location = new System.Drawing.Point(371, 239);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(75, 30);
            this.Btn_ok.TabIndex = 3;
            this.Btn_ok.Text = "Login";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_pass);
            this.Controls.Add(this.Lbl_name);
            this.Controls.Add(this.Txt_pass);
            this.Controls.Add(this.Txt_name);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.Label Lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_pass;
        private System.Windows.Forms.Button Btn_ok;
    }
}