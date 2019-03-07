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
    public partial class BreadForm : Form
    {
        public BreadForm()
        {
            InitializeComponent();
            Load += Bread_Load;
            this.BackColor = Color.Orange;
        }

        private void Bread_Load(object sender, EventArgs e)
        {
        }
    }
}
