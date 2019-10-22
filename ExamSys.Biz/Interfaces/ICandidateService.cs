using ExamSys.Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Interfaces
{
    public interface ICandidateService
    {
        List<CandidateModel> GetCandidateList();
        bool InsertUpdateCandidate(CandidateModel mdl);
        bool DeleteCandidate(Guid ID);
        List<CandidateModel> CandidateListById(Guid ID);

    }
}
