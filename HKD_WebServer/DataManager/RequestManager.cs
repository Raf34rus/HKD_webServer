using HKD_WebServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKD_WebServer.DataManager
{
    public class RequestManager
    {
        //public object AddRequest(int con_id, int csTypeId, int reqComment, int? address_to_il)
        //{
        //var res = -1;
        //try
        //{
        //    var manager = new DataManager();
        //    var oldRequests = manager.GetRequestsOnParam(con_id, csTypeId, User.Identity.Name);
        //    foreach (var reqrow in oldRequests)
        //    {
        //        reqrow.req_status = 1;
        //        reqrow.finishDate = DateTime.Now;
        //        reqrow.finishedUser = "System";
        //        reqrow.archivistComment = "Создан дублирующий запрос";
        //    }
        //    manager._store.SaveChanges();

        //    Contract_requess cr = new Contract_requess();
        //    cr.requestUser = User.Identity.Name;
        //    if (User.Identity.Name.ToLower().Contains("pristav"))
        //    {
        //        cr.requestUserFIO = UserPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain, "pristav.int"), IdentityType.SamAccountName, User.Identity.Name).Name;
        //    }
        //    cr.isUrgent = (User.IsInRole(Consts.LawyerRole) || User.IsInRole(Consts.ADLawyerRole));
        //    cr.Contracts = manager.GetContract(con_id);
        //    cr.req_status = 3;
        //    cr.requestComment = "";
        //    cr.archivistComment = "";
        //    cr.requestDate = DateTime.Now;
        //    cr.reqComment = reqComment;
        //    cr.reqType = csTypeId;

        //    if (csTypeId == 5)
        //    {
        //        cr.Office_Address = manager.GetAdress(address_to_il.GetValueOrDefault());
        //        cr.reqComment = 1;
        //        //cr.address_to_il = null;
        //        //cr.Office_Address = null;
        //    }


        //    manager._store.Contract_requess.Add(cr);
        //    manager._store.SaveChanges();
        //    res = cr.id;
        //    return Json(res, JsonRequestBehavior.AllowGet);
        //}
        //catch (Exception)
        //{
        //    return Json(res, JsonRequestBehavior.AllowGet);
        //}
        //}

        public object GetRequestInfoToJSON(int _id)
        {
            using (var ssContext = new ScanStoreContext())
            {
                return ssContext.ContractRequess.Where(cr => cr.Id == _id)
                                                    .Include(cr => cr.Contract)
                                                    .Include(cr => cr.Contract.Cession)
                                                    .Include(cr => cr.Contract.Cession.Partner)
                                                    .Include(cr => cr.Contract.ContractScans)
                                                    .Select(cr => new
                                                    {
                                                        cr.RequestDate,
                                                        cr.RequestComment,
                                                        cr.ArchivistComment,
                                                        cr.Contract.DebtNumber,
                                                        cr.Contract.DebtorFio,
                                                        cr.Contract.DebtDate,
                                                        cessName = cr.Contract.Cession.Name,
                                                        partnerNmae = cr.Contract.Cession.Partner.Name,
                                                        contractScans = cr.Contract.ContractScans.Select(cs => new
                                                        {
                                                            cs.FileName,
                                                            cs.CsType,
                                                            cs.Size,
                                                            cs.InsertDate
                                                        })

                                                    }).SingleOrDefault();
            }
        }

    }
}
