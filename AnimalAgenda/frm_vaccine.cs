using AnimalAgenda.Classes;
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
    public partial class frm_vaccine : DevExpress.XtraEditors.XtraForm
    {

        #region Properties

        public Vaccine selectedVaccine = null;

        #endregion

        #region Constructor

        public frm_vaccine(Vaccine selected)
        {
            InitializeComponent();
            selectedVaccine = selected;
        }

        #endregion

        #region Events
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (validationProvider.Validate())
            {
                this.Enabled = false;
                selectedVaccine.Name = txtNameVaccine.Text;
                selectedVaccine.Date = dteVaccine.DateTime.ToString("dd/MM/yyyy");
                this.Enabled = true;
                this.Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_vaccine_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedVaccine.Name))
            {
                this.Text = "Editando Vacuna";
                txtNameVaccine.Text = selectedVaccine.Name;
                dteVaccine.DateTime = DateTime.Parse(selectedVaccine.Date);
            }
            else
            {
                this.Text = "Nueva Vacuna";
            }
            cmdCancel.DialogResult = DialogResult.Cancel;
            cmdSave.DialogResult = DialogResult.OK;
        }

        #endregion

    }
}
