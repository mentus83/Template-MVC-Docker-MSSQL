using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc.Data.Models.Interfaces;
using mvc.Models.Entities;
using mvc.Models.ViewModels;

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
            return _ctx.MyObjects
                        .Include(o => o.MyObjectItems)
                        .ToList();
        }
        public bool DatabaseIsAvailable()
        {
            return _ctx.Database.CanConnect();
        }
        public void AddEntity(object model)
        {
            _ctx.Add(model);
        }
        public void SaveAll()
        {
            _ctx.SaveChanges();
        }

        public MyObject GetById(int id)
        {
            return _ctx.MyObjects
                        .Include(o => o.MyObjectItems)
                        .Where(o => o.Id == id)
                        .FirstOrDefault();
        }
    }
}