using Entities.ResponseObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BadmintonMatching.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CityController : ControllerBase
    {

        private List<City> cities = new List<City>
    {
        new City { Id = 1, Name = "Số 3 Hòa Bình, Phường 3, Quận 11, TP. Hồ Chí Minh, Việt Nam" },
        new City { Id = 2, Name = "208 Nguyễn Hữu Cảnh, Phường 22, Quận Bình Thạnh, TP. Hồ Chí Minh, Việt Nam" },
        // Thêm thông tin về các thành phố khác
    };
        [HttpGet]
        [ProducesResponseType(typeof(SuccessObject<List<City>>), 200)]
        public IActionResult GetCities()
        {
            return Ok(new SuccessObject<List<City>> { Data = cities, Message = Message.SuccessMsg });
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(SuccessObject<City>), 200)]
        public IActionResult GetCity(int id)
        {
            var city = cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                return Ok(new SuccessObject<List<City?>>
                {
                    Message = "Không tìm thấy thành phố nào !"
                });
            }
            return Ok(new SuccessObject<City> { Data = city, Message = Message.SuccessMsg});
        }
    }
}
