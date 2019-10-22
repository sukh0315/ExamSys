using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Models
{
   public class CandidateModel
    {
        public System.Guid ID { get; set; }
        public System.Guid BatchID { get; set; }
        public string RegistrationNo { get; set; }
        public string CandidateName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DOB { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string Gender { get; set; }
        public string BatchName { get; set; }
    }
}
