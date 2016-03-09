using PageSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExpectedObjects;

namespace PageSum.Tests
{
    [TestClass()]
    public class myPageSumTests
    {
        [TestMethod()]
        public void CostTotalTest_11筆測試資料每3筆加總一次cost回傳結果陣列()
        {
            // arrange
            var target = new myPageSum();
            var obj = new List<SourceData> {
                new SourceData { Id=1,Cost=1,Revenue=11,SellPrice=21},
                new SourceData { Id=2,Cost=2,Revenue=12,SellPrice=22},
                new SourceData { Id=3,Cost=3,Revenue=13,SellPrice=23},
                new SourceData { Id=4,Cost=4,Revenue=14,SellPrice=24},
                new SourceData { Id=5,Cost=5,Revenue=15,SellPrice=25},
                new SourceData { Id=6,Cost=6,Revenue=16,SellPrice=26},
                new SourceData { Id=7,Cost=7,Revenue=17,SellPrice=27},
                new SourceData { Id=8,Cost=8,Revenue=18,SellPrice=28},
                new SourceData { Id=9,Cost=9,Revenue=19,SellPrice=29},
                new SourceData { Id=10,Cost=10,Revenue=20,SellPrice=30},
                new SourceData { Id=11,Cost=11,Revenue=21,SellPrice=31}
            };
            var page = 3;
            var expected = new List<int> { 6, 15, 24, 21 };

            // act
            var actual = target.CostTotal(page, obj);

            // assert
            expected.ToExpectedObject().ShouldEqual(actual);

        }

        [TestMethod()]
        public void RevenueTotalTest_9筆測試資料每4筆加總一次revenue回傳結果陣列()
        {
            // arrange
            var target = new myPageSum();
            var obj = new List<SourceData> {
                new SourceData { Id=1,Cost=1,Revenue=11,SellPrice=21},
                new SourceData { Id=2,Cost=2,Revenue=12,SellPrice=22},
                new SourceData { Id=3,Cost=3,Revenue=13,SellPrice=23},
                new SourceData { Id=4,Cost=4,Revenue=14,SellPrice=24},
                new SourceData { Id=5,Cost=5,Revenue=15,SellPrice=25},
                new SourceData { Id=6,Cost=6,Revenue=16,SellPrice=26},
                new SourceData { Id=7,Cost=7,Revenue=17,SellPrice=27},
                new SourceData { Id=8,Cost=8,Revenue=18,SellPrice=28},
                new SourceData { Id=9,Cost=9,Revenue=19,SellPrice=29},
            };
            var page = 4;
            var expected = new List<int> { 50, 66, 19 };

            // act
            var actual = target.RevenueTotal(page, obj);

            // assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}