using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Models
{
    public class ScheduleTestModel
    {
        public System.Guid ID { get; set; }
        public System.Guid BatchID { get; set; }
        public string TestName { get; set; }
        public int TimeAllowed { get; set; }
        public int Num_of_Questions { get; set; }
        public System.DateTime TestStartDate { get; set; }
        public System.DateTime TestEndDate { get; set; }
        public int MaxMarks { get; set; }
        public int PassMarks { get; set; }
        public bool IsNegative { get; set; }
        public decimal NegativePercent { get; set; }
        public bool IsReattempt { get; set; }
        public int NumberOfSets { get; set; }
        public int QuestionCount { get; set; }
        public string Language { get; set; }
        public System.DateTime ConfirmAssessmentDate { get; set; }
        public string Mode { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string BatchName { get; set; }

    }
}
