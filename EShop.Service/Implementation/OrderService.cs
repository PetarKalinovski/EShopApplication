using Eshop.Domain.Domain;
using EShop.Repository.Interface;
using EShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void CreateNewOrder(Order b)
        {
            orderRepository.Insert(b);
        }

        public void DeleteOrder(Guid id)
        {
            orderRepository.Delete(orderRepository.Get(id));
        }

        public Order GetDetailsForOrder(Guid? id)
        {
            return orderRepository.Get(id);
        }

        public void UpdateExistingOrder(Order b)
        {
            orderRepository.Update(b);
        }
    }
}
