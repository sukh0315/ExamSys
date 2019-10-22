using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Models
{
    public class BatchModel 
    {

        public System.Guid ID { get; set; }
        public string BatchName { get; set; }
        public string BatchCode { get; set; }
        public System.DateTime AssessmentDate { get; set; }
        public string Course { get; set; }
        public string Language { get; set; }
        public int NoOfCandidate { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }
}
