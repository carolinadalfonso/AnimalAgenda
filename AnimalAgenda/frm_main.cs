using AnimalAgenda.Classes;
using System;
using DevExpress.Spreadsheet;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Net;
using DevExpress.XtraEditors;

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

        private async void cmdExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea exportar todos los registros a Excel?", "¡Atención!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var fd = new FolderBrowserDialog())
                {
                    fd.Description = "Seleccione la carpeta para guardar los archivos:";
                    if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                    {
                        await ExportAnimals(fd.SelectedPath);
                    }
                }
            }
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

        private void cmdAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_about frmAbout = new frm_about();
            frmAbout.ShowDialog(this);
        }

        #endregion

        #region Methods
        public async Task ExportAnimals(string selectedPath)
        {
            try
            {
                WebClient webClient = new WebClient();

                // Export to excel each animal
                List<DTO_Animal> animals = await fireStore.GetAnimals();

                frm_progress_bar frmProgressBar = new frm_progress_bar();

                ProgressBarControl progressBar = new ProgressBarControl();
                progressBar.Properties.Step = 1;
                progressBar.Properties.PercentView = true;
                progressBar.Properties.Maximum = animals.Count;
                progressBar.Properties.Minimum = 0;

                frmProgressBar.Controls.Add(progressBar);
                progressBar.Dock = DockStyle.Fill;
                frmProgressBar.Show();

                foreach (DTO_Animal animal in animals)
                {
                    string fileName = string.Format("{0}-{1}-{2}.xlsx", animal.Name, animal.AdmissionDate.ToString("dd-MM-yyyy"), DateTimeOffset.Now.ToUnixTimeMilliseconds());
                    string filePath = string.Format("{0}\\{1}", selectedPath, fileName);

                    Workbook workbook = new Workbook();
                    Worksheet worksheet = workbook.Worksheets[0];
                    worksheet.Name = "Información general";

                    ArrayList list = new ArrayList();
                    list.Add("Nombre:");
                    list.Add("Fecha de Nacimiento:");
                    list.Add("Fecha de Ingreso:");
                    list.Add("Sexo:");
                    list.Add("Especie:");
                    list.Add("Raza:");
                    list.Add("Tamaño:");
                    list.Add("Carácter:");
                    list.Add("Estado:");
                    list.Add("Color de Pelo:");
                    list.Add("Castrado:");
                    list.Add("Pipetas:");
                    list.Add("Desparasitado:");
                    list.Add("Enfermedades:");
                    list.Add("Medicaciones:");
                    list.Add("Historia:");

                    worksheet.Import(list, 0, 0, true);

                    worksheet.Columns[0].AutoFitColumns();
                    worksheet.Columns[1].Width = 700;

                    list.Clear();
                    list.Add(animal.Name);
                    list.Add(animal.Birthday.ToString("dd/MM/yyyy"));
                    list.Add(animal.AdmissionDate.ToString("dd/MM/yyyy"));
                    list.Add(animal.Sex);
                    list.Add(animal.Species);
                    list.Add(animal.Breed);
                    list.Add(animal.Size);
                    list.Add(animal.Character);
                    list.Add(animal.Status);
                    list.Add(animal.HairColor);
                    list.Add(animal.Castrated ? "Sí" : "No");
                    list.Add(animal.Pipettes ? "Sí" : "No");
                    list.Add(animal.Dewormer ? "Sí" : "No");
                    list.Add(animal.Diseases);
                    list.Add(animal.Medication);
                    list.Add(animal.History);
                    worksheet.Import(list, 0, 1, true);

                    if (!string.IsNullOrEmpty(animal.Photo))
                    {
                        Cell cell180 = worksheet[18, 0];
                        byte[] bytes = webClient.DownloadData(animal.Photo);
                        using (var ms = new MemoryStream(bytes))
                        {
                            worksheet.Pictures.AddPicture(Image.FromStream(ms), cell180);
                        }
                    }

                    // Second sheet
                    Worksheet worksheet2 = workbook.Worksheets.Add();
                    worksheet2.Name = "Vacunas";

                    list.Clear();
                    list.Add("Nombre");
                    list.Add("Fecha");
                    worksheet2.Import(list, 0, 0, false);

                    if (animal.ListVaccines != null && animal.ListVaccines.Count > 0)
                    {
                        var importOptions = new DataSourceImportOptions()
                        {
                            PropertyNames = new string[] { "Name", "Date" }
                        };
                        worksheet2.Import(animal.ListVaccines, 1, 0, importOptions);
                    }

                    worksheet2.Columns[0].AutoFitColumns();
                    worksheet2.Columns[1].AutoFitColumns();

                    // Saving the Excel file
                    workbook.SaveDocument(filePath, DocumentFormat.Xlsx);

                    progressBar.PerformStep();
                    progressBar.Update();
                }
                frmProgressBar.Close();
                frmProgressBar.Dispose();

                MessageBox.Show("Se han exportado correctamente los registros.", "¡Atención!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido un error al intentar exportar.", ex);
            }
        }

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
