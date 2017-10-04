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
                ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

                List<ProductGroup> productGroup = objectProductDetailsFill.ProductGroupFill();

                foreach (ProductGroup item in productGroup)
                {
                    if(str == item.Name)
                        return item.ID;
                }    
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
    }
}