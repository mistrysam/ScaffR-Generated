namespace DemoApplication.Core.Interfaces.Service
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.ServiceModel;
    using Paging;
    using Validation;

    #endregion

    [ServiceContract]
    public interface IService<T>
    {
        [OperationContract]
        IQueryable<T> GetAll();

        [OperationContract]
        IQueryable<T> GetAllReadOnly();

        [OperationContract]
        T GetById(int id);

        [OperationContract]
        IValidationContainer<T> SaveOrUpdate(T entity);

        [OperationContract]
        void Delete(T entity);

        [OperationContract]
        IEnumerable<T> Find(Expression<Func<T, bool>> expression, int maxHits = 100);

        [OperationContract]
        IPage<T> Page(int page = 1, int pageSize = 10);
    }
}
