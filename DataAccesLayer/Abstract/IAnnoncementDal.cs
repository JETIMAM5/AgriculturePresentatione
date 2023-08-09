using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IAnnoncementDal:IGenericDal<Annoncement>
    {
        void AnnoncementStatusToTrue(int id);
        void AnnoncementStatusToFalse(int id);
           
    }
}
