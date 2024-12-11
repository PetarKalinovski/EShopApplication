using Eshop.Domain.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain
{
    public class User: IdentityUser

    {
        public virtual ICollection<Order>? Order { get; set; }
    }
}
