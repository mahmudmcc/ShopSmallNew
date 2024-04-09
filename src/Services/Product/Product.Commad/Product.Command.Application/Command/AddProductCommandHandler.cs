using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.Command.Application.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Command.Application.Command;

public class AddProductCommandHandler : IRequestHandler<AddProductCommand, IActionResult>
{
    private readonly IProductRepository _productRepository;

    public AddProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<IActionResult> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product.Command.Domain.Entities.Product {
            Id = Guid.NewGuid().ToString(),
            Name = request.Name,
            Description = request.Description,
            Price = request.Price
        };

        var result = _productRepository.AddProduct(product);
        return Task.FromResult.;
    }
}
