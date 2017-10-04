using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Display obj = new Display();
                int  index, start, end;
                string choice, choice1;
                string ch=null;
                string ch1 = null;
                string str;
                string product;

                do
                {

                        Console.WriteLine("Please select from the following:");
                        Console.WriteLine("1. Display the Contents");
                        Console.WriteLine("2. Sort the Contents on the basis of Product Name");
                        Console.WriteLine("3. Display the Contents by Searching on your own");
                        Console.WriteLine("4. Delete on your own choice and Display the contents");
                        choice = (Console.ReadLine());

                        switch(choice)
                        {
                                case "1": Console.WriteLine("-------------------------------------------------------");
                                        obj.DisplayAll();
                                        Console.WriteLine("-------------------------------------------------------");
                                        break;

                                case "2": Console.WriteLine("-------------------------------------------------------");
                                        obj.displaySortedProducts();
                                        Console.WriteLine("-------------------------------------------------------"); 
                                        break;

                                case "3": Console.WriteLine("-------------------------------------------------------");        
                                        Console.WriteLine("Please enter the Product Name or a part of the Product name to search with");
                                        str = Console.ReadLine();
                                        obj.DisplayFound(str);
                                        Console.WriteLine("-------------------------------------------------------");
                                        break;

                                case "4": do
                                        {
                                                Console.WriteLine("-------------------------------------------------------");
                                                Console.WriteLine("Please select from the following:");
                                                Console.WriteLine("1. Delete at a Particular index");
                                                Console.WriteLine("2. Delete items meeting certain conditions");
                                                Console.WriteLine("3. Delete a Range of Products");
                                                Console.WriteLine("4. Delete by a Product Name");
                                                Console.WriteLine("-------------------------------------------------------");
                                                choice1 = (Console.ReadLine());
                                                switch(choice1)
                                                {
                                                case "1": Console.WriteLine("Please enter the index:");
                                                          index = int.Parse(Console.ReadLine());
                                                          obj.DisplayAfterDeletion1(index);
                                                          break;
                                                case "2": Console.WriteLine("Deleting the Products having a rate greater than 100");
                                                          obj.DisplayAfterDeletion2();
                                                          break;
                                                case "3": Console.WriteLine("Please enter the Start and the End index");
                                                          start = int.Parse(Console.ReadLine());
                                                          end = int.Parse(Console.ReadLine());
                                                          obj.DisplayAfterDeletion3(start,end);
                                                          break;
                                                case "4": Console.WriteLine("Please enter a product name"); 
                                                          product = Console.ReadLine();
                                                          obj.DisplayAfterDeletion4(product);
                                                          break;

                                                default: Console.WriteLine("Sorry! Wrong Input");
                                                         break;        
                                                }
                                                Console.WriteLine("Would you like to Continue with the delete only(Yes/No) ?");
                                                ch1 = Console.ReadLine();
                                        }while(ch1.ToUpper() == "YES");
                                        break;

                                default: Console.WriteLine("Sorry! Wrong Input");
                                        break;        
                        }
                        Console.WriteLine("Would you like to Continue?(Yes/No)");
                        ch = Console.ReadLine();
                


                }while(ch.ToUpper() == "YES");                         
            }catch(Exception ex){
                    Console.WriteLine(ex.Message);
            }
        }
    }
}
