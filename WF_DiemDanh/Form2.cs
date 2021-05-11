using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DiemDanh
{
    public partial class Form2 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "BCxFwc55bGkiQlwK3aAJJ4Ky8lhqNgtJ3l9KEwvM",
            BasePath = "https://test-86631-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Connection Fail");
            }
            Load_data();
        }
        public void Load_data()
        {
            bool a = true;
            bool b = true;
            SinhVien sv = new SinhVien();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Họ và tên");
            table.Columns.Add("Phòng");
            table.Columns.Add("Thời gian");
            table.Columns.Add("Ghi chú");

            for (int i = 1; i < 500; i++)
            {
                var response = client.Get("MAYA/" + i);
                sv = response.ResultAs<SinhVien>();
                if (sv != null)
                {
                    table.Rows.Add(sv.ID, sv.Name, sv.Room, sv.Time, sv.Note);
                }
                else
                {
                    a = false;
                }
                var responseB = client.Get("MAYB/" + i);
                sv = responseB.ResultAs<SinhVien>();
                if (sv != null)
                {
                    table.Rows.Add(sv.ID, sv.Name, sv.Room, sv.Time, sv.Note);
                }
                else
                {
                    b = false;
                }
                if (a == false && b == false)
                {
                    break;
                }
            }
            if (table.Rows.Count > 0)
            {
                dtgHienThi.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }
        public void Delete_data()
        {
            client = new FirebaseClient(config);
            var response = client.Delete("MAYA");
            var response2 = client.Delete("MAYB");
            MessageBox.Show("Xóa dữ liệu thành công!");
        }
        private void ToExcel(DataGridView dtgHienThi, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "DANH SÁCH ĐIỂM DANH";

                // export header
                for (int i = 0; i < dtgHienThi.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dtgHienThi.Columns[i].HeaderText;
                }

                // export content
                for (int i = 0; i < dtgHienThi.RowCount; i++)
                {
                    for (int j = 0; j < dtgHienThi.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgHienThi.Rows[i].Cells[j].Value.ToString();//
                    }
                }

                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dtgHienThi, saveFileDialog1.FileName);
                Delete_data();
            }
        }
    }
}
