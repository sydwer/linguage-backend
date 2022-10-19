using linguage_backend.Data.Contexts;
using linguage_backend.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace linguage_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguageController : ControllerBase
    {
        private readonly ILogger<LanguageController> _logger;

        public LanguageController(ILogger<LanguageController> logger)
        {
            _logger = logger;
        }

        [Route("api/Language")]
        [HttpGet(Name = "GetLangauge")]
        public Language Get()
        {
            using (var db = new LinguageBackendContext())
            {
                var surveyCount = db.Languages.Count();
                return db.Languages.FirstOrDefault() ?? new Language();
            }

            return new Language();
        }
    }
}