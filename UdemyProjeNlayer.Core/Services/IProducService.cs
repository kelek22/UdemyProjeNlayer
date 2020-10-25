using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyProjeNlayer.Core.Model;

namespace UdemyProjeNlayer.Core.Services
{
    public interface IProducService : IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productID);

        //  bool ControlInnerBarcode(Product product);

    }
}
