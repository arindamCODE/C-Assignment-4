using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class Display
    {
        public void displaySortedProducts()
        {
            try
            {
                FindIndex objectFindIndex = new FindIndex();
                ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

                List<ProductGroup> productGroup = objectProductDetailsFill.ProductGroupFill();
                List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();
                IEnumerable<ProductInfo> product = objectProductDetailsFill.ProductSort(productInfo);

                foreach (ProductGroup item1 in productGroup)
                {
                    foreach (ProductInfo item2 in product)
                    {
                        if(item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Index: "+ (objectFindIndex.Find(item2.Name)) +  " || Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }

        public void DisplayAll()
        {
            try
            {
                FindIndex objectFindIndex = new FindIndex();
                ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

                List<ProductGroup> productGroup = objectProductDetailsFill.ProductGroupFill();
                List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();

                foreach(ProductGroup item1 in productGroup)
                {
                    foreach(ProductInfo item2 in productInfo)
                    {
                        if(item1.ID == item2.GroupID)
                        {   
                            Console.WriteLine("Index: " + (objectFindIndex.Find(item2.Name))+ " || Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }       
        }

        public void DisplayFound(string str)
        {
            if(str == null)
                Console.WriteLine("Please enter a string!");
            else    
            {
                try
                {
                    FindIndex objectFindIndex = new FindIndex();
                    ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

                    List<ProductGroup> productGroup = objectProductDetailsFill.ProductGroupFill();
                    List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();

                    var result = productInfo.Where(p => p.Name.ToUpper().Contains(str.ToUpper()));

                    if(result.Count() < 1)
                        Console.WriteLine("No Match!");
                    else
                    {
                        foreach (ProductGroup item1 in productGroup)
                        {
                            foreach (ProductInfo item2 in result)
                            {
                                if (item1.ID == item2.GroupID)
                                {
                                    Console.WriteLine("Index: " + (objectFindIndex.Find(item2.Name)) + " || Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                                }
                            }   
                        }
                    }

                }catch(Exception ex){
                    Console.WriteLine(ex.Message);
                }
            }
                        
        }

        public void DisplayAfterDeletion1(int num)
        {
            try
            {
                FindIndex objectFindIndex = new FindIndex();
                ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

                List<ProductGroup> productGroup = objectProductDetailsFill.ProductGroupFill();
                List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();

                List<ProductInfo> productNew = objectProductDetailsFill.ProductDelete1(productInfo,num);

                foreach (ProductGroup item1 in productGroup)
                {
                    foreach (ProductInfo item2 in productNew)
                    {
                        if (item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Index: " + (objectFindIndex.Find(item2.Name)) + " || Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }        
        }

        public void DisplayAfterDeletion2()
        {
            try
            {
                FindIndex objectFindIndex = new FindIndex();
                ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

                List<ProductGroup> productGroup = objectProductDetailsFill.ProductGroupFill();
                List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();

                List<ProductInfo> productNew = objectProductDetailsFill.ProductDelete2(productInfo);

                foreach (ProductGroup item1 in productGroup)
                {
                    foreach (ProductInfo item2 in productNew)
                    {
                        if (item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Index: " + (objectFindIndex.Find(item2.Name))+ " || Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }

        public void DisplayAfterDeletion3(int st, int end)
        {
            try
            {
                FindIndex objectFindIndex = new FindIndex();
                ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

                List<ProductGroup> productGroup = objectProductDetailsFill.ProductGroupFill();
                List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();

                List<ProductInfo> productNew = objectProductDetailsFill.ProductDelete3(productInfo, st, end);

                foreach (ProductGroup item1 in productGroup)
                {
                    foreach (ProductInfo item2 in productNew)
                    {
                        if (item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Index: " + (objectFindIndex.Find(item2.Name))+ " || Product Group Name: "+item1.Name+" || Product Name: "+item2.Name+" || Product Description: "+item2.Description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        } 
        public void DisplayAfterDeletion4(string productName)
        {
            try
            {
                FindIndex objectFindIndex = new FindIndex();
                ProductDetailsFill objectProductDetailsFill = new ProductDetailsFill();

                List<ProductGroup> productGroup = objectProductDetailsFill.ProductGroupFill();
                List<ProductInfo> productInfo = objectProductDetailsFill.ProductFill();

                List<ProductInfo> productNew = objectProductDetailsFill.ProductDelete4(productInfo, productName);

                foreach (ProductGroup item1 in productGroup)
                {
                    foreach (ProductInfo item2 in productNew)
                    {
                        if (item1.ID == item2.GroupID)
                        {
                            Console.WriteLine("Index: " + (objectFindIndex.Find(item2.Name)) + " || Product Group Name: " + item1.Name + " || Product Name: " + item2.Name + " || Product Description: " + item2.Description + " || Product Rate: " + item2.rate);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}