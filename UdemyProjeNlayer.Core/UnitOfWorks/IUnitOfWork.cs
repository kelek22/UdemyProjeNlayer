using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyProjeNlayer.Core.Repository;

namespace UdemyProjeNlayer.Core.UnitOfWork
{
    interface IUnitOfWork
    {
        IProductRepository products { get; }
        ICategoryRepository categories { get; }
        Task CommitAsync();
        void commit();
    }
}
