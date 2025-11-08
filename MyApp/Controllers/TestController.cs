using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private List<SinhVien> list = new List<SinhVien>();
        public TestController()
        {
            list.Add(new SinhVien
            {
                maSV = "s1",
                tenSV = "Chien",
                tuoi = 18
            });
            list.Add(new SinhVien
            {
                maSV = "s02",
                tenSV = "Hai",
                tuoi = 21
            });
        }
        [HttpGet("GetAllSV")]
        public  IActionResult getAllSV()
        {
            return Ok(list);
        }
    }
}
