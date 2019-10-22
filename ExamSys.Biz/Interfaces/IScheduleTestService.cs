using ExamSys.Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Interfaces
{
    public interface IScheduleTestService
    {
        List<ScheduleTestModel> GetScheduleTestList();
        bool InsertUpdateScheduleTestMaster(ScheduleTestModel mdl);
        bool DeleteScheduleTest(Guid ID);
        List<ScheduleTestModel> GetScheduleTestListByID(Guid ID);

    }
}
