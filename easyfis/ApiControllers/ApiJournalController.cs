﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace easyfis.Controllers
{
    public class ApiJournalController : ApiController
    {
        private Data.easyfisdbDataContext db = new Data.easyfisdbDataContext();

        // ===============
        // LIST TrnJournal
        // ===============
        [Route("api/listJournal")]
        public List<Models.TrnJournal> Get()
        {
            var journals = from d in db.TrnJournals
                           select new Models.TrnJournal
                                    {
                                        Id = d.Id,
                                        JournalDate = d.JournalDate.ToShortDateString(),
                                        BranchId = d.BranchId,
                                        Branch = d.MstBranch.Branch,
                                        AccountId = d.AccountId,
                                        Account = d.MstAccount.Account,
                                        AccountCode = d.MstAccount.AccountCode,
                                        ArticleId = d.ArticleId,
                                        Article = d.MstArticle.Article,
                                        Particulars = d.Particulars,
                                        DebitAmount = d.DebitAmount,
                                        CreditAmount = d.CreditAmount,
                                        ORId = d.ORId,
                                        CVId = d.CVId,
                                        JVId = d.JVId,
                                        RRId = d.RRId,
                                        SIId = d.SIId,
                                        INId = d.INId,
                                        OTId = d.OTId,
                                        STId = d.STId,
                                        DocumentReference = d.DocumentReference,
                                        APRRId = d.APRRId,
                                        ARSIId = d.ARSIId,
                                    };
            return journals.ToList();
        }

        // =======================
        // LIST TrnJournal By JVId
        // =======================
        [Route("api/listJournalByJVId/{JVId}")]
        public List<Models.TrnJournal> GetJournalByJVId(String JVId)
        {
            var journalJVId = Convert.ToInt32(JVId);
            var journals = from d in db.TrnJournals
                           where d.JVId == journalJVId
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }

        // =======================
        // LIST TrnJournal By RRId
        // =======================
        [Route("api/listJournalByRRId/{RRId}")]
        public List<Models.TrnJournal> GetJournalByRRId(String RRId)
        {
            var journalRRId = Convert.ToInt32(RRId);
            var journals = from d in db.TrnJournals
                           where d.RRId == journalRRId
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }

        // =======================
        // LIST TrnJournal By SIId
        // =======================
        [Route("api/listJournalBySIId/{SIId}")]
        public List<Models.TrnJournal> GetJournalBySIId(String SIId)
        {
            var journalSIId = Convert.ToInt32(SIId);
            var journals = from d in db.TrnJournals
                           where d.SIId == journalSIId
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }

        // =======================
        // LIST TrnJournal By CVId
        // =======================
        [Route("api/listJournalByCVId/{CVId}")]
        public List<Models.TrnJournal> GetJournalByCVId(String CVId)
        {
            var journalCVId = Convert.ToInt32(CVId);
            var journals = from d in db.TrnJournals
                           where d.CVId == journalCVId
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }

        // =======================
        // LIST TrnJournal By ORId
        // =======================
        [Route("api/listJournalByORId/{ORId}")]
        public List<Models.TrnJournal> GetJournalByORId(String ORId)
        {
            var journalORId = Convert.ToInt32(ORId);
            var journals = from d in db.TrnJournals
                           where d.ORId == journalORId
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }

        // =======================
        // LIST TrnJournal By INId
        // =======================
        [Route("api/listJournalByINId/{INId}")]
        public List<Models.TrnJournal> GetJournalByINId(String INId)
        {
            var journalINId = Convert.ToInt32(INId);
            var journals = from d in db.TrnJournals
                           where d.INId == journalINId
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }

        // =======================
        // LIST TrnJournal By OTId
        // =======================
        [Route("api/listJournalByOTId/{OTId}")]
        public List<Models.TrnJournal> GetJournalByOTId(String OTId)
        {
            var journalOTId = Convert.ToInt32(OTId);
            var journals = from d in db.TrnJournals
                           where d.OTId == journalOTId
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }

        // =======================
        // LIST TrnJournal By STId
        // =======================
        [Route("api/listJournalBySTId/{STId}")]
        public List<Models.TrnJournal> GetJournalBySTId(String STId)
        {
            var journalSTId = Convert.ToInt32(STId);
            var journals = from d in db.TrnJournals
                           where d.STId == journalSTId
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }

        // =============================
        // LIST TrnJournal By Article Id
        // =============================
        [Route("api/listJournalByArticleId/{ArticleId}")]
        public List<Models.TrnJournal> GetJournalByArticleId(String ArticleId)
        {
            var journals = from d in db.TrnJournals
                           where d.ArticleId == Convert.ToInt32(ArticleId)
                           select new Models.TrnJournal
                           {
                               Id = d.Id,
                               JournalDate = d.JournalDate.ToShortDateString(),
                               BranchId = d.BranchId,
                               Branch = d.MstBranch.Branch,
                               AccountId = d.AccountId,
                               Account = d.MstAccount.Account,
                               AccountCode = d.MstAccount.AccountCode,
                               ArticleId = d.ArticleId,
                               Article = d.MstArticle.Article,
                               Particulars = d.Particulars,
                               DebitAmount = d.DebitAmount,
                               CreditAmount = d.CreditAmount,
                               ORId = d.ORId,
                               CVId = d.CVId,
                               JVId = d.JVId,
                               RRId = d.RRId,
                               SIId = d.SIId,
                               INId = d.INId,
                               OTId = d.OTId,
                               STId = d.STId,
                               DocumentReference = d.DocumentReference,
                               APRRId = d.APRRId,
                               ARSIId = d.ARSIId,
                           };
            return journals.ToList();
        }
    }
}