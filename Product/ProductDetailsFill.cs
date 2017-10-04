using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class ProductDetailsFill : IProduct, IComparer<ProductInfo>
    {
        public List<ProductGroup> ProductGroupFill()
        {
           ProductGroup objectProductGroup1 = new ProductGroup()
           {
               ID = 1,
               Name = "Dairy"
           };

           ProductGroup objectProductGroup2 = new ProductGroup()
           {
               ID = 2,
               Name = "Chocolate"
           };

           ProductGroup objectProductGroup3 = new ProductGroup()
           {
               ID = 3,
               Name = "Juice"
           };

           ProductGroup objectProductGroup4 = new ProductGroup()
           {
               ID = 4,
               Name = "Sweet"
           };

           List<ProductGroup> productGroup = new List<ProductGroup>(4);

           productGroup.Add(objectProductGroup1);
           productGroup.Add(objectProductGroup2);
           productGroup.Add(objectProductGroup3);
           productGroup.Add(objectProductGroup4);

           return productGroup;
        }

        public List<ProductInfo> ProductFill()
        {
           ProductInfo objectProductInfo1 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 1,
               Name = "Go Cheese",
               Description = "Go Cheese 180g",
               rate = 115
           };

           ProductInfo objectProductInfo2 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 2,
               Name = "Amul Cheese",
               Description = "Amul Cheese 210g",
               rate = 125
           }; 

           ProductInfo objectProductInfo3 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 3,
               Name = "Britania Cheese",
               Description = "Britania Cheese 200g",
               rate = 100
           };

           ProductInfo objectProductInfo4 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Chocolate"),
               ID = 1,
               Name = "MilkyBar",
               Description = "MilkyBar 50g",
               rate = 40
           };
           
           ProductInfo objectProductInfo5 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Chocolate"),
               ID = 2,
               Name = "KitKat",
               Description = "KitKat 10g",
               rate = 20
           };

           ProductInfo objectProductInfo6 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Juice"),
               ID = 1,
               Name = "Tropicana",
               Description = "Tropicana 1ltr",
               rate = 100
           };

           ProductInfo objectProductInfo7 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Juice"),
               ID = 2,
               Name = "Real Juice",
               Description = "Real Juice 1ltr",
               rate = 120
           };

           ProductInfo objectProductInfo8 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Sweet"),
               ID = 1,
               Name = "Gulab Jamoon",
               Description = "Gulab Jamoon 200g",
               rate = 80
           };

           ProductInfo objectProductInfo9 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Sweet"),
               ID = 2,
               Name = "Barfi",
               Description = "Barfi 100g",
               rate = 90
           };

           List<ProductInfo> productInfo = new List<ProductInfo>(9);

            productInfo.Add(objectProductInfo1);
            productInfo.Add(objectProductInfo2);
            productInfo.Add(objectProductInfo3);
            productInfo.Add(objectProductInfo4);
            productInfo.Add(objectProductInfo5);
            productInfo.Add(objectProductInfo6);
            productInfo.Add(objectProductInfo7);
            productInfo.Add(objectProductInfo8);
            productInfo.Add(objectProductInfo9);

            return productInfo;
        }

        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public IEnumerable<ProductInfo> ProductSort(List<ProductInfo> productInfo)
        {
            ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();
            productInfo.Sort(objectProductDetailsFill);
            return productInfo;
        }

        public List<ProductInfo> ProductDelete1(List<ProductInfo> productInfo, int num)
        {    
            productInfo.RemoveAt(num);
            return productInfo;
        }

        public List<ProductInfo> ProductDelete2(List<ProductInfo> productInfo)
        {
            productInfo.RemoveAll(item => item.rate>100);
            return productInfo;
        }

        public List<ProductInfo> ProductDelete3(List<ProductInfo> productInfo, int start, int end)
        {
            productInfo.RemoveRange(start,end);
            return productInfo;
        }



        public List<ProductInfo> ProductDelete4(List<ProductInfo> productInfo, string productName)
        {
           productInfo.RemoveAll(item => item.Name.ToUpper() == productName.ToUpper());
           return productInfo;
        }
    }
}