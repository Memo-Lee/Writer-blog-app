using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;
using WriterDataAccess.Abstract;
using WriterDataAccess.Repositories;

namespace WriterDataAccess.Concrete.EntityFramework
{
    public class EfCoreContactRepository : GenericRepository<Contact>, IContact
    {
    }
}
