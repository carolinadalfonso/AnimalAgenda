using AnimalAgenda.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AnimalAgenda.Classes
{
    [Serializable()]
    public class Animal
    {
        public string AdmissionDate { get; set; }
        public string Birthday { get; set; }
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

        public Animal(DTO_Animal dtoAnimal)
        {
            AdmissionDate = dtoAnimal.AdmissionDate.ToString("dd/MM/yyyy");
            Birthday = dtoAnimal.Birthday.ToString("dd/MM/yyyy");
            Breed = dtoAnimal.Breed;
            Castrated = dtoAnimal.Castrated;
            Character = dtoAnimal.Character;
            Dewormer = dtoAnimal.Dewormer;
            Diseases = dtoAnimal.Diseases;
            HairColor = dtoAnimal.HairColor;
            History = dtoAnimal.History;
            Medication = dtoAnimal.Medication;
            Name = dtoAnimal.Name;
            Photo = dtoAnimal.Photo;
            PhotoFileName = dtoAnimal.PhotoFileName;
            Pipettes = dtoAnimal.Pipettes;
            Sex = dtoAnimal.Sex;
            Size = dtoAnimal.Size;
            Species = dtoAnimal.Species;
            Status = dtoAnimal.Status;
            Vaccines = dtoAnimal.Vaccines;
        }

    }
}
