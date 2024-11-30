using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         book bk = new book();
            {
                titel = "book";
            }

        }
    }
}
public class book
{
    public string titel;
    public string author;
    public int year;
    public void printinfo()
    {
        MessageBox.Show("مشخصات /n" + ":عنوان کتاب" + titel + "/n" + ":نویسنده" + author + "/n" + ":سال انتشار" + "/n");
    }

}
public class member
{
    public string name;
    public int memderid;
    public string phone;
    public void memberinfo()
    {
        MessageBox.Show("مشخات کاربر/n" + "اسم کاربر:" + name + "/n" + "ایدی کاربر:" + phone);
    }
}