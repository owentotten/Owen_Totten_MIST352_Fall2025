using System.Runtime.ExceptionServices;

namespace HW1
//Owen Totten
//MIST351 Fall25
//HW1
//This program promts the user to enter 4 products with their serial number, price, quantity, and category and displays the imput in a table format.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of product 1.");
            //Promts the user to enter the name of product 1
            string strName1;
            //Gives the 1 products name a variable
            strName1= Console.ReadLine();
            //allows user to imput data
          
            string capitalizedStrName1 = char.ToUpper(strName1[0]) + strName1.Substring(1).ToLower();
            //Capitalizes the first letter of the product name and makes the rest lowercase


            Console.WriteLine("Please enter the serial number for product 2.");
            //Promts the user to enter the serial# of product 1
            string serial1= Console.ReadLine();
            //allows the user to imput data
            Console.WriteLine("Please enter the price of product 1.");
            //Promts the user to enter the price of product 1
            string price1= Console.ReadLine();
            Console.WriteLine("Please enter the quantity for product 1.");
            //Promts the user to enter the quantity of product 1
                        string quantity1= Console.ReadLine();
            //allows the user to imput data
            Console.WriteLine("Please enter the category for product 1.");
            //Promts the user to enter the category of product 1
            string category1= Console.ReadLine();
            //allows the user to imput data
            string capitalizedStrCat1 = char.ToUpper(category1[0]) + category1.Substring(1).ToLower();
            //Capitalizes the first letter of the product name and makes the rest lowercase
            string total1 = (Convert.ToDouble(price1) * Convert.ToDouble(quantity1)).ToString();
            //Calculates the total price of product 1 by multiplying price by quantity and converts it to a string


            Console.WriteLine("Please enter the name of product 2.");
            //Promts the user to enter the name of product 2
            string strName2;
            //Gives the 2nd products name a variable
            strName2 = Console.ReadLine();
            string capitalizedStrName2 = char.ToUpper(strName2[0]) + strName2.Substring(1).ToLower();
            //Capitalizes the first letter of the product name and makes the rest lowercase
            //allows user to imput data
            Console.WriteLine("Please enter the serial numer for product 2.");
            //Promts the user to enter the serial# of product 2
            string serial2 = Console.ReadLine();
            //allows the user to imput data
            Console.WriteLine("Please enter the price of product 2.");
            //Promts the user to enter the price of product 2
            string price2 = Console.ReadLine();
            Console.WriteLine("Please enter the quantity for product 2.");
            //Promts the user to enter the quantity of product 2
            string quantity2 = Console.ReadLine();
            //allows the user to imput data
            Console.WriteLine("Please enter the category for product 2.");
            string category2 = Console.ReadLine();
            //allows the user to imput data
            string capitalizedStrCat2 = char.ToUpper(category1[0]) + category1.Substring(1).ToLower();
            //Capitalizes the first letter of the product name and makes the rest lowercase

            //Promts the user to enter the category of product 2
            string total2 = (Convert.ToDouble(price2) * Convert.ToDouble(quantity2)).ToString();
            //Calculates the total price of product 2 by multiplying price by quantity and converts it to a string

            Console.WriteLine("Please enter the name of product 3.");
            //Promts the user to enter the name of product 3
            string strName3;
            //Gives the 3nd products name a variable
            strName3 = Console.ReadLine();
            //allows user to imput data
            string capitalizedStrName3 = char.ToUpper(strName3[0]) + strName3.Substring(1).ToLower();
            //Capitalizes the first letter of the product name and makes the rest lowercase
            Console.WriteLine("Please enter the serial numer for product 3.");
            //Promts the user to enter the serial# of product 3
            string serial3 = Console.ReadLine();
            //allows the user to imput data
            Console.WriteLine("Please enter the price of product 3.");
            //Promts the user to enter the price of product 3
            string price3 = Console.ReadLine();
            Console.WriteLine("Please enter the quantity for product 3.");
            //Promts the user to enter the quantity of product 3
            string quantity3 = Console.ReadLine();
            //allows the user to imput data
            Console.WriteLine("Please enter the category for product 3.");
            //Promts the user to enter the category of product 3
            string category3 = Console.ReadLine();
            //allows the user to imput data
            string capitalizedStrCat3 = char.ToUpper(category3[0]) + category3.Substring(1).ToLower();
            //Capitalizes the first letter of the product name and makes the rest lowercase
            string total3 = (Convert.ToDouble(price3) * Convert.ToDouble(quantity3)).ToString();
            //Calculates the total price of product 3 by multiplying price by quantity and converts it to a string
            Console.WriteLine("Please enter the name of product 4.");
            //Promts the user to enter the name of product 4
            string strName4;
            //Gives the 4nd products name a variable
            strName4 = Console.ReadLine();
            //allows user to imput data
            string capitalizedStrName4 = char.ToUpper(strName4[0]) + strName4.Substring(1).ToLower();
            Console.WriteLine("Please enter the serial numer for product 4.");
            //Promts the user to enter the serial# of product 4
            string serial4 = Console.ReadLine();
            //allows the user to imput data
            Console.WriteLine("Please enter the price of product 4.");
            //Promts the user to enter the price of product 4
            string price4 = Console.ReadLine();
            Console.WriteLine("Please enter the quantity for product 4.");
            //Promts the user to enter the quantity of product 4
            string quantity4 = Console.ReadLine();
            //allows the user to imput data
            Console.WriteLine("Please enter the category for product 4.");
            //Promts the user to enter the category of product 4
            string category4 = Console.ReadLine();
            //allows the user to imput data
            string capitalizedCat4 = char.ToUpper(category4[0]) + category4.Substring(1).ToLower();
            //Capitalizes the first letter of the product name and makes the rest lowercase
            string total4 = (Convert.ToDouble(price4) * Convert.ToDouble(quantity4)).ToString();
            //Calculates the total price of product 4 by multiplying price by quantity and converts it to a string


            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|| {0,-20} || {1,-20} || {2,-20} || {3,-20} || {4,-20} || {5,-20} || ", "Product Name", "Serial Number", "Price", "Quantity", "Category", "Total Price");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|| {0,-20} || {1,-20} || {2,-20} || {3,-20} || {4,-20} || {5,-20} || ", $"{capitalizedStrName1}", $"{serial1}", $"{price1}", $"{quantity1}", $"{capitalizedStrCat1}", $"{total1}");
            //displays user imput onto table
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|| {0,-20} || {1,-20} || {2,-20} || {3,-20} || {4,-20} || {5,-20} || ", $"{strName2}", $"{serial2}", $"{price2}", $"{quantity2}", $"{category2}", $"{price2}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|| {0,-20} || {1,-20} || {2,-20} || {3,-20} || {4,-20} || {5,-20} || ", $"{strName3}", $"{serial3}", $"{price3}", $"{quantity3}", $"{category3}", $"{price3}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|| {0,-20} || {1,-20} || {2,-20} || {3,-20} || {4,-20} || {5,-20} || ", $"{strName4}", $"{serial4}", $"{price4}", $"{quantity4}", $"{category4}", $"{price4}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
        }//creates a table and displays all user imput in the table

    }
}
