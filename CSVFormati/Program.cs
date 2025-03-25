using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFormati
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> staffList = new List<Staff>();

            for (int i = 0; i < 50; i++)
            {
                Staff temp = new Staff();
                temp.Id = i.ToString();
                temp.Name = FakeData.NameData.GetFirstName();
                temp.Surname = FakeData.NameData.GetSurname();
                temp.EmailAdress = $"{temp.Name}.{temp.Surname}@{FakeData.NetworkData.GetDomain()}";
                temp.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                temp.Country = FakeData.PlaceData.GetCountry();
                staffList.Add(temp);
            }

            //CSV formatinda export ettik. ilgili klasorde csv dosyasi olusturuldu.
            StreamWriter SW = new StreamWriter(@"C:\\XML\CSV\staff.csv");
            CsvWriter Write = new CsvWriter(SW, new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture));

            Write.WriteHeader(typeof(Staff));
            Write.NextRecord();
            for (int i = 0; i < staffList.Count; i++)
            {
                Write.WriteRecord(staffList[i]);
                Write.NextRecord();
            }
            SW.Close();

            //CSV formatinda import ettik. ilgili klasörden csv dosyasını list olarak aldık.
            StreamReader SR = new StreamReader(@"C:\\XML\CSV\staff.csv");
            CsvReader Read = new CsvReader(SR, new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture));
            List<Staff> staffList2 = Read.GetRecords<Staff>().ToList();

        }
    }

}