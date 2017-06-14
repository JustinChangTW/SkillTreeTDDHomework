using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkillTreeHomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NSubstitute.Core;
using FluentAssertions;

namespace SkillTreeHomeWork.Tests
{
    [TestClass()]
    public class ShopTests
    {
        //        行為             結果
        //-----------------------------------
        //3筆一組，取Cost總和	    6,15,24,21
      	//4筆一組，取Revenue總和	50,66,60

        [TestMethod()]
        public void Shop_CalculateGroupResultTest_cost_3_result_6_15_24_21()
        {
            //Arrange  //環境設定
            
            ISummary<Product> summary = Substitute.For<ISummary<Product>>();
            List<Product> products = new List<Product>() {
                new Product { Id=1,Cost=1,Revenue=11,SellPrice=21},
                new Product { Id=2,Cost=2,Revenue=12,SellPrice=22},
                new Product { Id=3,Cost=3,Revenue=13,SellPrice=23},
                new Product { Id=4,Cost=1,Revenue=11,SellPrice=24},
                new Product { Id=5,Cost=1,Revenue=11,SellPrice=25},
                new Product { Id=6,Cost=1,Revenue=11,SellPrice=26},
                new Product { Id=7,Cost=1,Revenue=11,SellPrice=27},
                new Product { Id=8,Cost=1,Revenue=11,SellPrice=28},
                new Product { Id=9,Cost=9,Revenue=19,SellPrice=29},
                new Product { Id=10,Cost=10,Revenue=20,SellPrice=30},
                new Product { Id=11,Cost=11,Revenue=21,SellPrice=31}
            };

            var expected = new List<int>() { 6, 15, 24, 21 };

            summary.CalculateGroupResult("Cost", 3, products).Returns(expected);

            var target = new Shop(summary);

            //Act  //測試   actual
            var actual = target.Calculate("Cost", 3,products);

            //Assert  //驗證 AreEqual
            CollectionAssert.AreEqual(expected, actual);
        }

        //4筆一組，取Revenue總和	50,66,60
        [TestMethod()]
        public void Shop_CalculateGroupResultTest_Revenue_4_result_50_66_60()
        {
            //Arrange  //環境設定

            ISummary<Product> summary = Substitute.For<ISummary<Product>>();
            List<Product> product = new List<Product>() {
                new Product { Id=1,Cost=1,Revenue=11,SellPrice=21},
                new Product { Id=2,Cost=2,Revenue=12,SellPrice=22},
                new Product { Id=3,Cost=3,Revenue=13,SellPrice=23},
                new Product { Id=4,Cost=1,Revenue=11,SellPrice=24},
                new Product { Id=5,Cost=1,Revenue=11,SellPrice=25},
                new Product { Id=6,Cost=1,Revenue=11,SellPrice=26},
                new Product { Id=7,Cost=1,Revenue=11,SellPrice=27},
                new Product { Id=8,Cost=1,Revenue=11,SellPrice=28},
                new Product { Id=9,Cost=9,Revenue=19,SellPrice=29},
                new Product { Id=10,Cost=10,Revenue=20,SellPrice=30},
                new Product { Id=11,Cost=11,Revenue=21,SellPrice=31}
            };

            var expected = new List<int>() { 50, 66, 60 };

            summary.CalculateGroupResult("Revenue", 4, product).Returns(expected);

            var target = new Shop(summary);

            //Act  //測試   actual
            var actual = target.Calculate("Revenue", 4, product);

            //Assert  //驗證AreEqual()
            CollectionAssert.AreEqual(expected, actual);
        }

        //ArgumentExceptino
        [TestMethod()]
        public void Shop_CalculateGroupResultTest_Revenue_0_ArgumentException()
        {
            //Arrange  //環境設定

            ISummary<Product> summary = Substitute.For<ISummary<Product>>();
            List<Product> products = new List<Product>() {
                new Product { Id=1,Cost=1,Revenue=11,SellPrice=21},
                new Product { Id=2,Cost=2,Revenue=12,SellPrice=22},
                new Product { Id=3,Cost=3,Revenue=13,SellPrice=23},
                new Product { Id=4,Cost=1,Revenue=11,SellPrice=24},
                new Product { Id=5,Cost=1,Revenue=11,SellPrice=25},
                new Product { Id=6,Cost=1,Revenue=11,SellPrice=26},
                new Product { Id=7,Cost=1,Revenue=11,SellPrice=27},
                new Product { Id=8,Cost=1,Revenue=11,SellPrice=28},
                new Product { Id=9,Cost=9,Revenue=19,SellPrice=29},
                new Product { Id=10,Cost=10,Revenue=20,SellPrice=30},
                new Product { Id=11,Cost=11,Revenue=21,SellPrice=31}
            };

            var expected = new List<int>() { 50, 66, 60 };

            summary.CalculateGroupResult("Revenue", 0, products).Returns(expected);

            var target = new Shop(summary);

            //Act  //測試   actual
            //var actual = target.Calc("Revenue", 0, product);
            Action act = () => target.Calculate("Revenue", 0, products);
            
            //Assert  //驗證
            act.ShouldThrow<ArgumentException>();
        }

        //ArgumentExceptino
        [TestMethod()]
        public void Shop_CalculateGroupResultTest_Revenue_12_ArgumentException()
        {
            //Arrange  //環境設定

            ISummary<Product> summary = Substitute.For<ISummary<Product>>();
            List<Product> products = new List<Product>() {
                new Product { Id=1,Cost=1,Revenue=11,SellPrice=21},
                new Product { Id=2,Cost=2,Revenue=12,SellPrice=22},
                new Product { Id=3,Cost=3,Revenue=13,SellPrice=23},
                new Product { Id=4,Cost=1,Revenue=11,SellPrice=24},
                new Product { Id=5,Cost=1,Revenue=11,SellPrice=25},
                new Product { Id=6,Cost=1,Revenue=11,SellPrice=26},
                new Product { Id=7,Cost=1,Revenue=11,SellPrice=27},
                new Product { Id=8,Cost=1,Revenue=11,SellPrice=28},
                new Product { Id=9,Cost=9,Revenue=19,SellPrice=29},
                new Product { Id=10,Cost=10,Revenue=20,SellPrice=30},
                new Product { Id=11,Cost=11,Revenue=21,SellPrice=31}
            };

            var expected = new List<int>() { 50, 66, 60 };

            summary.CalculateGroupResult("Revenue", 12, products).Returns(expected);

            var target = new Shop(summary);

            //Act  //測試   actual
            //var actual = target.Calc("Revenue", 0, product);
            Action act = () => target.Calculate("Revenue", 12, products);

            //Assert  //驗證
            act.ShouldThrow<ArgumentException>();
        }

        //ArgumentExceptino
        [TestMethod()]
        public void Shop_CalculateGroupResultTest_Field_Not_Exist_ArgumentException()
        {
            //Arrange  //環境設定

            ISummary<Product> summary = Substitute.For<ISummary<Product>>();
            List<Product> products = new List<Product>() {
                new Product { Id=1,Cost=1,Revenue=11,SellPrice=21},
                new Product { Id=2,Cost=2,Revenue=12,SellPrice=22},
                new Product { Id=3,Cost=3,Revenue=13,SellPrice=23},
                new Product { Id=4,Cost=1,Revenue=11,SellPrice=24},
                new Product { Id=5,Cost=1,Revenue=11,SellPrice=25},
                new Product { Id=6,Cost=1,Revenue=11,SellPrice=26},
                new Product { Id=7,Cost=1,Revenue=11,SellPrice=27},
                new Product { Id=8,Cost=1,Revenue=11,SellPrice=28},
                new Product { Id=9,Cost=9,Revenue=19,SellPrice=29},
                new Product { Id=10,Cost=10,Revenue=20,SellPrice=30},
                new Product { Id=11,Cost=11,Revenue=21,SellPrice=31}
            };

            var expected = new List<int>() { 50, 66, 60 };

            summary.CalculateGroupResult("AAAAA", 0, products).Returns(expected);

            var target = new Shop(summary);

            //Act  //測試   actual
            //var actual = target.Calc("Revenue", 0, product);
            Action act = () => target.Calculate("AAAAA", 0, products);

            //Assert  //驗證
            act.ShouldThrow<ArgumentException>();
        }

    }
}