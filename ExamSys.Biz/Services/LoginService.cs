using ExamSys.Biz.Interfaces;
using ExamSys.Biz.Models;
using ExamSys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Services
{
    public class LoginService :ILoginService
    {
        ExamSysEntities _db = new ExamSysEntities();
        public bool ValidateCredentials(LoginModel model)
        {
            var rec = (from a in _db.Logins
                       where a.UserID == model.UserID
                       && a.Password == model.Password
                       select a).Count() > 0 ? true : false;
            if (rec)
                return true;
            else
                return false;
        }
    }
}
