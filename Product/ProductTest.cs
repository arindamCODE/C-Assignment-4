using System;
using System.Collections.Generic;

namespace Product
{
    public class ProductTest
    {
        public List<ProductInfo> testDisplayAll()
        {
            ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();
            List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();
            return productInfo;
        }


        public IEnumerable<ProductInfo> testSort()
        {
            ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();
            List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();
            IEnumerable<ProductInfo> product = objectProductDetailsFill.ProductSort(productInfo);
            return product;
        }
    }
}