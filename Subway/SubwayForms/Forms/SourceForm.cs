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
    public partial class SourceForm : Form
    {
        public SourceForm()
        {
            InitializeComponent();
            Load += SourceForm_Load;
            this.BackColor = Color.Pink;
        }

        private void SourceForm_Load(object sender, EventArgs e)
        {
        }
    }
}
