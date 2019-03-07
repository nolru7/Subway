using SubwayForm.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubwayForms.Forms
{
    public partial class MdiForm : Form
    {
        Hashtable hashtable = new Hashtable();
        Common cmm = new Common();
        Button btn1, btn2, btn3, btn4, btn5, btn6, btn7;
        Panel pnl1,pnl2;        //pnl1 = 전체 패널 , pnl2 = 폼나오는패널
        MenuForm mf;
        BreadForm bf;
        ToppingForm tf;
        VegeForm vf;
        CheezeForm cf;
        SourceForm sf;
        SideForm smf;//사이드메뉴폼
        public MdiForm()
        {
            InitializeComponent();
            Load += MdiForm_Load;
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(1500, 800);
            this.MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Subway";
            this.BackColor = Color.White;
            this.IsMdiContainer = true;
            Button();
            Panel();
        }

        private void Button()
        {
            /*          메뉴          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(50, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn1");
            hashtable.Add("text", "메뉴");
            hashtable.Add("click", (EventHandler)btn_Menu);
            btn1 = cmm.getButton(hashtable, this);
            btn1.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          빵          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(200, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn2");
            hashtable.Add("text", "빵");
            hashtable.Add("click", (EventHandler)btn_Bread);
            btn2 = cmm.getButton(hashtable, this);
            btn2.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          토핑          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(350, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn3");
            hashtable.Add("text", "토핑");
            hashtable.Add("click", (EventHandler)btn_Topping);
            btn3 = cmm.getButton(hashtable, this);
            btn3.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          야채          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(500, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn4");
            hashtable.Add("text", "야채");
            hashtable.Add("click", (EventHandler)btn_Vegetable);
            btn4 = cmm.getButton(hashtable, this);
            btn4.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          치즈          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(650, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn5");
            hashtable.Add("text", "치즈");
            hashtable.Add("click", (EventHandler)btn_Cheeze);
            btn5 = cmm.getButton(hashtable, this);
            btn5.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          소스          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(800, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn6");
            hashtable.Add("text", "소스");
            hashtable.Add("click", (EventHandler)btn_Source);
            btn6 = cmm.getButton(hashtable, this);
            btn6.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          사이드메뉴          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(950, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn7");
            hashtable.Add("text", "사이드  메뉴");
            hashtable.Add("click", (EventHandler)btn_SideForm);
            btn7 = cmm.getButton(hashtable, this);
            btn7.Font = new Font("맑은 고딕", 20, FontStyle.Regular);
        }

        private void Panel()
        {
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(1500, 800));
            hashtable.Add("point", new Point(0, 0));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "pnl1");
            pnl1 = cmm.getPanel(hashtable, this);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(1050, 550));
            hashtable.Add("point", new Point(50, 140));
            hashtable.Add("color", Color.Black);
            hashtable.Add("name", "pnl2");
            pnl2 = cmm.getPanel(hashtable, pnl1);
        }
        
        private void btn_Menu(object o, EventArgs e)  //메뉴카테로그 이벤트
        {
            mf = new MenuForm();

            mf.WindowState = FormWindowState.Maximized;
            mf.FormBorderStyle = FormBorderStyle.None;
            mf.MdiParent = this;
            pnl2.Controls.Add(mf);
            mf.Show();
        }

        private void btn_Bread(object o, EventArgs e) //빵카테로그 이벤트
        {
            bf = new BreadForm();

            bf.WindowState = FormWindowState.Maximized;
            bf.FormBorderStyle = FormBorderStyle.None;
            bf.MdiParent = this;
            pnl2.Controls.Add(bf);
            bf.Show();
        }

        private void btn_Topping(object o, EventArgs e) //토핑카테로그 이벤트
        {
            tf = new ToppingForm();
            tf.WindowState = FormWindowState.Maximized;
            tf.FormBorderStyle = FormBorderStyle.None;
            tf.MdiParent = this;
            pnl2.Controls.Add(tf);
            tf.Show();
        }

        private void btn_Vegetable(object o, EventArgs e) //토핑카테로그 이벤트
        {
            vf = new VegeForm();
            vf.WindowState = FormWindowState.Maximized;
            vf.FormBorderStyle = FormBorderStyle.None;
            vf.MdiParent = this;
            pnl2.Controls.Add(vf);
            vf.Show();
        }

        private void btn_Cheeze(object o, EventArgs e) //토핑카테로그 이벤트
        {
            cf = new CheezeForm();
            cf.WindowState = FormWindowState.Maximized;
            cf.FormBorderStyle = FormBorderStyle.None;
            cf.MdiParent = this;
            pnl2.Controls.Add(cf);
            cf.Show();
        }

        private void btn_Source(object o, EventArgs e) //토핑카테로그 이벤트
        {
            sf = new SourceForm();
            sf.WindowState = FormWindowState.Maximized;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.MdiParent = this;
            pnl2.Controls.Add(sf);
            sf.Show();
        }

        private void btn_SideForm(object o, EventArgs e) //토핑카테로그 이벤트
        {
            smf = new SideForm();
            smf.WindowState = FormWindowState.Maximized;
            smf.FormBorderStyle = FormBorderStyle.None;
            smf.MdiParent = this;
            pnl2.Controls.Add(smf);
            smf.Show();
        }


    }
}
