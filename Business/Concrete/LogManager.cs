using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LogManager : ILogService
    {
        ILogDal _logDal;

        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }

        public void AddLog(Log log)
        {
            _logDal.Add(log);
        }

        public void DeleteLog(Log log)
        {
            _logDal.Delete(log);
        }

        public List<Log> GetAll()
        {
            return _logDal.GetAll();
        }

        public Log GetById(int id)
        {
            return _logDal.Get(x => x.LogID == id);
        }

        public void UpdateLog(Log log)
        {
            _logDal.Update(log);
        }
    }
}
