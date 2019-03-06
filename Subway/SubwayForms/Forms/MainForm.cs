using MySql.Data.MySqlClient;
using SubwayForm.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SubwayForms.Forms
{
    public partial class MainForm : Form
    {
        Hashtable hashtable = new Hashtable();
        Common cmm = new Common();
        Button btn1;

        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
            ClientSize = new Size(1000, 900);
            this.MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Subway";
            this.BackColor = Color.White;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Button();
        }

        private void Button()
        {
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(300, 200));
            hashtable.Add("point", new Point(350, 700));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn1");
            hashtable.Add("text", "주문하기");
            hashtable.Add("click", (EventHandler)btn_order);
            btn1 = cmm.getButton(hashtable, this);
            btn1.Font = new Font("맑은 고딕", 20, FontStyle.Regular);
        }

        private void btn_order(object o, EventArgs e)
        {
            MdiForm mf = new MdiForm();
            mf.Show();
            this.Visible = false;


        }


    }
}
 
