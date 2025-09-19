namespace Task3
{//Owen Totten
    //9/18/2025-9/19/2025
    //Task3
    //Mini POS System
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for number of items
            Console.WriteLine("How many items are in this order? ");
            int numberOfItems;
            if (!int.TryParse(Console.ReadLine(), out numberOfItems) || numberOfItems <= 0)
            {//displays an error message if the user types in a non-integer or negative number
                Console.WriteLine("[Error] Invalid number. Defaulting to 1 item.");
                numberOfItems = 1;
            }

            // Arrays for storing item data
            string[] names = new string[numberOfItems];
            decimal[] prices = new decimal[numberOfItems];
            int[] quantities = new int[numberOfItems];
            int[] stocks = new int[numberOfItems];
            decimal[] gross = new decimal[numberOfItems];
            decimal[] discount = new decimal[numberOfItems];
            decimal[] lineTotal = new decimal[numberOfItems];
            string[] reorder = new string[numberOfItems];

            Console.WriteLine("\n=== Mini POS: Enter item details ===");

            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine($"\nItem {i + 1}:");

                // Item Name
                Console.Write("  Enter product name: ");
                names[i] = Console.ReadLine();

                // Item Price
                Console.Write("  Enter unit price: ");
                if (!decimal.TryParse(Console.ReadLine(), out prices[i]) || prices[i] <= 0)
                {
                    Console.WriteLine("  [Error] Invalid price. Defaulting to 0.00");
                    prices[i] = 0.00m;
                }

                // Item Quantity
                Console.Write("  Enter quantity (integer): ");
                if (!int.TryParse(Console.ReadLine(), out quantities[i]) || quantities[i] <= 0)
                {
                    Console.WriteLine("  [Error] Invalid quantity. Defaulting to 0");
                    quantities[i] = 0;
                }

                // Item Stock
                Console.Write("  Enter stock on hand (integer): ");
                //if statement for invalid stock
                if (!int.TryParse(Console.ReadLine(), out stocks[i]) || stocks[i] < 0)
                {
                    Console.WriteLine("  [Error] Invalid stock. Defaulting to 0");
                    stocks[i] = 0;
                }

                // Gross
                gross[i] = prices[i] * quantities[i];

                // Bulk discount (flat $50 off if qty >= 10)
                if (quantities[i] >= 10)
                    discount[i] = 50.00m;
                else
                    discount[i] = 0.00m;

                // Line total
                lineTotal[i] = gross[i] - discount[i];

                // Reorder status
                if (stocks[i] < 5)
                    reorder[i] = "Yes";
                else
                    reorder[i] = "No";
            }

            // Order summary 
            Console.WriteLine("\n=== Order Summary ===");
            Console.WriteLine("{0,-15}{1,10}{2,8}{3,8}{4,12}{5,12}{6,14}{7,10}",
                              "Item", "Price", "Qty", "Stock", "Gross", "Discount", "Line Total", "Reorder");

            decimal subtotal = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                //Display output chart
                Console.WriteLine("{0,-15}{1,10:C}{2,8}{3,8}{4,12:C}{5,12:C}{6,14:C}{7,10}",
                                  names[i], prices[i], quantities[i], stocks[i],
                                  gross[i], discount[i], lineTotal[i], reorder[i]);

                subtotal += lineTotal[i];
            }

            // Totals
            decimal tax = subtotal * 0.06m;
            decimal grandTotal = subtotal + tax;
            // display totals after the chart
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine($"Subtotal:   {subtotal:C}");
            Console.WriteLine($"Tax (6%):   {tax:C}");
            Console.WriteLine($"Grand Total:{grandTotal:C}");
            Console.WriteLine("Done. Press Enter to exit");
        }
    }
}
   