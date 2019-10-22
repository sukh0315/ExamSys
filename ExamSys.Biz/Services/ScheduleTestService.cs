using ExamSys.Biz.Interfaces;
using ExamSys.Biz.Models;
using ExamSys.Data;
using ExamSys.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Biz.Services
{
    public class ScheduleTestService : IScheduleTestService
    {
        //ExamSys
        ExamSysEntities _db = new ExamSysEntities();
        /// <summary>
        /// Schedule Test List 
        /// </summary>
        /// <returns></returns>
        public List<ScheduleTestModel> GetScheduleTestList()
        {
            try
            {
                var rec = (from a in _db.TestSchedules
                           join b in _db.Batches on a.BatchID equals b.ID
                           where a.IsDeleted == false
                           select new ScheduleTestModel
                           {
                               ID = a.ID,
                               BatchName = b.BatchName,
                               NumberOfSets = a.NumberOfSets,
                               Num_of_Questions = a.Num_of_Questions,
                               TestStartDate = a.TestStartDate,
                               TestEndDate = a.TestEndDate,
                           }).ToList();
                return rec;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public List<ScheduleTestModel> GetScheduleTestListByID(Guid ID)
        {
            try
            {
                var rec = (from a in _db.TestSchedules
                           join b in _db.Batches on a.BatchID equals b.ID
                           where a.IsDeleted == false
                           select new ScheduleTestModel
                           {
                               ID = a.ID,
                               BatchName = b.BatchName,
                               NumberOfSets = a.NumberOfSets,
                               Num_of_Questions = a.Num_of_Questions,
                               TestStartDate = a.TestStartDate,
                               TestEndDate = a.TestEndDate,
                               TestName = a.TestName,
                               BatchID = a.BatchID,
                               TimeAllowed = a.TimeAllowed,
                               QuestionCount = a.QuestionCount,
                               MaxMarks = a.MaxMarks,
                               PassMarks = a.PassMarks,
                               Language = a.Language,
                               ConfirmAssessmentDate = a.ConfirmAssessmentDate
                           }).ToList();
                return rec;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public bool InsertUpdateScheduleTestMaster(ScheduleTestModel mdl)
        {
            bool isUpdate = false;
            try
            {
                if (mdl.ID == Guid.Empty)
                {
                    TestSchedule _test = new TestSchedule();
                    _test.ID = Guid.NewGuid();
                    _test.BatchID = mdl.BatchID;
                    _test.TestName = mdl.TestName;
                    _test.TimeAllowed = mdl.TimeAllowed;
                    _test.Num_of_Questions = mdl.Num_of_Questions;
                    _test.TestStartDate = mdl.TestStartDate;
                    _test.TestEndDate = mdl.TestEndDate;
                    _test.MaxMarks = mdl.MaxMarks;
                    _test.PassMarks = mdl.PassMarks;
                    _test.IsNegative = mdl.IsNegative;
                    _test.NegativePercent = mdl.NegativePercent;
                    _test.IsReattempt = mdl.IsReattempt;
                    _test.NumberOfSets = mdl.NumberOfSets;
                    _test.QuestionCount = mdl.QuestionCount;
                    _test.Language = mdl.Language;
                    _test.ConfirmAssessmentDate = mdl.ConfirmAssessmentDate;
                    _test.Mode = mdl.Mode;
                    _test.IsDeleted = false;
                    _test.CreatedBy = 1;
                    _test.CreatedDateTime = DateTime.Now;
                    _db.TestSchedules.Add(_test);
                    _db.SaveChanges();
                    isUpdate = true;
                }
                else
                {
                    var _test = (from a in _db.TestSchedules where a.ID == mdl.ID select a).FirstOrDefault();
                    if (_test != null)
                    {
                        _test.BatchID = mdl.BatchID;
                        _test.TestName = mdl.TestName;
                        _test.TimeAllowed = mdl.TimeAllowed;
                        _test.Num_of_Questions = mdl.Num_of_Questions;
                        _test.TestStartDate = mdl.TestStartDate;
                        _test.TestEndDate = mdl.TestEndDate;
                        _test.MaxMarks = mdl.MaxMarks;
                        _test.PassMarks = mdl.PassMarks;
                        _test.IsNegative = mdl.IsNegative;
                        _test.NegativePercent = mdl.NegativePercent;
                        _test.IsReattempt = mdl.IsReattempt;
                        _test.NumberOfSets = mdl.NumberOfSets;
                        _test.QuestionCount = mdl.QuestionCount;
                        _test.Language = mdl.Language;
                        _test.ConfirmAssessmentDate = mdl.ConfirmAssessmentDate;
                        _test.Mode = mdl.Mode;
                        _test.IsDeleted = false;
                        _test.UpdatedBy = 1;
                        _test.UpdatedOn = DateTime.Now;
                        _db.SaveChanges();
                        isUpdate = true;
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return isUpdate;

        }

        public bool DeleteScheduleTest(Guid ID)
        {
            bool isUpdate = false;
            try
            {

                var _batch = (from a in _db.TestSchedules where a.ID == ID select a).FirstOrDefault();
                if (_batch != null)
                {
                    _batch.IsDeleted = true;
                    _batch.UpdatedBy = 1;
                    _batch.UpdatedOn = DateTime.Now;
                    _db.SaveChanges();
                    isUpdate = true;
                }

            }

            catch (Exception ex)
            {

            }
            return isUpdate;

        }


    }
}
