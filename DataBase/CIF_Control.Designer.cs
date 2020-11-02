namespace DataBase
{
    partial class CIF_Control
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
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Tel_Num_lbl = new System.Windows.Forms.Label();
            this.Tel_Num_txt = new System.Windows.Forms.TextBox();
            this.Gender_lbl = new System.Windows.Forms.Label();
            this.Gender_txt = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.ID_Num_lbl = new System.Windows.Forms.Label();
            this.ID_Num_txt = new System.Windows.Forms.TextBox();
            this.Create_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(325, 191);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(138, 47);
            this.Delete_btn.TabIndex = 23;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(325, 138);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(138, 47);
            this.Update_btn.TabIndex = 22;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            // 
            // Read_btn
            // 
            this.Read_btn.Location = new System.Drawing.Point(325, 85);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(138, 47);
            this.Read_btn.TabIndex = 21;
            this.Read_btn.Text = "Read";
            this.Read_btn.UseVisualStyleBackColor = true;
            // 
            // Tel_Num_lbl
            // 
            this.Tel_Num_lbl.AutoSize = true;
            this.Tel_Num_lbl.Location = new System.Drawing.Point(32, 181);
            this.Tel_Num_lbl.Name = "Tel_Num_lbl";
            this.Tel_Num_lbl.Size = new System.Drawing.Size(61, 15);
            this.Tel_Num_lbl.TabIndex = 20;
            this.Tel_Num_lbl.Text = "Tel_Num";
            // 
            // Tel_Num_txt
            // 
            this.Tel_Num_txt.Location = new System.Drawing.Point(120, 178);
            this.Tel_Num_txt.Name = "Tel_Num_txt";
            this.Tel_Num_txt.Size = new System.Drawing.Size(183, 25);
            this.Tel_Num_txt.TabIndex = 19;
            // 
            // Gender_lbl
            // 
            this.Gender_lbl.AutoSize = true;
            this.Gender_lbl.Location = new System.Drawing.Point(32, 133);
            this.Gender_lbl.Name = "Gender_lbl";
            this.Gender_lbl.Size = new System.Drawing.Size(48, 15);
            this.Gender_lbl.TabIndex = 18;
            this.Gender_lbl.Text = "Gender";
            // 
            // Gender_txt
            // 
            this.Gender_txt.Location = new System.Drawing.Point(120, 130);
            this.Gender_txt.Name = "Gender_txt";
            this.Gender_txt.Size = new System.Drawing.Size(183, 25);
            this.Gender_txt.TabIndex = 17;
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(32, 83);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(40, 15);
            this.Name_lbl.TabIndex = 16;
            this.Name_lbl.Text = "Name";
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(120, 80);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(183, 25);
            this.Name_txt.TabIndex = 15;
            // 
            // ID_Num_lbl
            // 
            this.ID_Num_lbl.AutoSize = true;
            this.ID_Num_lbl.Location = new System.Drawing.Point(32, 35);
            this.ID_Num_lbl.Name = "ID_Num_lbl";
            this.ID_Num_lbl.Size = new System.Drawing.Size(57, 15);
            this.ID_Num_lbl.TabIndex = 14;
            this.ID_Num_lbl.Text = "ID_Num";
            // 
            // ID_Num_txt
            // 
            this.ID_Num_txt.Location = new System.Drawing.Point(120, 32);
            this.ID_Num_txt.Name = "ID_Num_txt";
            this.ID_Num_txt.Size = new System.Drawing.Size(183, 25);
            this.ID_Num_txt.TabIndex = 13;
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(325, 32);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(138, 47);
            this.Create_btn.TabIndex = 12;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // CIF_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Read_btn);
            this.Controls.Add(this.Tel_Num_lbl);
            this.Controls.Add(this.Tel_Num_txt);
            this.Controls.Add(this.Gender_lbl);
            this.Controls.Add(this.Gender_txt);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.ID_Num_lbl);
            this.Controls.Add(this.ID_Num_txt);
            this.Controls.Add(this.Create_btn);
            this.Name = "CIF_Control";
            this.Text = "CIF_Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Label Tel_Num_lbl;
        private System.Windows.Forms.TextBox Tel_Num_txt;
        private System.Windows.Forms.Label Gender_lbl;
        private System.Windows.Forms.TextBox Gender_txt;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label ID_Num_lbl;
        private System.Windows.Forms.TextBox ID_Num_txt;
        private System.Windows.Forms.Button Create_btn;
    }
}