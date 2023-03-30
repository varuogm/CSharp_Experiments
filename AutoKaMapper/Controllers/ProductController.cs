using AutoKaMapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AutoKaMapper.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("cast")]
        public fleet printertofleetCast()
        {

            List<printerProduct> printerproducts = new List<printerProduct>()
            {

                new printerProduct() {  Name = "HP Pavallion",SKU = "IYG35F4",PmoId = 3675},
                   new printerProduct() {  Name = "HP SC",SKU = "ASSF4",PmoId = 2434},
                      new printerProduct() {  Name = "HP Lajawab",SKU = "KHUB323",PmoId = 24324},
            };
      

            var mappedvalue = _mapper.Map<fleet>(printerproducts);

            return mappedvalue;
        }
    }
}
