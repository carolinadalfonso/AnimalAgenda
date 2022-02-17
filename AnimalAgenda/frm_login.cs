using AnimalAgenda.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AnimalAgenda
{
    public partial class frm_login : DevExpress.XtraEditors.XtraForm
    {
        #region Properties

        private MyFireStore fireStore;
        public User userLogged;

        #endregion

        #region Constructor
        public frm_login()
        {
            InitializeComponent();
            fireStore = new MyFireStore();
        }

        #endregion

        #region Events

        private async void cmdLogin_Click(object sender, EventArgs e)
        {
            if (validationProvider.Validate())
            {
                this.Enabled = false;
                List<User> users = await fireStore.GetUsers();
                userLogged = users.Find(u => u.IdUser == txtUser.Text && u.Password == txtPassword.Text);
                if (userLogged != null)
                {
                    lblError.Visible = false;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    lblError.Visible = true;
                }
                this.Enabled = true;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txtUser.Properties.Mask.EditMask = @"\S*";
            txtUser.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtPassword.Properties.Mask.EditMask = @"\S*";
            txtPassword.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
        }

        #endregion
    }
}
