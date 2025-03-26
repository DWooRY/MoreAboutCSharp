using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace RegistryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir deger olusturma islemi.
            Registry.CurrentUser.SetValue("Key", "Value");

            // Degeri okuma islemi.
            string iValue = Registry.CurrentUser.GetValue("Key").ToString();

            // Deger silme islemi.
            Registry.CurrentUser.DeleteValue("Key");

            /*                                               */

            //Subkey(Klasor) olusturma islemi
            Registry.CurrentUser.CreateSubKey("UdemyProjesi", true);

            //Subkey icerisine deger ekleme
            RegistryKey udemyProjesi = Registry.CurrentUser.OpenSubKey("UdemyProjesi");
            udemyProjesi.SetValue("HardDiskSerialNumber", "123456789");

            //Subkey icerisindeki degeri okuma
            string hDSN = udemyProjesi.GetValue("HardDiskSerialNumber").ToString();

            //Subkey icerisindeki degerleri listeleme
            RegistryKey udemyProjesi2 = Registry.CurrentUser.OpenSubKey("UdemyProjesi",false);
            udemyProjesi2.GetValueNames().ToList().ForEach(i => Console.WriteLine($"Key: {i} Value: {udemyProjesi2.GetValue(i)}"));

            //Subkey silme islemi
            Registry.CurrentUser.DeleteSubKey("UdemyProjesi");

            /*                                               */

            //WMI ile -> Bilgisayarın disk serı numarasını alıp kaydetme
            string disk = "C";
            ManagementObject diskManagement = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + disk + ":\"");
            diskManagement.Get();
            Registry.CurrentUser.OpenSubKey("UdemyProjesi", true).SetValue("LogicalDiskSerialNumber", diskManagement["VolumeSerialNumber"].ToString());

            //WMI ile -> Ethernet kartinin MAC adresini alıp kaydetme
            ManagementClass M = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection MOC = M.GetInstances();
            foreach (var item in MOC)
            {
                if((bool)item["IPEnabled"])
                {
                    Registry.CurrentUser.OpenSubKey("UdemyProjesi", true).SetValue("MACAddress", item["MACAddress"].ToString());

                }
            }

        }
    }
}
