using ExamSys.Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Interfaces
{
    public interface ILoginService
    {
        bool ValidateCredentials(LoginModel model);
    }
}
