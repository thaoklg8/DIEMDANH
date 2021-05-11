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

namespace WF_DiemDanh
{
    public partial class FormAccess : Form
    {
        public FormAccess()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)// máy a
        {
            //if (txtAccess != null)
            //{
            //    DocGhiFile.GhiFile("DuongDanAccess.txt", txtAccess.Text);
            //    try
            //    {
            //        OleDbConnection strcon = new OleDbConnection();
            //        string a = DocGhiFile.DocFile("DuongDanAccess.txt");
            //        string s = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + a + "; Persist Security Info = False;";
            //        strcon.ConnectionString = s;
            //        strcon.Open();
            //        DocGhiFile.GhiFile("IDMay.txt", "MAYA");
            //        DocGhiFile.GhiFile("DuongDanAccess.txt", txtAccess.Text);
            //        Form1 fr = new Form1();
            //        fr.ShowDialog();
            //        this.Close();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Đường link chưa đúng! ");
            //    }
            //;
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đường lưu file Access!");
            //}
            DocGhiFile.GhiFile("IDMay.txt", "MAYA");
            Form1 fr = new Form1();
            fr.ShowDialog();
            this.Close();
        }

        private void btnMayB_Click(object sender, EventArgs e)
        {
            //if (txtAccess != null)
            //{
            //    DocGhiFile.GhiFile("DuongDanAccess.txt", txtAccess.Text);
            //    try
            //    {
            //        OleDbConnection strcon = new OleDbConnection();
            //        string a = DocGhiFile.DocFile("DuongDanAccess.txt");
            //        string s = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + a + "; Persist Security Info = False;";
            //        strcon.ConnectionString = s;
            //        strcon.Open();
            //        DocGhiFile.GhiFile("IDMay.txt", "MAYB");
            //        DocGhiFile.GhiFile("DuongDanAccess.txt", txtAccess.Text);
            //        Form1 fr = new Form1();
            //        fr.Activate();
            //        fr.ShowDialog();
            //        this.Close();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Đường link chưa đúng! ");
            //    }
            //;
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đường lưu file Access!");
            //}
            DocGhiFile.GhiFile("IDMay.txt", "MAYB");
            Form1 fr = new Form1();
            fr.Activate();
            fr.ShowDialog();
            this.Close();
        }
    }
}
