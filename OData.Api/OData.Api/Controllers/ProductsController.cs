using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OData.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OData.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        //https://localhost:44353/api/products?$select=name,Id
        //https://localhost:44353/api/products?$orderby=Id desc
        //https://localhost:44353/api/products?$orderby=price desc,stock asc
        //https://localhost:44353/api/products?$skip=2
        //https://localhost:44353/api/products?$skip=1&$top=1
        //https://localhost:44353/api/products?$filter=name eq 'lotr'
        //https://localhost:44306/odata/Products?$filter=Name eq 'KursunKalem'
        //https://localhost:44306/odata/Products?$filter=Stock eq 100
        //https://localhost:44306/odata/Products?$filter=Stock ne 100  
        //https://localhost:44306/odata/Products?$filter=Stock gt 100
        //https://localhost:44306/odata/Products?$filter=Stock ge 100
        //https://localhost:44306/odata/Products?$filter=Stock lt 700
        //https://localhost:44306/odata/Products?$filter=Stock add 50 eq 500
        //https://localhost:44306/odata/Products?$filter=Stock sub 50 eq 500
        //https://localhost:44306/odata/Products?$filter=Stock mul 50 eq 500
        //https://localhost:44306/odata/Products?$filter=Stock div 50 eq 500
        //https://localhost:44306/odata/Products?$filter=Created gt 1980-02-02
        //https://localhost:44306/odata/Products?$filter=startswith(Name,'k')
        //https://localhost:44306/odata/Products?$filter=endswith(Name,'k')
        //https://localhost:44306/odata/Products?$filter=startswith(Name,'k')
        //https://localhost:44306/odata/Products?$filter=length(Name) ge 15
        //https://localhost:44306/odata/Products?$filter=year(created) gt 2010
        //https://localhost:44306/odata/Products?$filter=month(created) gt 2010
        //https://localhost:44306/odata/Products?$filter=day(created) gt 2010
        public readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_context.products.AsQueryable());
        }

       



    }
}
