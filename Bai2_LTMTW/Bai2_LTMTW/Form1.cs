using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_LTMTW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lv_DanhSach.View = View.Details;
            lv_DanhSach.GridLines = true;
            lv_DanhSach.FullRowSelect = true;

            lv_DanhSach.Columns.Add("ID", 100);
            lv_DanhSach.Columns.Add("Tên", 200);
            lv_DanhSach.Columns.Add("Ngày sinh", 150);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ListViewItem item = lv_DanhSach.Items.Add(tbx_Id.Text);
            item.SubItems.Add(tbx_Name.Text);
            item.SubItems.Add(dtp_date.Value.ToString("dd/MM/yyyy"));

            tbx_Id.Clear();
            tbx_Name.Clear();
            dtp_date.Value = DateTime.Now;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx_Id.Text))
            {

                foreach (ListViewItem item in lv_DanhSach.Items)
                {
                    if (item.SubItems[0].Text == tbx_Id.Text)
                    {
                        lv_DanhSach.Items.Remove(item);
                        return;
                    }
                }
                MessageBox.Show("Khong tim thay ID");

            }
            else
            {
                MessageBox.Show("Nhap ID");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (!string.IsNullOrEmpty(tbx_Id.Text))
            {

                foreach (ListViewItem item in lv_DanhSach.Items)
                {
                    if (item.SubItems[0].Text == tbx_Id.Text)
                    {

                        item.SubItems[1].Text = tbx_Name.Text;
                        item.SubItems[2].Text = dtp_date.Value.ToString("dd/MM/yyyy");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Khong tim thay ID.");
                }

                tbx_Id.Clear();
                tbx_Name.Clear();
                dtp_date.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Nhap ID");
            }
        }
    }
}
