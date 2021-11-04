using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Core.DataAccess.EntityFrameWork.EfEntityRepositoryBase;

namespace Core.DataAccess.EntityFrameWork
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>//tconxtet orm e olan baglılıgı ortandan kaldırıyor daha sonra context cıkarsa hangısıyle calısaılacagı buradan gonderılır.
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new ()
    {
        public void Add(TEntity entity)
        {

            using (TContext context=new TContext())//hangi context ıle calısalıcaksa o gelir.
            {
               var AddedEntity=context.Entry(entity);
                AddedEntity.State = EntityState.Added;//entıtystate corela bilrkte geldi enum olarak gelmiştir.
                context.SaveChanges();



            }
        }

        public void Delete(TEntity entity)
        {

            using (TContext context=new TContext())
            {
                var DeletedEntity = context.Entry(entity);

                DeletedEntity.State = EntityState.Deleted;
                context.SaveChanges();




            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);//tek deger dondugu ıcın sınglordefoult olarak yazdık.

            }
          
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            using (TContext context =new TContext())
            {

                return filter == null ? context.Set<TEntity>().ToList()//filtre ıslemı yaoksa listeyi komle getir varsa filtelenmiş halini getir.
                    : context.Set<TEntity>().Where(filter).ToList();//listedonecek to list yaptık.


            }



        }

        public void Update(TEntity entity)
        {
            using (TContext context=new TContext())

            {

                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
    }
}
