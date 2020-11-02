using DataBase.DBConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class CIF_Control : Form
    {
        public CIF_Control()
        {
            InitializeComponent();
        }

        void ShowMessage(int MessageNum)
        {
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
        AllRepository<CIF> CIF_Db = new AllRepository<CIF>();
        private void Create_btn_Click(object sender, EventArgs e)
        {
            CIF cif_data = new CIF();
            int ID_num = 0;
            int.TryParse(ID_Num_txt.Text, out ID_num);
            if (ID_num <= 0)
            {
                ShowMessage(0);
                return;
            }
            cif_data.ID_Num = ID_num;
            cif_data.Name = Name_txt.Text;
            cif_data.Gender = Gender_txt.Text;
            cif_data.EnterDate = DateTime.Now;

            CIF_Db.Create(cif_data);
        }
    }
}
