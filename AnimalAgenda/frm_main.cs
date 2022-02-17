using AnimalAgenda.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalAgenda
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Properties

        private MyFireStore fireStore;
        private User userLogged;

        #endregion

        #region Constructor
        public frm_main(User user)
        {
            InitializeComponent();
            fireStore = new MyFireStore();
            userLogged = user;
        }

        #endregion

        #region Events
        private async void cmdSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await SearchAnimals();
        }

        private void cmdAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_animal frmAnimal = new frm_animal(null);
            frmAnimal.ShowDialog(this);
        }

        private void cmdEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAnimal();
        }

        private async void cmdDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DTO_Animal animalSelected = (DTO_Animal)gvAnimals.GetFocusedRow();
            if (animalSelected != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea borrar el registro seleccionado?", "¡Atención!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await fireStore.DeleteAnimal(animalSelected.IdAnimal);
                    await SearchAnimals();
                }
            }
        }
        private void cmdExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmdCreateUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_create_user frmCreateUser = new frm_create_user();
            frmCreateUser.ShowDialog(this);
        }

        private void cmdChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_change_password frmChangePassword = new frm_change_password(userLogged);
            frmChangePassword.ShowDialog(this);
        }

        private void gvAnimals_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                EditAnimal();
            }
        }

        #endregion

        #region Methods
        public async Task SearchAnimals()
        {
            gvAnimals.ShowLoadingPanel();
            List<DTO_Animal> animals = await fireStore.GetAnimals();
            gcAnimals.DataSource = animals;
            gvAnimals.HideLoadingPanel();
        }

        public void EditAnimal()
        {
            DTO_Animal selectedAnimal = (DTO_Animal)gvAnimals.GetFocusedRow();
            if (selectedAnimal != null)
            {
                frm_animal frmAnimal = new frm_animal(selectedAnimal);
                frmAnimal.ShowDialog(this);
            }
        }

        #endregion
    }
}
