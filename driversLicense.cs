namespace Assessment2
{
    public class driversLicenseClass
    {
       /* You have to get a new driver's license. You show up at the office at the same time as four other people.
        * The office says they will see everyone in alphabetical order and it takes 20 minutes for them to process each new license. 
        * All of the agents are available now, and they can each see one customer at a time. 
        * How long will it take for you to walk out with your new license?
        Your input will be a string of your name, an integer of the number of available agents, and a string of the other four names separated by spaces others.*/
        public int driversLicense(string name , int noOfAgents , string waitingMembers)
        {
            //storing all the waiting members including you(name) in a string array
            string[] namesWaitingMembers = (waitingMembers+" "+name).Split(' ') ;
            //Sorting the array alphabetically
            Array.Sort(namesWaitingMembers);
            //getting total no of people
            int noOfPeople = namesWaitingMembers.Length;
            //to calculate and store time 
            int time = 0;    
            bool breakLoop = false;

            //loop through no of people by increments to no of agents after each loop - dividing as sets
            for (int iterate1=0;iterate1<noOfPeople;iterate1+=noOfAgents)
            {
                //incrementing time by 20 min (each set of ppl take 2 min time)
                time += 20;   
                //looping and checking if this set of ppl contains your name
                 for(int iterate2=iterate1;iterate2<iterate1+noOfAgents;iterate2++)    
                {

                    if (namesWaitingMembers[iterate2] == name)
                    {
                        //if true set breakloop = true and break from inner loop
                        breakLoop = true;
                        break;
                    }
                }
                 //checks if breakloop is true if so breaks out of outer loop
                if (breakLoop) break;
            }
            //Lastly total time taken is printed
            Console.WriteLine($"Total time taken by {name}: {time}");
            return time;
        }


        static void Main(string[] args)
        {
            //initialize the class to access methods
            driversLicenseClass p = new();

            //user defined input
            Console.WriteLine("Enter your name");
            string yourName = new string(Console.ReadLine());
            Console.WriteLine("Enter no of agents");
            int noOfAgents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter others names separated by space");
            string others = Console.ReadLine();
            p.driversLicense(yourName, noOfAgents, others);

            //Given test cases
            p.driversLicense("Eric", 2, "Adam Caroline Rebecca Frank");
            p.driversLicense("Zebediah", 1, "Bob Jim Becky Pat");
            p.driversLicense("Aaron", 3, "Jane Max Olivia Sam");
        }
    }
}