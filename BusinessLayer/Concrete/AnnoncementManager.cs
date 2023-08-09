using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnoncementManager : IAnnoncementService
    {
        private readonly IAnnoncementDal _annoncementDal;

    public AnnoncementManager(IAnnoncementDal annoncementDal)
        {
            _annoncementDal = annoncementDal;
        }

        public void AnnoncementStatusToFalse(int id)
        {
            _annoncementDal.AnnoncementStatusToFalse(id);
        }

        public void AnnoncementStatusToTrue(int id)
        {
            _annoncementDal.AnnoncementStatusToTrue(id);
        }

        public void Delete(Annoncement t)
        {
           _annoncementDal.Delete(t);
        }

        public Annoncement GetByID(int id)
        {
           return _annoncementDal.GetByID(id);
           
        }

        public List<Annoncement> GetListAll()
        {
           return _annoncementDal.GetListAll();
        }

        public void Insert(Annoncement t)
        {
            _annoncementDal.Insert(t);
        }

        public void Update(Annoncement t)
        {
            _annoncementDal.Update(t);
        }
    }
}
