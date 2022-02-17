﻿using AnimalAgenda.Classes;
using AnimalAgenda.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AnimalAgenda
{
    public partial class frm_animal : DevExpress.XtraEditors.XtraForm
    {
        #region Properties

        public DTO_Animal selectedAnimal = null;
        private MyFireStore fireStore;
        private WebClient webClient = new WebClient();
        private string photo;
        private string photoFileName;
        private string photoDeleted;

        #endregion

        #region Constructor
        public frm_animal(DTO_Animal selected)
        {
            InitializeComponent();
            selectedAnimal = selected;
            fireStore = new MyFireStore();
        }

        #endregion

        #region Events
        private void frm_animal_Load(object sender, EventArgs e)
        {
            dteBirthday.Properties.MaxValue = DateTime.Now;
            dteAdmissionDate.Properties.MaxValue = DateTime.Now;
            if (selectedAnimal != null)
            {
                this.Text = "Editando";
                txtName.Text = selectedAnimal.Name;
                dteBirthday.DateTime = selectedAnimal.Birthday;
                txtAge.Text = selectedAnimal.Birthday.GetAge();
                dteAdmissionDate.DateTime = selectedAnimal.AdmissionDate;
                cmbSex.Text = selectedAnimal.Sex;
                txtSpecies.Text = selectedAnimal.Species;
                txtBreed.Text = selectedAnimal.Breed;
                cmbSize.Text = selectedAnimal.Size;
                txtCharacter.Text = selectedAnimal.Character;
                txtHairColor.Text = selectedAnimal.HairColor;
                photo = selectedAnimal.Photo;
                photoFileName = selectedAnimal.PhotoFileName;
                if (!string.IsNullOrEmpty(photo))
                {
                    byte[] bytes = webClient.DownloadData(photo);
                    using (var ms = new MemoryStream(bytes))
                    {
                        picPhoto.Image = Image.FromStream(ms);
                    }
                }

                chkCastrated.Checked = selectedAnimal.Castrated;
                chkPipettes.Checked = selectedAnimal.Pipettes;
                chkVaccines.Checked = selectedAnimal.Vaccines;
                chkDewormer.Checked = selectedAnimal.Dewormer;
                txtDiseases.Text = selectedAnimal.Diseases;
                txtMedication.Text = selectedAnimal.Medication;

                txtHistory.Text = selectedAnimal.History;
            }
            else
            {
                this.Text = "Nuevo ingreso";
            }
        }

        private async void cmdCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(photoDeleted))
            {
                await fireStore.DeleteImage(photoDeleted);
            }
            this.Close();
        }

        private async void cmdSave_Click(object sender, EventArgs e)
        {
            if (validationProviderAnimal.Validate())
            {
                if (selectedAnimal == null)
                {
                    selectedAnimal = new DTO_Animal();
                }

                selectedAnimal.Name = txtName.Text;
                selectedAnimal.Birthday = dteBirthday.DateTime;
                selectedAnimal.AdmissionDate = dteAdmissionDate.DateTime;
                selectedAnimal.Sex = cmbSex.Text;
                selectedAnimal.Species = txtSpecies.Text;
                selectedAnimal.Breed = txtBreed.Text;
                selectedAnimal.Size = cmbSize.Text;
                selectedAnimal.Character = txtCharacter.Text;
                selectedAnimal.HairColor = txtHairColor.Text;
                selectedAnimal.Photo = photo;
                selectedAnimal.PhotoFileName = photoFileName;

                selectedAnimal.Castrated = chkCastrated.Checked;
                selectedAnimal.Pipettes = chkPipettes.Checked;
                selectedAnimal.Vaccines = chkVaccines.Checked;
                selectedAnimal.Dewormer = chkDewormer.Checked;
                selectedAnimal.Diseases = txtDiseases.Text;
                selectedAnimal.Medication = txtMedication.Text;

                selectedAnimal.History = txtHistory.Text;

                Animal animal = new Animal(selectedAnimal);
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
                string animalJSON = JsonConvert.SerializeObject(animal, settings);
                await fireStore.SaveAnimal(animalJSON, selectedAnimal.IdAnimal);

                if (!string.IsNullOrEmpty(photoDeleted))
                {
                    await fireStore.DeleteImage(photoDeleted);
                }

                await ((frm_main)Owner).SearchAnimals();
                this.Close();
            }
            else
            {
                IList<Control> invalidControls = validationProviderAnimal.GetInvalidControls();
                if (invalidControls.Count == 1 && invalidControls.Contains(txtHistory))
                {
                    pnAnimal.SelectedPageIndex = 2;
                }
            }
        }

        private async void cmdUploadPhoto_Click(object sender, EventArgs e)
        {
            fdPhoto.CheckFileExists = true;
            fdPhoto.AddExtension = true;
            fdPhoto.Multiselect = false;
            fdPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            if (fdPhoto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Enabled = false;
                using (var fs = File.Open(fdPhoto.FileNames[0], FileMode.Open))
                {
                    if (!string.IsNullOrEmpty(photo))
                    {
                        photoDeleted = photoFileName;
                    }
                    BuildFileName(fdPhoto.FileNames[0].Substring(fdPhoto.FileNames[0].LastIndexOf('\\') + 1));
                    photo = await fireStore.SaveImage(fs, photoFileName);
                }

                byte[] bytes = webClient.DownloadData(photo);
                using (var ms = new MemoryStream(bytes))
                {
                    picPhoto.Image = Image.FromStream(ms);
                }
                this.Enabled = true;
            }
        }

        private void dteBirthday_EditValueChanged(object sender, EventArgs e)
        {
            if (dteBirthday.DateTime > DateTime.MinValue)
            {
                txtAge.Text = dteBirthday.DateTime.GetAge();
            }
            else
            {
                txtAge.Text = string.Empty;
            }
        }

        #endregion

        #region Methods

        private void BuildFileName(string fileName)
        {
            string extension = fileName.Substring(fileName.LastIndexOf('.'));
            string name = fileName.Substring(0, fileName.LastIndexOf('.'));
            photoFileName = string.Format("{0}_{1}{2}", name, DateTime.Now.Ticks, extension);
        }

        #endregion
    }
}
