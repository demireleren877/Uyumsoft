using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOHService
    {
        List<OnlineOrHybrid> GetAll();
        OnlineOrHybrid GetById(int id);
        void AddOnlineOrHybrid(OnlineOrHybrid onlineOrHybrid);
        void DeleteOnlineOrHybrid(OnlineOrHybrid onlineOrHybrid);
        void UpdateOnlineOrHybrid(OnlineOrHybrid onlineOrHybrid);
    }
}
