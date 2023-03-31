using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class driversLicense
    {

        public void LicensePlate(string licenseNumber, int groupLength)
        {
            string newLicense="";   
            int i = 0;
            while (i<licenseNumber.Length)
            {
                string temp = "";
                while (temp.Length<groupLength && i<licenseNumber.Length)
                {
                    
                    if (!licenseNumber[i].Equals('-'))
                    {
                        
                        temp += licenseNumber[i];
                        i++;
                    }
                    else 
                    {
                        i++;
                    }
                }
                newLicense = newLicense + temp +'-';
            }
            newLicense = newLicense.Substring(0, newLicense.Length - 1);
            Console.WriteLine("new license:  "+ newLicense);


        }

        static void Main(string[] args)
        {
            driversLicense p = new();

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
