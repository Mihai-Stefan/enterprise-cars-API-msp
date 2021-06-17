using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using cardata_api_v3.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace cardata_api_v3.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly CarContext _context;

        public FileController(CarContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult Post([FromForm] FileModel file)
        {
            Stream csvStream = new MemoryStream();
            file.FormFile.CopyTo(csvStream);
            //var reader = new StreamReader(csvStream);
            
                using (var reader = new StreamReader(csvStream))
                {
                    List<string> listA = new List<string>();
                    List<string> listB = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listA.Add(values[0]);
                        listB.Add(values[1]);
                    }
                }
            

            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);

                using (Stream stream = new FileStream(path, FileMode.Create))
                {
                    file.FormFile.CopyTo(stream);
                }

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
