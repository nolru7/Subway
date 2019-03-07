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
    public partial class CheezeForm : Form
    {
        public CheezeForm()
        {
            InitializeComponent();
            Load += CheezeForm_Load;
            this.BackColor = Color.Blue;
        }

        private void CheezeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
