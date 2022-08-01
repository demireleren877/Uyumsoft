using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILogService
    {
        List<Log> GetAll();
        Log GetById(int id);
        void AddLog(Log log);
        void DeleteLog(Log log);
        void UpdateLog(Log log);
    }
}
