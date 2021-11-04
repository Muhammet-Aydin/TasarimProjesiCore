using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
  public  class Order:IEntity
    {

        public int OrderID { get; set; }
        public string EmployeeID { get; set; }

        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShipCity { get; set; }



    }
}
