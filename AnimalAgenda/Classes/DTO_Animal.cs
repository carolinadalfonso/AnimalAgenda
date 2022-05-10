using System;
using System.Collections.Generic;

namespace AnimalAgenda.Classes
{
    [Serializable()]
    public class DTO_Animal
    {
        public string IdAnimal { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public bool Castrated { get; set; }
        public string Character { get; set; }
        public bool Dewormer { get; set; }
        public string Diseases { get; set; }
        public string HairColor { get; set; }
        public string History { get; set; }
        public string Medication { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string PhotoFileName { get; set; }
        public bool Pipettes { get; set; }
        public string Sex { get; set; }
        public string Size { get; set; }
        public string Species { get; set; }
        public string Status { get; set; }
        public bool Vaccines { get; set; }
        public List<Vaccine> ListVaccines { get; set; }

        public DTO_Animal() { }
        public DTO_Animal(Dictionary<string, dynamic> documents, string id)
        {
            Map(documents, id);
        }

        private void Map(Dictionary<string, dynamic> documents, string id)
        {
            string admissiondate = documents["admissionDate"].ToString();
            string birthday = documents["birthday"].ToString();

            IdAnimal = id;
            AdmissionDate = DateTime.Parse(admissiondate);
            Birthday = DateTime.Parse(birthday);
            Breed = documents["breed"];
            Castrated = documents["castrated"];
            Character = documents["character"];
            Dewormer = documents["dewormer"];
            Diseases = documents["diseases"];
            HairColor = documents["hairColor"];
            History = documents["history"];
            Medication = documents["medication"];
            Name = documents["name"];
            Photo = documents["photo"];
            PhotoFileName = documents["photoFileName"];
            Pipettes = documents["pipettes"];
            Sex = documents["sex"];
            Size = documents["size"];
            Species = documents["species"];
            Status = documents.ContainsKey("status") ? documents["status"] : string.Empty;
            Vaccines = documents["vaccines"];
            if (documents.ContainsKey("listVaccine"))
            {
                ListVaccines = new List<Vaccine>();
                var lvaccine = documents["listVaccine"];
                foreach (var itemVaccine in lvaccine)
                {
                    Vaccine vaccine = new Vaccine();
                    vaccine.Name = itemVaccine["name"];
                    vaccine.Date = itemVaccine["date"];
                    ListVaccines.Add(vaccine);
                }
            }
        }
    }
}
