using System.Collections.Generic;
using mvc.Models.Entities;
using mvc.Models.ViewModels;

namespace mvc.Data.Models.Interfaces
{
    public interface IMyObjectRepository
    {
        IEnumerable<MyObject> GetAll();
        MyObject GetById(int id);
        bool DatabaseIsAvailable();
        void AddEntity(object model);
        void SaveAll();
    }
}