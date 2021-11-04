using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class ProductDetailDto:IDto//boyle bir tabo ver tabanında yok biz kendımız olusturduk.ıkı tabloyu birleştirrerek  data transtfer objesi olusturduk. 
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public short UnitInStock { get; set; }



    }
}
