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
    public class BatchService : IBatchService
    {
        //ExamSys
        ExamSysEntities _db = new ExamSysEntities();
        /// <summary>
        /// Batch List 
        /// </summary>
        /// <returns></returns>
        public List<BatchModel> GetBatchesData()
        {
            try
            {
                var rec = (from a in _db.Batches
                           where a.IsDeleted == false
                           select new BatchModel
                           {
                               ID = a.ID,
                               BatchCode = a.BatchCode,
                               BatchName = a.BatchName,
                               AssessmentDate = a.AssessmentDate,
                               NoOfCandidate = a.NoOfCandidate,
                               Course = a.Course,
                               Language = a.Language
                           }).ToList();
                return rec;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Batch Detail 
        /// </summary>
        /// <returns></returns>
        public List<BatchModel> GetBatchDataByID(Guid ID)
        {
            try
            {
                var rec = (from a in _db.Batches
                           where a.IsDeleted == false
                           && a.ID== ID
                           select new BatchModel
                           {
                               ID = a.ID,
                               BatchCode = a.BatchCode,
                               BatchName = a.BatchName,
                               AssessmentDate = a.AssessmentDate,
                               NoOfCandidate = a.NoOfCandidate,
                               Course = a.Course,
                               Language = a.Language    
                           }).ToList();
                return rec;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public bool InsertUpdateBatchData(BatchModel mdl)
        {
            bool isUpdate = false;
            try
            {
                if (mdl.ID == Guid.Empty)
                {
                    Batch _batch = new Batch();
                    _batch.ID = Guid.NewGuid();
                    _batch.BatchCode = mdl.BatchCode;
                    _batch.BatchName = mdl.BatchName;
                    _batch.NoOfCandidate = mdl.NoOfCandidate;
                    _batch.Language = mdl.Language;
                    _batch.IsDeleted = false;
                    _batch.AssessmentDate = mdl.AssessmentDate;
                    _batch.Course = mdl.Course;
                    _batch.CreatedBy = 1;
                    _batch.CreatedDateTime = DateTime.Now;
                    _db.Batches.Add(_batch);
                    _db.SaveChanges();
                    isUpdate = true;
                }
                else
                {
                    var _batch =  _db.Batches.Where(x=>x.ID== mdl.ID).FirstOrDefault();
                    if (_batch != null)
                    {
                        _batch.BatchCode = mdl.BatchCode;
                        _batch.BatchName = mdl.BatchName;
                        _batch.NoOfCandidate = mdl.NoOfCandidate;
                        _batch.Language = mdl.Language;
                        _batch.AssessmentDate = mdl.AssessmentDate;
                        _batch.Course = mdl.Course;
                        _batch.UpdatedBy = 1;
                        _batch.UpdatedOn = DateTime.Now;
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

        public bool DeletesBatchData(Guid ID)
        {
            bool isUpdate = false;
            try
            {

                var _batch = (from a in _db.Batches where a.ID == ID select a).FirstOrDefault();
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
