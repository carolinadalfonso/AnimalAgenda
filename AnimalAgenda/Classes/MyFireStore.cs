using AnimalAgenda.Classes;
using Firebase.Storage;
using Google.Cloud.Firestore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AnimalAgenda
{
    class MyFireStore
    {
        readonly string jsonPath = "./Config/dogagenda-firebase-adminsdk-ukkcs-a521c26d42.json";
        readonly string projectId = "dogagenda";
        readonly FirestoreDb db;

        public MyFireStore()
        {
            using (StreamReader r = new StreamReader(jsonPath))
            {
                string json = r.ReadToEnd();
                db = new FirestoreDbBuilder { ProjectId = projectId, JsonCredentials = json }.Build();
            }
        }

        public async Task<List<User>> GetUsers()
        {
            CollectionReference usersRef = db.Collection("users");
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            List<User> users = new List<User>();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> documentDictionary = document.ToDictionary();

                string idUser = documentDictionary["user"].ToString();
                string password = documentDictionary["password"].ToString();
                string name = documentDictionary["name"].ToString();

                users.Add(new User { IdDocumentUser = document.Id, IdUser = idUser, Password = password, Name = name });
            }

            return users;
        }

        public async Task SaveUser(User user)
        {
            CollectionReference usersRef = db.Collection("users");
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                { "name", user.Name },
                { "password", user.Password },
                { "user", user.IdUser }
            };

            if (!string.IsNullOrEmpty(user.IdDocumentUser))
            {
                DocumentReference userRef = usersRef.Document(user.IdDocumentUser);
                await userRef.SetAsync(dic);
            }
            else
            {
                await usersRef.AddAsync(dic);
            }
        }

        public async Task<List<DTO_Animal>> GetAnimals()
        {
            CollectionReference animalsRef = db.Collection("dogs");
            QuerySnapshot snapshot = await animalsRef.GetSnapshotAsync();

            List<DTO_Animal> animals = new List<DTO_Animal>();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, dynamic> documentDictionary = document.ToDictionary();
                animals.Add(new DTO_Animal(documentDictionary, document.Id));
            }

            return animals;
        }

        public async Task SaveAnimal(string animalJSON, string vaccineJSON = null, string documentId = "")
        {
            CollectionReference animalsRef = db.Collection("dogs");
            Dictionary<string, dynamic> dic = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(animalJSON);
            if(!string.IsNullOrEmpty(vaccineJSON))
            {
                var dicVaccine = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(vaccineJSON);
                dic.Add("listVaccine", dicVaccine);
            }
            if (!string.IsNullOrEmpty(documentId))
            {
                DocumentReference animalRef = animalsRef.Document(documentId);
                await animalRef.SetAsync(dic);
            }
            else
            {
                await animalsRef.AddAsync(dic);
            }
        }

        public async Task DeleteAnimal(string documentId)
        {
            CollectionReference animalsRef = db.Collection("dogs");
            DocumentReference animalRef = animalsRef.Document(documentId);
            await animalRef.DeleteAsync();
        }

        public async Task<string> SaveImage(FileStream stream, string fileName)
        {
            var task = new FirebaseStorage("dogagenda.appspot.com")
             .Child("images")
             .Child(fileName)
             .PutAsync(stream);

            var downloadUrl = await task;
            return downloadUrl;
        }

        public async Task DeleteImage(string fileName)
        {
            var task = new FirebaseStorage("dogagenda.appspot.com")
             .Child("images")
             .Child(fileName)
             .DeleteAsync();

            await task;
        }
    }
}