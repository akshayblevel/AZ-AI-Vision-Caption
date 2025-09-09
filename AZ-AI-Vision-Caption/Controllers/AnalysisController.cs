using AZ_AI_Vision_Caption.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AZ_AI_Vision_Caption.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalysisController(IVisionService visionService) : ControllerBase
    {
        [HttpPost("Caption")]
        public async Task<IActionResult> GetCaption([FromBody] string imageUrl)
        {
            var json = await visionService.GetCaptionAsync(imageUrl);
            return Content(json, "application/json");
        }
    }
}
