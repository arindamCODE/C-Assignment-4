using System;
using System.Collections.Generic;

namespace Product
{
    public class FindGroupID
    {
        public static int Find(string str)
        {
            try
            {
                ProductDetailsFill pdf = new ProductDetailsFill();

                List<ProductGroup> PG = pdf.ProductGroupFill();

                foreach (ProductGroup item in PG)
                {
                    if(item.Name == "Dairy" && item.Name == str)
                        return 1;
                    if(item.Name == "Chocolate" && item.Name == str)
                        return 2;
                    if(item.Name == "Juice" && item.Name == str)
                        return 3;
                    if(item.Name == "Sweet" && item.Name == str)
                        return 4;
                }    
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
    }
}