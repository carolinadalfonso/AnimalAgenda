using System;
using System.Windows.Forms;

namespace AnimalAgenda
{
    public partial class frm_about : DevExpress.XtraEditors.XtraForm
    {
        #region Constructor
        public frm_about()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_about_Load(object sender, EventArgs e)
        {
            lblVersion.Text = string.Format("Versión: {0}", Application.ProductVersion);
        }

        #endregion
    }
}
