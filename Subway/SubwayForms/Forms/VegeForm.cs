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
    public partial class VegeForm : Form
    {
        public VegeForm()
        {
            InitializeComponent();
            Load += VegeForm_Load;
            this.BackColor = Color.Green;
        }

        private void VegeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
