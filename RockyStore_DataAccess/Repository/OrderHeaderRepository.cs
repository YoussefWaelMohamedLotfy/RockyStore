using RockyStore_DataAccess.Data;
using RockyStore_DataAccess.Repository.IRepository;
using RockyStore_Models;

namespace RockyStore_DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeader.Update(obj);
        }
    }
}
