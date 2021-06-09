using System.Collections.Generic;
using mvc.Models.Entities;

namespace mvc.Data.Models.Interfaces
{
    public interface IMyObjectRepository
    {
        IEnumerable<MyObject> GetAll();
        bool DatabaseIsAvailable();
    }
}