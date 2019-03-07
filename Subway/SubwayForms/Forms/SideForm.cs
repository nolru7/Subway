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
    public partial class SideForm : Form
    {
        public SideForm()
        {
            InitializeComponent();
            Load += SideForm_Load;
            this.BackColor = Color.Violet;
        }

        private void SideForm_Load(object sender, EventArgs e)
        {
        }
    }
}
