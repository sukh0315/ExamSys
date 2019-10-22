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
    public class CandidateService : ICandidateService
    {
        //ExamSys
        ExamSysEntities _db = new ExamSysEntities();
        /// <summary>
        /// Batch List 
        /// </summary>
        /// <returns></returns>
        public List<CandidateModel> GetCandidateList()
        {
            try
            {
                var rec = (from a in _db.Candidates
                           join b in _db.Batches on a.BatchID equals b.ID
                           where a.IsDeleted == false
                           select new CandidateModel
                           {
                               ID = a.ID,
                               CandidateName = a.CandidateName,
                               FatherName = a.FatherName,
                               RegistrationNo = a.RegistrationNo,
                               MotherName = a.MotherName,
                               DOB = a.DOB,
                               BatchName = b.BatchName,
                               Gender = a.Gender
                           }).ToList();
                return rec;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Schdule Details 
        /// </summary>
        /// <returns></returns>
        public List<CandidateModel> CandidateListById(Guid ID)
        {
            try
            {
                var rec = (from a in _db.Candidates
                           join b in _db.Batches on a.BatchID equals b.ID
                           where a.IsDeleted == false
                           && a.ID== ID
                           select new CandidateModel
                           {
                               ID = a.ID,
                               CandidateName = a.CandidateName,
                               FatherName = a.FatherName,
                               RegistrationNo = a.RegistrationNo,
                               MotherName = a.MotherName,
                               DOB = a.DOB,
                               BatchName = b.BatchName,
                               Gender = a.Gender,
                               BatchID = a.BatchID,

                           }).ToList();
                return rec;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public bool InsertUpdateCandidate(CandidateModel mdl)
        {
            bool isUpdate = false;
            try
            {
                if (mdl.ID == Guid.Empty)
                {
                    Candidate _batch = new Candidate();
                    _batch.ID = Guid.NewGuid();
                    _batch.CandidateName = mdl.CandidateName;
                    _batch.RegistrationNo = mdl.RegistrationNo;
                    _batch.FatherName = mdl.FatherName;
                    _batch.MotherName = mdl.MotherName;
                    _batch.IsDeleted = false;
                    _batch.DOB = mdl.DOB;
                    _batch.Gender = mdl.Gender;
                    _batch.CreatedBy = 1;
                    _batch.CreatedDateTime = DateTime.Now;
                    _batch.BatchID = mdl.BatchID;
                    _db.Candidates.Add(_batch);
                    _db.SaveChanges();
                    isUpdate = true;
                }
                else
                {
                    var _batch = (from a in _db.Candidates where a.ID == mdl.ID select a).FirstOrDefault();
                    if (_batch != null)
                    {
                        _batch.CandidateName = mdl.CandidateName;
                        _batch.RegistrationNo = mdl.RegistrationNo;
                        _batch.FatherName = mdl.FatherName;
                        _batch.MotherName = mdl.MotherName;
                        _batch.IsDeleted = false;
                        _batch.DOB = mdl.DOB;
                        _batch.Gender = mdl.Gender;
                        _batch.UpdatedBy = 1;
                        _batch.UpdatedOn = DateTime.Now;
                        _batch.BatchID = mdl.BatchID;
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

        public bool DeleteCandidate(Guid ID)
        {
            bool isUpdate = false;
            try
            {

                var _batch = (from a in _db.Candidates where a.ID == ID select a).FirstOrDefault();
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
