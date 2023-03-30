using AutoKaMapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AutoKaMapper.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class MapperCheckController : ControllerBase
    {
      
        private readonly ILogger<MapperCheckController> _logger;
        private readonly IMapper _mapper;

        public MapperCheckController(ILogger<MapperCheckController> logger,IMapper mapper)
        {
            _logger = logger;
            _mapper =mapper;
        }


        [HttpGet]
        [Route("damnbro")]
        public NewModel AlmostSimilarModel()
        {
            PuranaModel studentDTO = new PuranaModel()
            {
                Name = "Golub",
                Age = 68,
                City = "wuhan"
            };

            var mappedvalue= _mapper.Map<NewModel>(studentDTO);

            return mappedvalue;
        }


        [HttpGet]
        [Route("differnt")]
        public FutureModel DifferentModelMapper()
        {
            PuranaModel studentDTO = new PuranaModel()
            {
                Name = "Golub",
                Age = 68,
                City = "wuhan"
            };

            var mappedvalue = _mapper.Map<FutureModel>(studentDTO);// adds Address = null as its mapped correctly

            return mappedvalue;
        }


    }
}
