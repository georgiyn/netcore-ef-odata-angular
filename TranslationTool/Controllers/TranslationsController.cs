using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TranslationTool.Models;

namespace TranslationTool.Controllers
{
    public class TranslationsController : ODataController
    {
        private readonly TranslationStoreContext _db;

        public TranslationsController(TranslationStoreContext context)
        {
            _db = context;
            if (context.Text.Any()) return;
            foreach (var b in DataSource.GetTranslations())
            {
                context.Text.Add(b);
            }
            context.SaveChanges();
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Text);
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_db.Text.FirstOrDefault(c => c.Id == key));
        }

        [EnableQuery]
        public IActionResult Post([FromBody]Text text)
        {
            _db.Text.Add(text);
            _db.SaveChanges();
            return Created(text);
        }
    }
}
