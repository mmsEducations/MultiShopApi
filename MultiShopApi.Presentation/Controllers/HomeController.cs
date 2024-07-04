using Microsoft.AspNetCore.Mvc;

namespace MultiShopApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        //Kökdizin/api/Home
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Bismillahirrahmanirrahim";
        }

        //Kökdizin/api/Home/GetMessages
        [HttpGet]
        [Route("GetMessages")]
        public List<string> GetMessages()
        {
            List<string> datas = new List<string> { "Burak Asaf Sincar", "Yiği Ali Sincar", "Oktay Duman", "Ömer Dikişli", "Bektaş Baykara", "Nuraullah Dersteyok" };
            return datas;
        }


        //Kökdizin/api/Home/GetMessages
        [HttpGet]
        [Route("GetMessagesObject")]
        public List<Student> GetMessagesObject()
        {
            List<Student> datas = new List<Student>
            {
               new Student{ Name= "Burak Asaf Sincar" }, new Student{ Name = "Yiği Ali Sincar" } , new Student{ Name= "Oktay Duman" }
            };
            return datas;
        }
    }
}
