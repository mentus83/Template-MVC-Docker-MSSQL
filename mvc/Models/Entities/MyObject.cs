using System;

namespace mvc.Models.Entities
{
    public class MyObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}