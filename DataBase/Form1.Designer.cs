namespace DataBase
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Create_btn = new System.Windows.Forms.Button();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.LastName_lbl = new System.Windows.Forms.Label();
            this.LastName_txt = new System.Windows.Forms.TextBox();
            this.FirstName_lbl = new System.Windows.Forms.Label();
            this.FirstName_txt = new System.Windows.Forms.TextBox();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Date_txt = new System.Windows.Forms.TextBox();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Drop_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(315, 21);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(138, 47);
            this.Create_btn.TabIndex = 0;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(110, 21);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(183, 25);
            this.ID_txt.TabIndex = 1;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(22, 24);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(22, 15);
            this.ID_lbl.TabIndex = 2;
            this.ID_lbl.Text = "ID";
            // 
            // LastName_lbl
            // 
            this.LastName_lbl.AutoSize = true;
            this.LastName_lbl.Location = new System.Drawing.Point(22, 72);
            this.LastName_lbl.Name = "LastName_lbl";
            this.LastName_lbl.Size = new System.Drawing.Size(64, 15);
            this.LastName_lbl.TabIndex = 4;
            this.LastName_lbl.Text = "LastName";
            // 
            // LastName_txt
            // 
            this.LastName_txt.Location = new System.Drawing.Point(110, 69);
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.Size = new System.Drawing.Size(183, 25);
            this.LastName_txt.TabIndex = 3;
            // 
            // FirstName_lbl
            // 
            this.FirstName_lbl.AutoSize = true;
            this.FirstName_lbl.Location = new System.Drawing.Point(22, 122);
            this.FirstName_lbl.Name = "FirstName_lbl";
            this.FirstName_lbl.Size = new System.Drawing.Size(66, 15);
            this.FirstName_lbl.TabIndex = 6;
            this.FirstName_lbl.Text = "FirstName";
            // 
            // FirstName_txt
            // 
            this.FirstName_txt.Location = new System.Drawing.Point(110, 119);
            this.FirstName_txt.Name = "FirstName_txt";
            this.FirstName_txt.Size = new System.Drawing.Size(183, 25);
            this.FirstName_txt.TabIndex = 5;
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Location = new System.Drawing.Point(22, 170);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(33, 15);
            this.Date_lbl.TabIndex = 8;
            this.Date_lbl.Text = "Date";
            // 
            // Date_txt
            // 
            this.Date_txt.Location = new System.Drawing.Point(110, 167);
            this.Date_txt.Name = "Date_txt";
            this.Date_txt.Size = new System.Drawing.Size(183, 25);
            this.Date_txt.TabIndex = 7;
            // 
            // Read_btn
            // 
            this.Read_btn.Location = new System.Drawing.Point(315, 74);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(138, 47);
            this.Read_btn.TabIndex = 9;
            this.Read_btn.Text = "Read";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(315, 127);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(138, 47);
            this.Update_btn.TabIndex = 10;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(315, 180);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(138, 47);
            this.Delete_btn.TabIndex = 11;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Drop_btn
            // 
            this.Drop_btn.Location = new System.Drawing.Point(110, 215);
            this.Drop_btn.Name = "Drop_btn";
            this.Drop_btn.Size = new System.Drawing.Size(183, 47);
            this.Drop_btn.TabIndex = 12;
            this.Drop_btn.Text = "Drop_StudentTable";
            this.Drop_btn.UseVisualStyleBackColor = true;
            this.Drop_btn.Click += new System.EventHandler(this.Drop_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 257);
            this.Controls.Add(this.Drop_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Read_btn);
            this.Controls.Add(this.Date_lbl);
            this.Controls.Add(this.Date_txt);
            this.Controls.Add(this.FirstName_lbl);
            this.Controls.Add(this.FirstName_txt);
            this.Controls.Add(this.LastName_lbl);
            this.Controls.Add(this.LastName_txt);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.Create_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label LastName_lbl;
        private System.Windows.Forms.TextBox LastName_txt;
        private System.Windows.Forms.Label FirstName_lbl;
        private System.Windows.Forms.TextBox FirstName_txt;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.TextBox Date_txt;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Drop_btn;
    }
}

