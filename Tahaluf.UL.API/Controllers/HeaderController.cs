using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeaderController : ControllerBase
    {
        private readonly IHeaderService headerService;

        public HeaderController(IHeaderService _headerService)
        {
            headerService = _headerService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Headerul), StatusCodes.Status200OK)]
        public Headerul GetHeader()
        {
            return headerService.GetHeader();
        }

        [HttpPut]
        [Route("Update")]
        public bool UpdateHeader([FromBody]Headerul headerul)
        {
            return headerService.UpdateHeader(headerul);
        }
        [HttpPost]
        [Route("uploadImage")]
        public Headerul UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                //var fullPath = Path.Combine(@"C:\\Users\\admin\\Downloads\\Tahaluf.UL.Angular-master\\src\\assets\\adminassets\\images\\", fileName);
                var fullPath = Path.Combine(@"C:\\Users\\admin\\Downloads\\Tahaluf.UL.angular\\src\\assets\\adminassets\\images\\",fileName);
               //var fullPath = Path.Combine(@"C:\\Users\\admin\\Downloads\\Tahaluf.UL.angular\\src\\assets\\Images\\", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Headerul Item = new Headerul();
                Item.Logo = fileName;
                return Item;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
