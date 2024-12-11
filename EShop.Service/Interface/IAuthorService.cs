using Eshop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    internal interface IAuthorService
    {
        Author GetDetailsForAuthor(Guid? id);
        void CreateNewAuthor(Author b);
        void UpdateExistingAuthor(Author b);
        void DeleteAuthor(Guid id);
    }
}
