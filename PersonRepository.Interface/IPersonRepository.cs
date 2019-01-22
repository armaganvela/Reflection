using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonRepository.Interface
{
    public interface IRepository
    {
        TBusinessEntity Add<TBusinessEntity>(TBusinessEntity data) where TBusinessEntity : class, new();
        TBusinessEntity Delete<TBusinessEntity>(TBusinessEntity data) where TBusinessEntity : class, new();
        IEnumerable<TBusinessEntity> GetAll<TBusinessEntity>(Expression<Func<TBusinessEntity, bool>> criteria) where TBusinessEntity : class, new();
        TBusinessEntity Get<TBusinessEntity>(int id) where TBusinessEntity : class, new();
    }
}
