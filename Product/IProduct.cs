using System;
using System.Collections.Generic;

namespace Product
{
    public interface IProduct
    {
        List<ProductGroup> ProductGroupFill();
        List<ProductInfo> ProductFill();
        IEnumerable<ProductInfo> ProductSort(List<ProductInfo> productInfo);
        List<ProductInfo> ProductDelete1(List<ProductInfo> productInfo, int num);
        List<ProductInfo> ProductDelete2(List<ProductInfo> productInfo);
        List<ProductInfo> ProductDelete3(List<ProductInfo> productInfo, int st, int end);
    }
}