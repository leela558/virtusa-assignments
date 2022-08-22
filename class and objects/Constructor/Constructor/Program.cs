namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch1;
            do
            {
                Console.WriteLine("***Select one***");
                Console.WriteLine("aa. Person Program");
                Console.WriteLine("bb. Building program");
                Console.WriteLine("cc. Shape Program");
                Console.WriteLine("dd. Exit");

                ch1 = Console.ReadLine();
                switch (ch1)
                {
                    case "aa":

                        personProgram();
                        break;
                    case "bb":

                        BuildingProgram();
                        break;
                    case "cc":
                        shape();
                        break;


                }
            } while (ch1 != "dd");
        }
        private static void BuildingProgram()
        {

            Console.WriteLine("Enter type of building(flat/villa)");
            string buildingType = Console.ReadLine();
            Console.WriteLine("Enter Capacity (1/2/3/4BHK):");
            string buildingCapacity = Console.ReadLine();

            Console.WriteLine("Enter Dimensions: ");
            string Dimensions = Console.ReadLine();

            Building building;

            if (string.Equals(buildingType, "flat", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Enter Floor Number: ");
                int floorNo = Convert.ToInt32((Console.ReadLine()));
                Console.WriteLine("Date of completion:");
                string DateOfCompletion = Console.ReadLine();

                building = new Building(buildingType, buildingCapacity, Dimensions, DateOfCompletion, floorNo);
            }
            else
            {
                Console.WriteLine("Enter Dimensions of property (e.g 100x100): ");
                string propDimension = Console.ReadLine();
                Console.WriteLine("Date of completion:");
                string DateOfCompletion = Console.ReadLine();

                building = new Building(buildingType, buildingCapacity, Dimensions, DateOfCompletion, propDimension);
            }

            building.showData();
        }

        private static void personProgram()
        {
            char ch2;
            do
            {
                Console.WriteLine("a. first name, last name, email, DoB");
                Console.WriteLine("b. first name, last name, email");
                Console.WriteLine("c. first name, last name, DoB ");
                Console.WriteLine("d. Exit");
                ch2 = (char)char.Parse(Console.ReadLine());

                switch (ch2)
                {
                    case 'a':
                        Console.WriteLine("Eneter first name");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Enter Last name");
                        string lname = Console.ReadLine();
                        Console.WriteLine("Enter email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter Dob");
                        string Dob = Console.ReadLine();
                        Person person = new Person(fname, lname, email, DateOnly.Parse(Dob));
                        person.Display();
                        break;

                    case 'b':
                        Console.WriteLine("Eneter first name");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter Last name");
                        lname = Console.ReadLine();
                        Console.WriteLine("Enter email");
                        email = Console.ReadLine();
                        person = new Person(fname, lname, email);
                        person.Display();
                        break;

                    case 'c':

                        Console.WriteLine("Eneter first name");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter Last name");
                        lname = Console.ReadLine();
                        Console.WriteLine("Enter Dob");
                        Dob = Console.ReadLine();
                        person = new Person(fname, lname, DateOnly.Parse(Dob));
                        person.Display();

                        break;


                }

            } while (ch2 == 'd');

        }

        private static void shape()
        {
            Shapes shape = new Shapes();
            double pi = 3.14;
            Console.WriteLine("Enter a radius Value:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of circle:" + shape.Area(pi, r));
            Console.WriteLine("Enter a length and breadth:");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Triangle:" + shape.Area(l, b));
            Console.WriteLine("Enter a side value:");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Square:" + shape.Area(s));
        }
       
    }
}