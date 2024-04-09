using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Command.Application.Command;

public class AddProductCommand : IRequest<IActionResult>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
