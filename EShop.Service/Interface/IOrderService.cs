using Eshop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IOrderService
    {
        Order GetDetailsForOrder(Guid? id);
        void CreateNewOrder(Order b);
        void UpdateExistingOrder(Order b);
        void DeleteOrder(Guid id);
    }
}
