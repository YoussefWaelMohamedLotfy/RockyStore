using Microsoft.AspNetCore.Mvc.Rendering;
using RockyStore_DataAccess.Data;
using RockyStore_DataAccess.Repository.IRepository;
using RockyStore_Models;
using RockyStore_Utility;
using System.Collections.Generic;
using System.Linq;

namespace RockyStore_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAllDropdownList(string obj)
        {
            if (obj == Constants.CategoryName)
            {
                return _db.Category.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }

            return null;
        }

        public void Update(Product obj)
        {
            _db.Product.Update(obj);
        }
    }
}
