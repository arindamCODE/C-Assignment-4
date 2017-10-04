using System;
using System.Collections.Generic;

namespace Product
{
    public class FindIndex
    { 
        int index;
        public int Find(string str)
        {
            ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

            List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();

            foreach(ProductInfo item in productInfo)
            {
                if(item.Name == str)
                {
                    this.index = productInfo.IndexOf(item);
                    break;
                }
            }
            return index;
        }
    }
}