using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using UnitTestLab1.ODT;
using UnitTestLab1.Stub;

namespace UnitTestLab1.Service.Tests
{
    [TestClass()]
    public class SubOrderServiceTests
    {
        [TestMethod()]
        public void SyncBookOrdersTest_有三筆Book會新增三次()
        {
            var mockBookDao = Substitute.For<IBookDao>();

            var subOrderService = new StubOrderService(mockBookDao);

            subOrderService.SyncBookOrders();

            mockBookDao.Received(3).Insert(Arg.Any<Order>());
        }
    }
}