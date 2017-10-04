using System;
using Xunit;
using Product;
using System.Collections.Generic;

namespace TestProduct
{
    public class ProductUnitTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            ProductTest objectProductTest = new ProductTest();

            //Act
            List<ProductInfo> result1 = objectProductTest.testDisplayAll();
            IEnumerable<ProductInfo> result2 = objectProductTest.testSort();
            int num1 = result1.Count;

            //Assert
            Assert.IsType<List<ProductInfo>>(result1);
            Assert.IsType<List<ProductInfo>>(result2);
            Assert.Equal(9,num1);
            
        }
    }
}
