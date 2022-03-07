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
        [ProducesResponseType(typeof(List<Headerul>), StatusCodes.Status200OK)]
        public List<Headerul> GetHeader()
        {
            return headerService.GetHeader();
        }

        [HttpPost]
        public bool CreateHeader(Headerul headerul)
        {
            return headerService.CreateHeader(headerul);
        }


        [HttpPut]
        [Route("Update/{id}")]
        public bool UpdateHeader(Headerul headerul)
        {
            return headerService.UpdateHeader(headerul);
        }



        [HttpDelete]
        [Route("Delete")]
        public string DeleteHeader()
        {
            return headerService.DeleteHeader();
        }


        //IMAGE
        [HttpPost]
        [Route("Upload")]
        public Headerul Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("Images", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                //DataBase
                Headerul header = new Headerul();
                header.Logo = fileName;
                return header;
            }

            catch (Exception e)
            {
                return null;
            }
        }
    }
}
