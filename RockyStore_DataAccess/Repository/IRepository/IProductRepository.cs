using Microsoft.AspNetCore.Mvc.Rendering;
using RockyStore_Models;
using System.Collections.Generic;

namespace RockyStore_DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);

        IEnumerable<SelectListItem> GetAllDropdownList(string obj);
    }
}
