using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class LicensePlate
    {

        public void LicensePlate(string licenseNumber, int groupLength)
        {
            string license = string.Join("",licenseNumber.Split('-'));
            license = reverse(license);   //right to left
            string newLicense = "";

            for(int  i = 0; i < license.Length; i+=groupLength)
            {
                if(i+groupLength<license.Length)
                {
                    newLicense = newLicense+'-'+license.Substring(i,groupLength);
                }
                else
                {
                    newLicense += "-"+license.Substring(i);
                }

            }
            newLicense = newLicense.Substring(1);  // removing the "-" at begining of string
            newLicense = reverse(newLicense);
            Console.WriteLine(newLicense.ToUpper());
        }
        public string reverse(string s)
        {
            string result = "";
            for(int i=s.Length-1; i>=0;i--)
            {
                 result+= s[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            LicensePlate p = new();

            Console.WriteLine("Enter your License plate groupLength");
            string licensePlateNumber = Console.ReadLine();
            Console.WriteLine("Enter grouping groupLength");
            int groupingNumber = Convert.ToInt32(Console.ReadLine());
            p.LicensePlate(licensePlateNumber, groupingNumber);
            p.LicensePlate("5F3Z-2e-9-w", 4);
            p.LicensePlate("2-5g-3-J", 2);

            p.LicensePlate("2-4A0r7-4k", 3);

            p.LicensePlate("nlj-206-fv", 3);
        }
    }
}
