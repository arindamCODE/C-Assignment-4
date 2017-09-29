﻿using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Display obj = new Display();
                int choice, choice1, index, start, end;
                string ch=null;
                string ch1 = null;
                string str;

                do
                {
                        Console.WriteLine("Please select from the following:");
                        Console.WriteLine("1. Display the Contents");
                        Console.WriteLine("2. Sort the Contents on the basis of Product Name");
                        Console.WriteLine("3. Display the Contents by Searching on your own");
                        Console.WriteLine("4. Delete on your own choice and Display the contents");
                        choice = int.Parse(Console.ReadLine());

                        switch(choice)
                        {
                                case 1: Console.WriteLine("-------------------------------------------------------");
                                        obj.DisplayAll();
                                        break;

                                case 2: Console.WriteLine("-------------------------------------------------------");
                                        obj.displaySortedProducts(); 
                                        break;

                                case 3: Console.WriteLine("-------------------------------------------------------");        
                                        Console.WriteLine("Please enter the Product Name or a part of the Product name to search with");
                                        str = Console.ReadLine();
                                        obj.DisplayFound(str);
                                        break;

                                case 4: do
                                        {
                                                Console.WriteLine("-------------------------------------------------------");
                                                Console.WriteLine("Please select from the following:");
                                                Console.WriteLine("1. Delete at a Particular index");
                                                Console.WriteLine("2. Delete items meeting certain conditions");
                                                Console.WriteLine("3. Delete a Range of Products");
                                                choice1 = int.Parse(Console.ReadLine());
                                                switch(choice1)
                                                {
                                                case 1: Console.WriteLine("Please enter the index:");
                                                        index = int.Parse(Console.ReadLine());
                                                        obj.DisplayAfterDeletion1(index);
                                                        break;
                                                case 2: Console.WriteLine("Deleting the Products having a rate greater than 100");
                                                        obj.DisplayAfterDeletion2();
                                                        break;
                                                case 3: Console.WriteLine("Please enter the Start and the End index");
                                                        start = int.Parse(Console.ReadLine());
                                                        end = int.Parse(Console.ReadLine());
                                                        obj.DisplayAfterDeletion3(start,end);
                                                        break;
                                                default: Console.WriteLine("Sorry! Wrong Input");
                                                        break;        
                                                }
                                                Console.WriteLine("Would you like to Continue with the delete only ?");
                                                ch1 = Console.ReadLine();
                                        }while(ch1.ToUpper() == "YES");
                                        break;

                                default: Console.WriteLine("Sorry! Wrong Input");
                                        break;        
                        }
                        Console.WriteLine("Would you like to Continue?");
                        ch = Console.ReadLine();
                }while(ch.ToUpper() == "YES");                         
            }catch(Exception ex){
                    Console.WriteLine(ex.Message);
            }
        }
    }
}