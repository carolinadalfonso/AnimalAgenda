using AnimalAgenda.Classes;
using AnimalAgenda.Helpers;
using System;

namespace AnimalAgenda
{
    public partial class frm_create_user : DevExpress.XtraEditors.XtraForm
    {
        #region Properties

        private MyFireStore fireStore;

        #endregion

        #region Constructor
        public frm_create_user()
        {
            InitializeComponent();
            fireStore = new MyFireStore();
        }

        #endregion

        #region Events
        private async void cmdSave_Click(object sender, EventArgs e)
        {
            if (validationProvider.Validate())
            {
                this.Enabled = false;
                User newUser = new User();
                newUser.Name = txtName.Text;
                newUser.Password = txtPassword.Text.ToMD5();
                newUser.IdUser = txtUser.Text;
                await fireStore.SaveUser(newUser);
                this.Enabled = true;
                this.Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_create_user_Load(object sender, EventArgs e)
        {
            txtUser.Properties.Mask.EditMask = @"\S*";
            txtUser.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtPassword.Properties.Mask.EditMask = @"\S*";
            txtPassword.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
        }

        #endregion
    }
}
