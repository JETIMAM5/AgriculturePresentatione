using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repository;
using DataAccesLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.EntityFramework
{
    public class EFAnnoncementsDal : GenericRepository<Annoncement>, IAnnoncementDal
    {
        public void AnnoncementStatusToFalse(int id)
        {
            using var context = new AgricultureContext();
            Annoncement p = context.Annoncements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void AnnoncementStatusToTrue(int id)
        {
           using var context = new AgricultureContext();
            Annoncement p = context.Annoncements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
