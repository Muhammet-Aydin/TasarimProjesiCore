
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Category:IEntity// ımplemenete etmemizin sebebi bir veri tabanı objesı oladugunu soyleyecek bilgiyi tasır.burdakı paramtereye sadece ıentıty den alan classlar alsın  gbi?
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
