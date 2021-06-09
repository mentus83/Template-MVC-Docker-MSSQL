using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc.Data.Models.Interfaces;
using mvc.Models.Entities;

namespace mvc.Data.Models
{
    public class MyObjectRepository : IMyObjectRepository
    {
        private readonly MyObjectContext _ctx;

        public DbSet<MyObject> Applcations { get; set; }
        public MyObjectRepository(MyObjectContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<MyObject> GetAll () {
            return _ctx.MyObjects.ToList();
        }
        public bool DatabaseIsAvailable()
        {
            return _ctx.Database.CanConnect();
        }
    }
}