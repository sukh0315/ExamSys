using ExamSys.Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Interfaces
{
    public interface IBatchService
    {
        List<BatchModel> GetBatchesData();
        bool DeletesBatchData(Guid ID);
        bool InsertUpdateBatchData(BatchModel mdl);
        List<BatchModel> GetBatchDataByID(Guid ID);

    }
}
