using PeopleViewer.SharedObjects;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonRepository.SQLServer
{
    public class SqlRepository : IPersonRepository
    {
        public TBusinessEntity Add<TBusinessEntity>(TBusinessEntity data) where TBusinessEntity : class, new()
        {
            throw new NotImplementedException();
        }

        public TBusinessEntity Delete<TBusinessEntity>(TBusinessEntity data) where TBusinessEntity : class, new()
        {
            throw new NotImplementedException();
        }

        public TBusinessEntity Get<TBusinessEntity>(int id) where TBusinessEntity : class, new()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TBusinessEntity> GetAll<TBusinessEntity>(Expression<Func<TBusinessEntity, bool>> criteria) where TBusinessEntity : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
