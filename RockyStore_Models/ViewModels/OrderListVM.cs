using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RockyStore_Models.ViewModels
{
    public class OrderListVM
    {
        public IEnumerable<OrderHeader> OrderHList { get; set; }

        public IEnumerable<SelectListItem> StatusList { get; set; }

        public string Status { get; set; }
    }
}
