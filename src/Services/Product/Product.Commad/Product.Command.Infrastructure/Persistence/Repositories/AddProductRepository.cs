using Product.Command.Application.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Command.Infrastructure.Persistence.Repositories;

public class AddProductRepository : IProductRepository
{
    public Task<int> AddProduct(Domain.Entities.Product product)
    {
        throw new NotImplementedException();
    }
}
