using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyProjeNlayer.Core.Model;

namespace UdemyProjeNlayer.Core.Services
{
   public  interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}
