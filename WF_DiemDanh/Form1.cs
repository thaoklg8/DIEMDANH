using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using FireSharp.Response;

namespace WF_DiemDanh
{
    public partial class Form1 : Form
    {
        OleDbConnection strcon = new OleDbConnection();
        DataSet dsHienThi = new DataSet();
        DataTable dsHienThi2 = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "BCxFwc55bGkiQlwK3aAJJ4Ky8lhqNgtJ3l9KEwvM",
            BasePath = "https://test-86631-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }
        public void Open_DataAccess()
        {
            string a = DocGhiFile.DocFile("DuongDanAccess.txt");
            //string a = ("D:/CODE/DIEMDANH/WF_DiemDanh/bin/Debug/DuongDanAccess.acc");
            string s = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + a + "; Persist Security Info = False;";
            strcon.ConnectionString = s;
            strcon.Open();
        }
        public DataSet Load_Data()
        {
            DateTime da = DateTime.Now;
            string ti = da.ToString();
            string s = "UPDATE THONGTIN_SINHVIEN set time_ ='" + ti + "'where id='" + txtNhap.Text + "';";
            string st = "select * from THONGTIN_SINHVIEN where id='" + txtNhap.Text + "'";


            OleDbDataAdapter tr = new OleDbDataAdapter(s, strcon);
            tr.Fill(dsHienThi, "THONGTIN_SINHVIEN");
            OleDbDataAdapter daShowData = new OleDbDataAdapter(st, strcon);
            daShowData.Fill(dsHienThi, "THONGTIN_SINHVIEN");
            return dsHienThi;
        }
        public DataSet Load_Data_CMND()
        {
            DateTime da = DateTime.Now;
            string ti = da.ToString();
            string s = "UPDATE THONGTIN_SINHVIEN set time_ ='" + ti + "'where CMND='" + txtCMND.Text + "';";
            string st = "select * from THONGTIN_SINHVIEN where CMND='" + txtCMND.Text + "'";


            OleDbDataAdapter tr = new OleDbDataAdapter(s, strcon);
            tr.Fill(dsHienThi, "THONGTIN_SINHVIEN");
            OleDbDataAdapter daShowData = new OleDbDataAdapter(st, strcon);
            daShowData.Fill(dsHienThi, "THONGTIN_SINHVIEN");
            return dsHienThi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.Focus();
            Open_DataAccess();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            /*if (txtNhap.Text.Length == 10)
            {
                if (KiemTraXuatHien())
                {
                    DataSet ds = new DataSet();
                    ds = Load_Data();
                    dtgHienThi.DataSource = ds.Tables[0];
                    GuiLenFirebase();
                }
                txtNhap.Clear();
                txtNhap.Focus();
            }*/
        }
        ////////////////////////////HÀM/////
        public bool KiemTraXuatHien() /// kiểm tra đã có trong datagirdview chưa?
        {
            if (dtgHienThi.Rows.Count > 0)
            {
                for (int i = 0; i < dtgHienThi.Rows.Count; i++)
                {
                    string a = dtgHienThi.Rows[i].Cells[0].Value.ToString();
                    if (a == txtNhap.Text)
                    {
                        MessageBox.Show("Đã điểm danh!", "THÔNG BÁO");
                        return false;
                    }
                    string b = dtgHienThi.Rows[i].Cells[4].Value.ToString();
                    if (b == txtCMND.Text)
                    {
                        MessageBox.Show("Đã điểm danh!", "THÔNG BÁO");
                        return false;
                    }
                }
            }
            return true;
        }


        public async void GuiLenFirebase() //////gửi data lên firebase
        {
            int i = dtgHienThi.Rows.Count;

            SinhVien sv = new SinhVien();
            sv.ID = dtgHienThi.Rows[i - 1].Cells[0].Value.ToString();
            sv.Name = dtgHienThi.Rows[i - 1].Cells[1].Value.ToString();
            sv.Room = dtgHienThi.Rows[i - 1].Cells[2].Value.ToString();
            sv.Time = dtgHienThi.Rows[i - 1].Cells[3].Value.ToString();
            sv.Note = dtgHienThi.Rows[i - 1].Cells[4].Value.ToString();
            client = new FirebaseClient(config);
            string a = DocGhiFile.DocFile("IDMay.txt");
            SetResponse response = await client.SetAsync(@a + "/" + i.ToString(), sv);///// THAY ĐƯỜNG DẪN KHÁC
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            string data = txtNhap.Text;
            if (e.KeyChar == (char)13)
            {
                if (KiemTraXuatHien())
                {
                    DataSet ds = new DataSet();
                    ds = Load_Data();
                    dtgHienThi.DataSource = ds.Tables[0];
                    GuiLenFirebase();
                }
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (KiemTraXuatHien())
            {
                DataSet ds = new DataSet();
                ds = Load_Data_CMND();
                dtgHienThi.DataSource = ds.Tables[0];
                GuiLenFirebase();
            }
            txtCMND.Clear();
            txtNhap.Focus();
        }
    }
}
