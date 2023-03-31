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


        static void Main(string[] args)
        {
            Program p = new();
            Console.WriteLine("Enter your name");
            string yourName = new string(Console.ReadLine());
            Console.WriteLine("Enter no of agents");
            int noOfAgents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter others names separated by space");
            string others = Console.ReadLine();
            p.driversLicense(yourName, noOfAgents, others);
            p.driversLicense("Eric", 2, "Adam Caroline Rebecca Frank");
            p.driversLicense("Zebediah", 1, "Bob Jim Becky Pat");
            p.driversLicense("Aaron", 3, "Jane Max Olivia Sam");
        }
    }
}