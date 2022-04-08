using Karnosh.Interface;
using Karnosh.Models;
using Karnosh.ViewModle;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Karnosh.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IBaseRepository<Video> _video;
        public VideoController(IBaseRepository<Video> video)
        {
            _video = video;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //Ok(_video.FindAll(b=>b.Name.Contains("a"),new[] {"Year"},null,null,c=>c.Id,OrderBy.Descending));
            return Ok(_video.FindAll(filter: null, new[] { ModelsNames.Generes,ModelsNames.Year,ModelsNames.Duration}, null, null, c => c.Id, OrderBy.Descending));
        }
        [HttpPost]
        public IActionResult Index(VideoModle videoModle)
        {
            //Ok(_video.FindAll(b=>b.Name.Contains("a"),new[] {"Year"},null,null,c=>c.Id,OrderBy.Descending));
            return Ok(_video.AddVideoAll(videoModle));
        }

    }
}
