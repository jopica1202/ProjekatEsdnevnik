namespace ProjekatEsdnevnik
{
    partial class Upisnica
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
            this.DGridView = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.Label();
            this.TxtGodina = new System.Windows.Forms.Label();
            this.TxtOdeljenje = new System.Windows.Forms.Label();
            this.TxtUcenik = new System.Windows.Forms.Label();
            this.TboxId = new System.Windows.Forms.TextBox();
            this.CboxGod = new System.Windows.Forms.ComboBox();
            this.CboxOdeljenje = new System.Windows.Forms.ComboBox();
            this.CboxUcenik = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView
            // 
            this.DGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView.Location = new System.Drawing.Point(52, 194);
            this.DGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGridView.Name = "DGridView";
            this.DGridView.RowHeadersWidth = 51;
            this.DGridView.Size = new System.Drawing.Size(959, 324);
            this.DGridView.TabIndex = 0;
            // 
            // TxtId
            // 
            this.TxtId.AutoSize = true;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(47, 11);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(36, 29);
            this.TxtId.TabIndex = 1;
            this.TxtId.Text = "ID";
            // 
            // TxtGodina
            // 
            this.TxtGodina.AutoSize = true;
            this.TxtGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGodina.Location = new System.Drawing.Point(287, 11);
            this.TxtGodina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtGodina.Name = "TxtGodina";
            this.TxtGodina.Size = new System.Drawing.Size(91, 29);
            this.TxtGodina.TabIndex = 2;
            this.TxtGodina.Text = "Godina";
            // 
            // TxtOdeljenje
            // 
            this.TxtOdeljenje.AutoSize = true;
            this.TxtOdeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOdeljenje.Location = new System.Drawing.Point(564, 11);
            this.TxtOdeljenje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtOdeljenje.Name = "TxtOdeljenje";
            this.TxtOdeljenje.Size = new System.Drawing.Size(119, 29);
            this.TxtOdeljenje.TabIndex = 3;
            this.TxtOdeljenje.Text = "Odeljenje";
            // 
            // TxtUcenik
            // 
            this.TxtUcenik.AutoSize = true;
            this.TxtUcenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUcenik.Location = new System.Drawing.Point(841, 11);
            this.TxtUcenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtUcenik.Name = "TxtUcenik";
            this.TxtUcenik.Size = new System.Drawing.Size(87, 29);
            this.TxtUcenik.TabIndex = 4;
            this.TxtUcenik.Text = "Ucenik";
            // 
            // TboxId
            // 
            this.TboxId.Location = new System.Drawing.Point(52, 81);
            this.TboxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TboxId.Name = "TboxId";
            this.TboxId.ReadOnly = true;
            this.TboxId.Size = new System.Drawing.Size(121, 22);
            this.TboxId.TabIndex = 5;
            // 
            // CboxGod
            // 
            this.CboxGod.FormattingEnabled = true;
            this.CboxGod.Location = new System.Drawing.Point(292, 81);
            this.CboxGod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboxGod.Name = "CboxGod";
            this.CboxGod.Size = new System.Drawing.Size(159, 24);
            this.CboxGod.TabIndex = 6;
            // 
            // CboxOdeljenje
            // 
            this.CboxOdeljenje.FormattingEnabled = true;
            this.CboxOdeljenje.Location = new System.Drawing.Point(569, 80);
            this.CboxOdeljenje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboxOdeljenje.Name = "CboxOdeljenje";
            this.CboxOdeljenje.Size = new System.Drawing.Size(159, 24);
            this.CboxOdeljenje.TabIndex = 7;
            // 
            // CboxUcenik
            // 
            this.CboxUcenik.FormattingEnabled = true;
            this.CboxUcenik.Location = new System.Drawing.Point(847, 81);
            this.CboxUcenik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboxUcenik.Name = "CboxUcenik";
            this.CboxUcenik.Size = new System.Drawing.Size(163, 24);
            this.CboxUcenik.TabIndex = 8;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDelete.Location = new System.Drawing.Point(569, 133);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(133, 43);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Obrisi";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUpdate.Location = new System.Drawing.Point(723, 133);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(133, 43);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Ažuriraj";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnInsert.Location = new System.Drawing.Point(876, 133);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(133, 43);
            this.BtnInsert.TabIndex = 11;
            this.BtnInsert.Text = "Dodaj";
            this.BtnInsert.UseVisualStyleBackColor = false;
            // 
            // Upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.CboxUcenik);
            this.Controls.Add(this.CboxOdeljenje);
            this.Controls.Add(this.CboxGod);
            this.Controls.Add(this.TboxId);
            this.Controls.Add(this.TxtUcenik);
            this.Controls.Add(this.TxtOdeljenje);
            this.Controls.Add(this.TxtGodina);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Upisnica";
            this.Text = "Upisnica";
            this.Load += new System.EventHandler(this.Upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView;
        private System.Windows.Forms.Label TxtId;
        private System.Windows.Forms.Label TxtGodina;
        private System.Windows.Forms.Label TxtOdeljenje;
        private System.Windows.Forms.Label TxtUcenik;
        private System.Windows.Forms.TextBox TboxId;
        private System.Windows.Forms.ComboBox CboxGod;
        private System.Windows.Forms.ComboBox CboxOdeljenje;
        private System.Windows.Forms.ComboBox CboxUcenik;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
    }
}