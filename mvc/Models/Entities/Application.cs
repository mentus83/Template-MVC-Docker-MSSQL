using System;

namespace mvc.Models.Entities
{
    public class NhApplcation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public DateTime InstallationDate { get; set; }
    }
}