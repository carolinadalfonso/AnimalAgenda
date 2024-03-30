using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalAgenda
{
    public partial class frm_progress_bar : Form
    {
        public frm_progress_bar()
        {
            InitializeComponent();
        }

        private void frm_progress_bar_Shown(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
