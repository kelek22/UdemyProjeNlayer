using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyProjeNlayer.Core.Model;

namespace UdemyProjeNlayer.Core.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);


    }
}
