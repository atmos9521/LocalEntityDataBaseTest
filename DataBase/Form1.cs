using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase.DBConnect;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowMessage(int MessageNum) {
            switch (MessageNum)
            {
                case 1:
                    MessageBox.Show("資料處理完成");
                    break;
                default:
                    MessageBox.Show("錯誤的ID");
                    break;
            }            
        }

        AllRepository<Student> Student_Db = new AllRepository<Student>();
        private void Create_btn_Click(object sender, EventArgs e)
        {
            Student studend_data = new Student();
            int ID_number = 0;
            int.TryParse(ID_txt.Text, out ID_number);
            if (ID_number <=0)
            {
                ShowMessage(0);
                return;
            }
            studend_data.ID = ID_number;
            studend_data.LastName = LastName_txt.Text;
            studend_data.FirstMidName = FirstName_txt.Text;
            studend_data.EnrollmentDate = DateTime.Now;

            Student_Db.Create(studend_data);
            ShowMessage(1);
        }

        private void Read_btn_Click(object sender, EventArgs e)
        {
            Student_Db.GetByID(1);
            int count = 0;
            foreach (var item in Student_Db.GetAllData())
            {
                count++;
                Console.WriteLine(item.ID);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.FirstMidName);
                Console.WriteLine(item.EnrollmentDate);
                Console.WriteLine(string.Format("------------{0}------------",count));
            }
            ShowMessage(1);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Student studend_data = new Student();
            int ID_number = 0;
            int.TryParse(ID_txt.Text, out ID_number);
            if (ID_number <= 0)
            {
                ShowMessage(0);
                return;
            }
            studend_data.ID = ID_number;
            studend_data.LastName = LastName_txt.Text;
            studend_data.FirstMidName = FirstName_txt.Text;
            studend_data.EnrollmentDate = DateTime.Now;

            Student_Db.Update(studend_data);
            ShowMessage(1);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            int ID_number = 0;
            int.TryParse(ID_txt.Text, out ID_number);
            if (ID_number <= 0)
            {
                ShowMessage(0);
                return;
            }
            Student_Db.Delete(ID_number);
            ShowMessage(1);
        }

        private void Drop_btn_Click(object sender, EventArgs e)
        {
            bool result = Student_Db.UpdateTableSKIMA("Student");
            MessageBox.Show("result = " + result);
            
        }
    }
}
