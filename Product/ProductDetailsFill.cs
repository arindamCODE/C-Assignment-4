using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class ProductDetailsFill : IProduct, IComparer<ProductInfo>
    {
        public List<ProductGroup> ProductGroupFill()
        {
           ProductGroup pg1 = new ProductGroup()
           {
               ID = 1,
               Name = "Dairy"
           };

           ProductGroup pg2 = new ProductGroup()
           {
               ID = 2,
               Name = "Chocolate"
           };

           ProductGroup pg3 = new ProductGroup()
           {
               ID = 3,
               Name = "Juice"
           };

           ProductGroup pg4 = new ProductGroup()
           {
               ID = 4,
               Name = "Sweet"
           };

           List<ProductGroup> pGroup = new List<ProductGroup>(4);

           pGroup.Add(pg1);
           pGroup.Add(pg2);
           pGroup.Add(pg3);
           pGroup.Add(pg4);

           return pGroup;
        }

        public List<ProductInfo> ProductFill()
        {
           ProductInfo pi1 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 1,
               Name = "Go Cheese",
               Description = "Go Cheese 180g",
               rate = 115
           };

           ProductInfo pi2 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 2,
               Name = "Amul Cheese",
               Description = "Amul Cheese 210g",
               rate = 125
           }; 

           ProductInfo pi3 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Dairy"),
               ID = 3,
               Name = "Britania Cheese",
               Description = "Britania Cheese 200g",
               rate = 100
           };

           ProductInfo pi4 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Chocolate"),
               ID = 1,
               Name = "MilkyBar",
               Description = "MilkyBar 50g",
               rate = 40
           };
           
           ProductInfo pi5 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Chocolate"),
               ID = 2,
               Name = "KitKat",
               Description = "KitKat 10g",
               rate = 20
           };

           ProductInfo pi6 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Juice"),
               ID = 1,
               Name = "Tropicana",
               Description = "Tropicana 1ltr",
               rate = 100
           };

           ProductInfo pi7 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Juice"),
               ID = 2,
               Name = "Real Juice",
               Description = "Real Juice 1ltr",
               rate = 120
           };

           ProductInfo pi8 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Sweet"),
               ID = 1,
               Name = "Gulab Jamoon",
               Description = "Gulab Jamoon 200g",
               rate = 80
           };

           ProductInfo pi9 = new ProductInfo()
           {
               GroupID = FindGroupID.Find("Sweet"),
               ID = 2,
               Name = "Barfi",
               Description = "Barfi 100g",
               rate = 90
           };

           List<ProductInfo> pInfo = new List<ProductInfo>(9);

            pInfo.Add(pi1);
            pInfo.Add(pi2);
            pInfo.Add(pi3);
            pInfo.Add(pi4);
            pInfo.Add(pi5);
            pInfo.Add(pi6);
            pInfo.Add(pi7);
            pInfo.Add(pi8);
            pInfo.Add(pi9);

            return pInfo;
        }

        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public IEnumerable<ProductInfo> ProductSort(List<ProductInfo> pInfo)
        {
            ProductDetailsFill obj = new ProductDetailsFill();
            pInfo.Sort(obj);
            return pInfo;
        }

        public List<ProductInfo> ProductDelete1(List<ProductInfo> pInfo, int num)
        {    
            pInfo.RemoveAt(num);
            return pInfo;
        }

        public List<ProductInfo> ProductDelete2(List<ProductInfo> pInfo)
        {
            pInfo.RemoveAll(item => item.rate>100);
            return pInfo;
        }

        public List<ProductInfo> ProductDelete3(List<ProductInfo> pInfo, int st, int end)
        {
            pInfo.RemoveRange(st,end);
            return pInfo;
        }
    }
}