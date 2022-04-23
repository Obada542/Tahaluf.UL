using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService _newsService)
        {
            this._newsService = _newsService;
        }

        [HttpPost]
        public bool CreateNews([FromBody] News news)
        {
            return _newsService.CreateNews(news);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteNews(int id)
        {
            return _newsService.DeleteNews(id);
        }

        [HttpPut]
        public bool UpdateNews([FromBody] News news)
        {
            return _newsService.UpdateNews(news);
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(List<News>), StatusCodes.Status200OK)]
        public List<News> GetAllNews()
        {
            return _newsService.GetAllNews();
        }
        [HttpPost]
        [Route("uploadImage")]
        public News UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                //var fullPath = Path.Combine(@"C:\\Users\\admin\\Downloads\\Tahaluf.UL.Angular-master\\src\\assets\\adminassets\\images\\", fileName);
                var fullPath = Path.Combine(@"C:\\Users\\admin\\Downloads\\Tahaluf.UL.angular\\src\\assets\\Images\\", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                News Item = new News();
                Item.Image = fileName;
                return Item;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
