
namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InheritanceProgram();
        }

        private static void InheritanceProgram()
        {
            Console.WriteLine("****Program for inheritance****");
            Console.WriteLine("Enter Following details");
            Console.WriteLine("Order ID:");
            int oid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Order Date(dd/mm/yyyy):");
            DateOnly orderDate = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Furniture Type(Cot/Chair)");
            string type = Console.ReadLine();

            /*while (!string.Equals(type, "COt", StringComparison.CurrentCultureIgnoreCase) ||
            !string.Equals(type, "Chair", StringComparison.CurrentCultureIgnoreCase)
            )*/
            /*while(type != "cot" || type !=  "chair")
            {
                Console.WriteLine("Furniture type must be cot or chair");
                type = Console.ReadLine();
            } ;*/

            Console.WriteLine("Qty:");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total Amount");
            int TotalAmt = Convert.ToInt32(Console.ReadLine());
            string PaymentMethod;
            /*do
            {*/
            Console.WriteLine("Card type(credit/Debit)");
            PaymentMethod = Console.ReadLine();

            /*} while (string.Equals(PaymentMethod, "Credit", StringComparison.CurrentCultureIgnoreCase) ||
            string.Equals(PaymentMethod, "Debit", StringComparison.CurrentCultureIgnoreCase)
            );*/

            if (string.Equals(type, "Chair", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Purpose(home/office)");
                string purpose = Console.ReadLine();

                Console.WriteLine("What is Type of chair(Wood/Steel/plastic): ");
                string chairType = Console.ReadLine();

                Console.WriteLine("Chair Material: ");
                string chairMaterial = Console.ReadLine();

                Console.WriteLine("Chair Rate: ");
                int rate = Convert.ToInt32(Console.ReadLine());

                Chair chair = new Chair(chairMaterial, rate, oid, orderDate, type, qty, TotalAmt, PaymentMethod);
                Console.WriteLine(chair.ToString());
            }
            else if (string.Equals(type, "cot", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Cot Type: ");
                string cotType = Console.ReadLine();

                Console.WriteLine("Cot Capacity: ");
                string cotCapacity = Console.ReadLine();

                Console.WriteLine("Cot Rate: ");
                int cotRate = Convert.ToInt32(Console.ReadLine());

                Cot cot = new Cot(cotType, cotCapacity, cotRate, oid, orderDate, type, qty, TotalAmt, PaymentMethod);

                Console.WriteLine(cot.Display());

            }
        }
    }
}