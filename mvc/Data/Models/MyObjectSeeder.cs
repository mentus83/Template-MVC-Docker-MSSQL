using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using mvc.Models.Entities;

namespace mvc.Data.Models
{
    public class MyObjectSeeder
    {
        private readonly MyObjectContext _ctx;
        private readonly IWebHostEnvironment _webEnv;

        public MyObjectSeeder(MyObjectContext ctx, IWebHostEnvironment webEnv)
        {
            _ctx = ctx;
            _webEnv = webEnv;
        }

        public void Seed(){
            _ctx.Database.EnsureCreated();

            if (!_ctx.MyObjects.Any()) {
                var filePath = Path.Combine(_webEnv.ContentRootPath, "Data", "Samples", "data.json");
                var json = File.ReadAllText(filePath);
                var myObjects = JsonSerializer.Deserialize<IEnumerable<MyObject>>(json);

                _ctx.MyObjects.AddRange(myObjects);

                _ctx.SaveChanges();
            }
        }
    }
}