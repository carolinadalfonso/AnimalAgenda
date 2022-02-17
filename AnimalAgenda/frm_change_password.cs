using AnimalAgenda.Classes;
using System;

namespace AnimalAgenda
{
    public partial class frm_change_password : DevExpress.XtraEditors.XtraForm
    {
        #region Properties

        public User userLogged;
        private MyFireStore fireStore;

        #endregion

        #region Constructor
        public frm_change_password(User user)
        {
            InitializeComponent();
            userLogged = user;
            fireStore = new MyFireStore();
        }

        #endregion

        #region Events
        private async void cmdSave_Click(object sender, EventArgs e)
        {
            if (validationProvider.Validate())
            {
                this.Enabled = false;
                userLogged.Password = txtPassword.Text;
                await fireStore.SaveUser(userLogged);
                this.Enabled = true;
                this.Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_change_password_Load(object sender, EventArgs e)
        {
            txtPassword.Properties.Mask.EditMask = @"\S*";
            txtPassword.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
        }

        #endregion
    }
}
