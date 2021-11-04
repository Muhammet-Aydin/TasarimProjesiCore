using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFrameWork
    //butun katmanlar ıcın ortak olan işlemleri buradan yoneteırırz.
{
    public interface EfEntityRepositoryBase
    {
        public interface IEntityRepository<T> where T: class,IEntity,new ()
        {
            void Add(T entity);

            void Update(T entity);
            void Delete(T entity);

            List<T>GetAll(Expression<Func<T, bool>> filter=null);//lambda exp kulnamak zorundayız geriye deger donene func kullandık  t tipinde gerye bool dondurucek.

            T Get(Expression<Func<T, bool>> filter);//aynı ıslemın lıste donecek halını yaptık.


        }
        //generic constraınt =>kısıtlyıcılar
        //class referans tip
        //Ientıty =>Ientıty olabilir veya Ientıty yı Implemente eden bşr nesne olabilir.

    
    }
}
