using Product.Command.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Command.Application.Contracts.Repository;

public interface IProductRepository
{
    Task<int> AddProduct(Product.Command.Domain.Entities.Product product);
        
}
