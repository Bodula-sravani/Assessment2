namespace Assessment2
{
    internal class Program
    {

        public void driversLicense(string name , int noOfAgents , string waitingMembers)
        {
            string[] namesWaitingMembers = (waitingMembers+" "+name).Split(' ') ;
            Array.Sort(namesWaitingMembers);
            int noOfPeople = namesWaitingMembers.Length;
            int time = 0;
            bool breakLoop = false;
           for(int i=0;i<noOfPeople;i+=noOfAgents)
            {

                 time += 20;
                 for(int j=i;j<i+noOfAgents;j++)
                {
                    if (namesWaitingMembers[j] == name)
                    {
                        breakLoop = true;
                        break;
                    }
                }
                if (breakLoop) break;
            }
            Console.WriteLine($"Total time taken by {name}: {time}");
        }

        public void LicensePlate(string licenseNumber,int groupLength)
        {
            string license = string.Join("",licenseNumber.Split('-'));
            //string[] license = licenseNumber.Split('-');
            string newLicense="";
            for(int i=0;i<license.Length;i+=groupLength)
            {
                if (i == 0)
                {
                    newLicense = license.Substring(i, groupLength);
                }
                else if(i+groupLength >= license.Length)
                {
                    newLicense = newLicense + '-' + license.Substring(i);
                }
                else
                {
                    newLicense = newLicense + '-' + license.Substring(i,groupLength);
                }
            }

            Console.WriteLine(newLicense.ToUpper());

        }

        /*static void Main(string[] args)
        {
            Program p = new();
            *//*Console.WriteLine("Enter your name");
            string yourName = new string(Console.ReadLine());
            Console.WriteLine("Enter no of agents");
            int noOfAgents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter others names separated by space");
            string others = Console.ReadLine();
            p.driversLicense(yourName, noOfAgents, others);*//*
            p.driversLicense("Eric", 2, "Adam Caroline Rebecca Frank");
            p.driversLicense("Zebediah", 1, "Bob Jim Becky Pat");
            p.driversLicense("Aaron", 3, "Jane Max Olivia Sam");

            *//*Console.WriteLine("Enter your License plate groupLength");
            string licensePlateNumber = Console.ReadLine();
            Console.WriteLine("Enter grouping groupLength");
            int groupingNumber = Convert.ToInt32(Console.ReadLine());
            p.LicensePlate(licensePlateNumber, groupingNumber);*//*
            p.LicensePlate("5F3Z-2e-9-w", 4);
            p.LicensePlate("2-5g-3-J", 2);

            p.LicensePlate("2-4A0r7-4k", 3);

            p.LicensePlate("nlj-206-fv", 3);
        }*/
    }
}