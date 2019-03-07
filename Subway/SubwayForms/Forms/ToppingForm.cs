using System;
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
    public partial class ToppingForm : Form
    {
        public ToppingForm()
        {
            InitializeComponent();
            Load += ToppingForm_Load;
            this.BackColor = Color.Yellow;
        }

        private void ToppingForm_Load(object sender, EventArgs e)
        {
        }
    }
}
