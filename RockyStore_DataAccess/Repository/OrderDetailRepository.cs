using RockyStore_DataAccess.Data;
using RockyStore_DataAccess.Repository.IRepository;
using RockyStore_Models;

namespace RockyStore_DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetail.Update(obj);
        }
    }
}
