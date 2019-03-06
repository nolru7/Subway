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
        Panel pnl1,pnl2;

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
            //hashtable.Add("click", (EventHandler)btn_);
            btn2 = cmm.getButton(hashtable, this);
            btn2.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          토핑          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(350, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn3");
            hashtable.Add("text", "토핑");
            //hashtable.Add("click", (EventHandler)btn_);
            btn3 = cmm.getButton(hashtable, this);
            btn3.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          야채          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(500, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn4");
            hashtable.Add("text", "야채");
            //hashtable.Add("click", (EventHandler)btn_);
            btn4 = cmm.getButton(hashtable, this);
            btn4.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          치즈          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(650, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn5");
            hashtable.Add("text", "치즈");
            //hashtable.Add("click", (EventHandler)btn_);
            btn5 = cmm.getButton(hashtable, this);
            btn5.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          소스          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(800, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn6");
            hashtable.Add("text", "소스");
            //hashtable.Add("click", (EventHandler)btn_);
            btn6 = cmm.getButton(hashtable, this);
            btn6.Font = new Font("맑은 고딕", 20, FontStyle.Regular);

            /*          사이드메뉴          */
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 100));
            hashtable.Add("point", new Point(950, 40));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn7");
            hashtable.Add("text", "사이드  메뉴");
            //hashtable.Add("click", (EventHandler)btn_);
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

        private void btn_Menu(object o, EventArgs e)
        {
            //MenuForm


        }
    }
}
