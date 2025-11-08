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
            list.Add(new SinhVien
            {
                maSV = "s03",
                tenSV = "Binh",
                tuoi = 19
            });
        }
        [HttpGet("GetAllSV")]
        public  IActionResult getAllSV()
        {
            var a = 6;
            var b = 7;
<<<<<<< HEAD
            if (a > 0 && b > 0)
=======
            if (a > 0)
>>>>>>> main
                Console.WriteLine(a + b);
            return Ok(list);
        }
        [HttpGet("GetById/{id}")]
        public IActionResult getById(string id)
        {
            var sv = list.FirstOrDefault(s => s.maSV == id);
            if(sv != null && sv.maSV.Length > 0)
                return Ok(sv);
            return BadRequest();
        }
    }
}
