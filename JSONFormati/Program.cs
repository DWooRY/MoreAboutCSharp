using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONFormati
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fake Data olusturuldu.
            List<Staff> StaffList = new List<Staff>();
            for (int i = 1; i <= 100; i++)
            {
                Staff P1 = new Staff();
                P1.Id = Guid.NewGuid();
                P1.Name = FakeData.NameData.GetFirstName();
                P1.Surname = FakeData.NameData.GetSurname();
                P1.EmailAdress = $"{P1.Name}.{P1.Surname}@{FakeData.NetworkData.GetDomain()}"; 
                P1.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                P1.Country = FakeData.PlaceData.GetCountry();
                StaffList.Add(P1);
            }

            //Json formatinda export yapildi. ilgili path'e dosya olusturuldu.
            string jsonStaff1 = Newtonsoft.Json.JsonConvert.SerializeObject(StaffList);
            File.WriteAllText("C:/XML/JSON/Staff.json", jsonStaff1);

            //Json formatindan import yapmak. Bunlari uygulama icinde bir objeye almak.
            string jsonStaff2 = File.ReadAllText("C:/XML/JSON/Staff.json");
            List<XObject> StaffList2 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<XObject>>(jsonStaff2);

        }
    }
}
