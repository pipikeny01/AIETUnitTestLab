using System.Collections.Generic;
using UnitTestLab1.ODT;
using UnitTestLab1.Service;

namespace UnitTestLab1.Stub
{
    public class StubOrderService : OrderService
    {
        private readonly IBookDao _bookDao;

        public StubOrderService(IBookDao bookDao)
        {
            this._bookDao = bookDao;
        }

        protected override List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order{ ProductName = "Product1" , Type ="Book" , Price=500  },
                new Order{ ProductName = "Product2" , Type ="Book" , Price=400  },
                new Order{ ProductName = "Product3" , Type ="Food" , Price=100  },
                 new Order{ ProductName = "Product4" , Type ="Book" , Price=100  },
           };
        }

        protected override IBookDao GetBookDao()
        {
            return _bookDao;
        }
    }
}