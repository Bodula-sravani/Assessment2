using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assessment2
{
    public class LicensePlateClass
    {

        /*Create a solution that can format the dmv number
        into a plate number with correct grouping.
        The function input consists of string s and group length n.
         The output has to be upper case characters and digits.
        The new groups are made from right to left and connected by -.
         The original order of the dmv number is preserved. */
        public string LicensePlate(string licenseNumber, int groupLength)
        {
            //stroing the license number in a string after removing '-'
            string license = string.Join("",licenseNumber.Split('-'));
            //making the string right to left
            license = reverse(license);   
            //To store the result
            string newLicense = "";

            //Loop through license string
            for(int  iterate = 0; iterate < license.Length; iterate+=groupLength)
            {
                //Adding every next grouplength chars into the new license
                //if the length doesnt exceed total length select the substring from current index to groupLength of chars
                if(iterate+groupLength<license.Length)
                {
                    //adding '-' char at begining of each set of chars
                    newLicense = newLicense+'-'+license.Substring(iterate,groupLength);
                }
                //add the whatever remaining to new license
                else
                {
                    newLicense += "-"+license.Substring(iterate);
                }

            }
            // removing the "-" at the very begining(index 0) of string by using substring
            newLicense = newLicense.Substring(1);  
            //reversing the string to retrive the original order of license
            newLicense = reverse(newLicense);
            newLicense = newLicense.ToUpper();
            Console.WriteLine(newLicense);
            return newLicense;
        }

        //To make the string right to left - this function reverse is used
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
            LicensePlateClass p = new();

            //user defined input
            Console.WriteLine("Enter your License plate groupLength");
            string licensePlateNumber = Console.ReadLine();
            Console.WriteLine("Enter grouping groupLength");
            int groupingNumber = Convert.ToInt32(Console.ReadLine());
            p.LicensePlate(licensePlateNumber, groupingNumber);

            //given test cases
            p.LicensePlate("5F3Z-2e-9-w", 4);
            p.LicensePlate("2-5g-3-J", 2);
            p.LicensePlate("2-4A0r7-4k", 3);
            p.LicensePlate("nlj-206-fv", 3);
        }
    }
}
