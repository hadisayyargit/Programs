using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShakelliReportsUI.DataLayer.Models;
using System.Data.Entity;

namespace ShakelliReportsUI.Main.Controllers
{
    public class PrimeController : Controller
    {
        private ShakelliDWEntities db = new ShakelliDWEntities();
        //
        // GET: /Configuration/
        #region Object
        public ActionResult AppObjects()
        {
            if (HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserName] == null)
            {
                //Response.Redirect("~/Account/Login");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                string m = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]).ToString();
                Session[CommonUnits.GeneralModule.m_MessageList] = db.AppNotification.Where(a => (a.NotificationType == 0 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
                Session[CommonUnits.GeneralModule.m_NotificationList] = db.AppNotification.Where(a => (a.NotificationType == 1 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
            }

            AppGroupUserObjectView myModel = new AppGroupUserObjectView();

            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Administration] = "";

            List<AppGroupUserObjectView> myAppObjectList =
                             (from o in db.AppObject
                              join o1 in db.AppObject on o.ParentObjectId equals o1.ObjectId into j1
                              from oo in j1.DefaultIfEmpty()
                              join l in 
                              db.Lookup.Where(l => l.ParentId == 55) on o.ObjectTypeCode equals l.PCode into j2
                              from ol in j2.DefaultIfEmpty()
                              select new AppGroupUserObjectView
                              {
                                  ObjectId = o.ObjectId,
                                  ObjectName = o.ObjectName,
                                  ObjectDs = o.ObjectDs,
                                  ObjectTypeCode = o.ObjectTypeCode,
                                  ParentObjectId = o.ParentObjectId,
                                  ParentObjectDs = oo.ObjectDs,
                                  ObjectTypeDs = ol.Title,
                                  UrlPath=o.UrlPath,
                                  HasDirectPath=o.HasDirectPath

                              }).ToList();

            ViewBag.AppObject = myAppObjectList;



            return View("AppObjects", myModel);

        }



        public void selectnode(decimal objectid = 0)
        {
            Session[CommonUnits.GeneralModule.m_Node] = objectid;
        }
        /**********************************************
                      AppObject
          **********************************************/

        public ActionResult AppObject_edit2(decimal objectid)
        {

            if (objectid == -1)
            {
                try
                {
                    objectid = (decimal)Session[CommonUnits.GeneralModule.m_Node];
                }
                catch
                {
                    objectid = -1;

                }
            }

            return RedirectToAction("AppObject_edit", "Prime", routeValues: new { objectid = objectid });

        }
        public ActionResult AppObject_edit(decimal objectid)
        {

            AppObject myModel = db.AppObject.Find(objectid);

            List<Lookup> myObjectTypeList = (from l in db.Lookup
                                             where l.ParentId == 55
                                             orderby l.ParentId
                                             select l
                                                ).ToList();


            ViewBag.ObjectType = myObjectTypeList;
            ViewBag.ObjectList = db.AppObject.ToList();


            return View(myModel);
        }

        [HttpPost]
        public ActionResult AppObject_edit(AppObject myModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myModel).State = EntityState.Modified;
                db.SaveChanges();
            }

            //return View("UserManagement");
            return RedirectToAction("AppObjects", "Prime");
        }

        public ActionResult AppObject_create(decimal objectid = 0)
        {
            AppObject myModel = db.AppObject.Find(objectid);

            if (myModel == null)
                myModel = new AppObject();

            List<Lookup> myObjectTypeList = (from l in db.Lookup
                                             where l.ParentId == 55
                                             orderby l.ParentId
                                             select l
                                                ).ToList();


            ViewBag.ObjectType = myObjectTypeList;
            ViewBag.ObjectList = db.AppObject.ToList();


            return View("AppObject_edit", myModel);
        }

        [HttpPost]
        public ActionResult AppObject_create(AppObject myModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    db.AppObject.Add(myModel);
                    db.SaveChanges();
                }
                catch
                {

                }
            }

            return RedirectToAction("AppObjects", "Prime");
        }


        public ActionResult AppObject_cancel()
        {
            return RedirectToAction("AppObjects", "Prime");
        }


        public ActionResult AppObject_delete(decimal objectid = 0)
        {
            AppObject myModel = db.AppObject.Find(objectid);

            return View(myModel);
        }

        public ActionResult AppObject_delete_confirm(AppObject myModel)
        {
            try
            {

                db.Entry(myModel).State = EntityState.Deleted;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                Session[CommonUnits.GeneralModule.m_CurrentError] = ex;
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "اطلاعات پایه", MessageType = "Error", CallerAction = "AppObjects", CallerController = "Prime" };
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);

            }

            return RedirectToAction("AppObjects", "Prime");

        }


        #endregion

        #region UserManagement
        public ActionResult UserManagement(int groupid = 0, int userid = 0, string activetab = "")
        {
            if (HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserName] == null)
            {
                //Response.Redirect("~/Account/Login");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                string m = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]).ToString();


                //Session[CommonUnits.GeneralModule.m_AccessList]
                //Session[CommonUnits.GeneralModule.m_PrimeVisible]


                Session[CommonUnits.GeneralModule.m_MessageList] = db.AppNotification.Where(a => (a.NotificationType == 0 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
                Session[CommonUnits.GeneralModule.m_NotificationList] = db.AppNotification.Where(a => (a.NotificationType == 1 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
            }

            ViewBag.Tab_Group_Active = "";
            ViewBag.Tab_User_Active = "";
            ViewBag.Tab_GroupUser_Active = "";
            ViewBag.Tab_GroupUserObject_Active = "";

            AppGroupUserObjectView myModel = new AppGroupUserObjectView();
            myModel.GroupId = groupid;
            myModel.UserId = userid;



            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";

            switch (activetab)
            {
                case "Tab_Group":
                    ViewBag.Tab_Group_Active = "active";
                    break;

                case "Tab_User":
                    ViewBag.Tab_User_Active = "active";
                    break;

                case "Tab_GroupUser":
                    ViewBag.Tab_GroupUser_Active = "active";
                    break;

                case "Tab_GroupUserObject":
                    ViewBag.Tab_GroupUserObject_Active = "active";
                    break;

                default:
                    ViewBag.Tab_Group_Active = "active";
                    break;
            }

            List<AppGroup> myAppGroupList = (from p in db.AppGroup
                                             orderby p.GroupId
                                             select p).ToList();

            ViewBag.AppGroup = myAppGroupList;


            List<AppUserPersonView> myUserList =
                             (from u in db.AppUser
                              join o in db.Organization on u.OrganizationId equals o.OrganizationId into g1
                              from uo in g1.DefaultIfEmpty()
                              join p in db.Person on u.PersonId equals p.PersonId into g2
                              orderby u.UserId
                              from up in g2.DefaultIfEmpty()
                              select new AppUserPersonView
                              {
                                  UserId = u.UserId,
                                  UserName = u.UserName,
                                  PersonId = u.PersonId,
                                  Password = u.Password,
                                  OrganizationId = u.OrganizationId,
                                  EnabledTitle = (u.Enabled) ? "فعال" : "غیرفعال",
                                  OrganizationTitle = uo.Title,
                                  LastName= (up.LastName == null ? "" : up.LastName) ,
                                  FirstName= (up.FirstName == null ? "" : up.FirstName)
                              }).ToList();


            ViewBag.AppUser = myUserList;

            List<AppUserPersonView> myGroupUserList =
                             (from u in db.AppUser
                              join gu in db.AppGroupUser on u.UserId equals gu.UserId into j1
                              from gu2 in j1.DefaultIfEmpty()
                              join p in db.Person on u.PersonId equals p.PersonId into j2
                              from up in j2.DefaultIfEmpty()
                              where gu2.GroupId == myModel.GroupId
                              select new AppUserPersonView
                              {
                                  UserId = u.UserId,
                                  UserName = u.UserName,
                                  PersonId = u.PersonId,
                                  GroupId = gu2.GroupId,
                                  EnabledTitle = (u.Enabled) ? "فعال" : "غیرفعال",
                                  LastName = (up.LastName == null ? "" : up.LastName),
                                  FirstName= (up.FirstName == null ? "" : up.FirstName)

                              }).ToList();

            ViewBag.GroupUser = myGroupUserList;

            //List<AppGroupUserObjectView> myGroupUserObjectList =
            //                 (from t in db.AppGroupUserObject
            //                  join o1 in db.AppObject on t.ObjectId equals o1.ObjectId into j1
            //                  from o in j1.DefaultIfEmpty()
            //                  join g1 in db.AppGroup on t.GroupId equals g1.GroupId into j2
            //                  from g in j2.DefaultIfEmpty()
            //                  join u1 in db.AppUser on t.UserId equals u1.UserId into j3
            //                  where ((myModel.UserId != 0 && t.UserId == myModel.UserId) || (myModel.UserId == 0 && myModel.GroupId != 0 && t.UserId == null && t.GroupId == myModel.GroupId))
            //                  from u in j3.DefaultIfEmpty()
            //                  select new AppGroupUserObjectView
            //                  {
            //                      Id = t.Id,
            //                      ObjectId = t.ObjectId,
            //                      ObjectDs = o.ObjectDs,
            //                      GroupId = t.GroupId,
            //                      GroupName = g.GroupName,
            //                      UserId = t.UserId,
            //                      UserName = u.UserName,
            //                      CRUD = t.CRUD

            //                  }).ToList();


            /*
declare @g int 
declare @u int

set @g=2
set @u=null
SELECT        o.ObjectId, o.ObjectName, o.ObjectDs, o.ParentObjectId, o.ObjectTypeCode, o.StoredProcedure, o.UrlPath
, guo.CRUD
, g.GroupName
,        u.UserName, guo.GroupId, guo.UserId
FROM            AppObject o 
left JOIN
                        (select * from AppGroupUserObject where ((GroupId=@g and  UserId is null) or  GroupId is null and  UserId=@u)) AS guo ON o.ObjectId = guo.ObjectId 
left JOIN AppGroup g ON guo.GroupId = g.GroupId 
						 left JOIN AppUser u ON guo.UserId = u.UserId              
             
             */


            List<AppGroupUserObjectView> myGroupUserObjectList =
                             (from o in db.AppObject
                              join guo1 in db.AppGroupUserObject.Where((a => (a.UserId == null && a.GroupId == myModel.GroupId) || (a.GroupId == null && a.UserId == myModel.UserId))) on o.ObjectId equals guo1.ObjectId into j1
                              from guo in j1.DefaultIfEmpty()
                              join g1 in db.AppGroup on guo.GroupId equals g1.GroupId into j2
                              from g in j2.DefaultIfEmpty()
                              join u1 in db.AppUser on guo.UserId equals u1.UserId into j3
                              from u in j3.DefaultIfEmpty()
                              select new AppGroupUserObjectView
                              {
                                  //Id = guo.Id,
                                  ObjectId = o.ObjectId,
                                  ObjectDs = o.ObjectDs,
                                  ObjectName = o.ObjectName,
                                  ParentObjectId=o.ParentObjectId,
                                  ObjectTypeCode=o.ObjectTypeCode,
                                  GroupId = guo.GroupId,
                                  GroupName = g.GroupName,
                                  UserId = guo.UserId,
                                  UserName = u.UserName,
                                  HasDirectPath=o.HasDirectPath,
                                  UrlPath=o.UrlPath,
                                  CRUD = guo.CRUD

                              }).ToList();



            //List<AppGroupUserObjectView> myGroupUserObjectList = db.AppObject.Join(db.AppGroupUserObject, o => o.ObjectId, guo => guo.ObjectId, (o, guo) => new { o, guo })

            //    .Join(db.AppGroup, g1 => g1.guo.GroupId, g => g.GroupId, (g1, g) => new { g1, g })
            //    .Join(db.AppUser, u1 => u1.g1.guo.GroupId, u => u.UserId, (u1, u) => new { u1, u })
            //    //.Where(m => (m.u1.g1.guo.GroupId == myModel.GroupId && m.u1.g1.guo.UserId == null) || (m.u1.g1.guo.UserId == myModel.UserId && m.u1.g1.guo.GroupId == null))
            //    .Select(m => new AppGroupUserObjectView
            //    {
            //        Id = m.u1.g1.guo.Id,
            //        ObjectId = m.u1.g1.o.ObjectId,
            //        ObjectName = m.u1.g1.o.ObjectName,
            //        ObjectDs = m.u1.g1.o.ObjectDs,
            //        ParentObjectId = m.u1.g1.o.ParentObjectId,
            //        ObjectTypeCode = m.u1.g1.o.ObjectTypeCode,
            //        CRUD = m.u1.g1.guo.CRUD,
            //        UserId = m.u1.g1.guo.UserId,
            //        GroupName = m.u1.g.GroupName,
            //        UserName = m.u.UserName,
            //    }).ToList();
                         
              // نتونستم left join 
             





            ViewBag.GroupUserObject = myGroupUserObjectList;

            return View("UserManagement", myModel);

        }


        /**********************************************
                            AppGroup
         **********************************************/
        public ActionResult AppGroup_edit(int groupid)
        {
            AppGroup myModel = db.AppGroup.Find(groupid);

            return View(myModel);
        }

        [HttpPost]
        public ActionResult AppGroup_edit(AppGroup myModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myModel).State = EntityState.Modified;
                db.SaveChanges();
            }

            //return View("UserManagement");
            return RedirectToAction("UserManagement", "Prime");
        }

        public ActionResult AppGroup_create(int groupid = 0)
        {
            AppGroup myModel = db.AppGroup.Find(groupid);
            myModel = new AppGroup();

            return View("AppGroup_edit", myModel);
        }

        [HttpPost]
        public ActionResult AppGroup_create(AppGroup myModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    db.AppGroup.Add(myModel);
                    db.SaveChanges();
                }
                catch
                {

                }
            }

            return RedirectToAction("UserManagement", "Prime");
        }


        public ActionResult AppGroup_cancel()
        {
            return RedirectToAction("UserManagement", "Prime");
        }

        public ActionResult AppGroup_delete(int groupid = 0)
        {
            AppGroup myModel = db.AppGroup.Find(groupid);

            return View(myModel);
        }

        public ActionResult AppGroup_delete_confirm(AppGroup myModel)
        {
            try
            {

                db.Entry(myModel).State = EntityState.Deleted;
                db.SaveChanges();
            }

            catch
            {

            }

            return RedirectToAction("UserManagement", "Prime");

        }

        /**********************************************
                    AppUser
        **********************************************/
        public ActionResult AppUser_edit(int userid)
        {
            AppUser myModel = db.AppUser.Find(userid);

            List<WorkListModel> myPersonList = (from p in db.Person
                                                orderby p.PersonId
                                                select new WorkListModel
                                                {
                                                    ItemId = p.PersonId,
                                                    ItemDs = p.LastName + "-" + p.FirstName
                                                }).ToList();


            ViewBag.Person = myPersonList;
            ViewBag.Organization = db.Organization.ToList();


            return View(myModel);
        }

        [HttpPost]
        public ActionResult AppUser_edit(AppUser myModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myModel).State = EntityState.Modified;
                db.SaveChanges();
            }

            //return View("UserManagement");
            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_User" });
        }

        public ActionResult AppUser_create(int userid = 0)
        {
            AppUser myModel = db.AppUser.Find(userid);

            if (myModel == null)
                myModel = new AppUser();

            List<WorkListModel> myPersonList = (from p in db.Person
                                                orderby p.PersonId
                                                select new WorkListModel
                                                {
                                                    ItemId = p.PersonId,
                                                    ItemDs = p.LastName + "-" + p.FirstName
                                                }).ToList();


            ViewBag.Person = myPersonList;
            ViewBag.Organization = db.Organization.ToList();

            return View("AppUser_edit", myModel);
        }

        [HttpPost]
        public ActionResult AppUser_create(AppUser myModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    db.AppUser.Add(myModel);
                    db.SaveChanges();
                }
                catch
                {

                }
            }

            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_User" });
        }

        public ActionResult AppUser_cancel()
        {
            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_User" });
        }


        public ActionResult AppUser_delete(int userid = 0)
        {
            AppUser myModel = db.AppUser.Find(userid);

            return View(myModel);
        }

        public ActionResult AppUser_delete_confirm(AppUser myModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Entry(myModel).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "حذف کاربر", MessageType = "Error", CallerAction = "AppUser_cancel", CallerController = "Prime" };

                Session[CommonUnits.GeneralModule.m_CurrentError] = ex;
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);

            }

            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_User" });

        }


        /**********************************************
                            GroupUser
         **********************************************/

        public ActionResult AppGroupUser_refresh(AppGroupUserObjectView myModel)
        {
            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_GroupUser", groupid = myModel.GroupId });
        }

        public ActionResult AppGroupUser_create()
        {
            AppGroupUser myModel = new AppGroupUser();

            ViewBag.AppGroup = db.AppGroup.ToList();
            ViewBag.AppUser = db.AppUser.ToList();

            return View("AppGroupUser_edit", myModel);
        }

        [HttpPost]
        public ActionResult AppGroupUser_create(AppGroupUser myModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    db.AppGroupUser.Add(myModel);
                    db.SaveChanges();
                }

                catch (Exception ex)
                {
                    Session[CommonUnits.GeneralModule.m_CurrentError] = ex;
                    Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "اطلاعات پایه", MessageType = "Error", CallerAction = "AppGroupUser_create", CallerController = "Prime" };
                    return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);
                }


            }

            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_GroupUser" });
        }

        public ActionResult AppGroupUser_edit(int groupid, int userid)
        {
            //AppGroupUser myModel = db.AppGroupUser.Find(userid);`
            AppGroupUser myModel = db.AppGroupUser.Where(m => m.GroupId == groupid).Where(m => m.UserId == userid).First();

            ViewBag.AppGroup = db.AppGroup.ToList();
            ViewBag.AppUser = db.AppUser.ToList();

            return View(myModel);
        }

        [HttpPost]
        public ActionResult AppGroupUser_edit(AppGroupUser myModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myModel).State = EntityState.Modified;
                db.SaveChanges();
            }

            //return View("UserManagement");
            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_User" });
        }

        public ActionResult AppGroupUser_cancel()
        {
            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_GroupUser" });
        }


        public ActionResult AppGroupUser_delete(int groupid = 0, int userid = 0)
        {
            AppGroupUser myModel = db.AppGroupUser.Where(m => m.GroupId == groupid).Where(m => m.UserId == userid).First();

            return View(myModel);
        }

        public ActionResult AppGroupUser_delete_confirm(AppGroupUser myModel)
        {
            //        var errors1 = ModelState.Values.SelectMany(v => v.Errors);

            //        var errors2 = ModelState
            //.Where(x => x.Value.Errors.Count > 0)
            //.Select(x => new { x.Key, x.Value.Errors })
            //.ToArray();

            //if (ModelState.IsValid)

            try
            {

                db.Entry(myModel).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch
            {

            }

            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_GroupUser", groupid = myModel.GroupId });

        }


        /**********************************************
                      AppGroupUserObject
          **********************************************/


        public ActionResult AppGroupUserObject_updateAll(AppGroupUserObjectView myModel1)
        {
            //AppGroupUserObjectView myModel1 = new AppGroupUserObjectView();
            //myModel1.GroupId = groupid;
            //myModel1.UserId = userid;
            //return RedirectToAction("AppGroupUserObject_update", new { GroupId = groupid, UserId = userid, updateall = true });

            //TempData["AppGroupUserObjectView"] = myModel1;
            //return RedirectToAction("AppGroupUserObject_update",new {myModel=myModel1 , updateall = true});
            return RedirectToAction("AppGroupUserObject_update", new { GroupId = myModel1.GroupId, UserId = myModel1.UserId, updateall = true });
        }

        public ActionResult AppGroupUserObject_update(AppGroupUserObjectView myModel, bool isleaf=false, bool updateall=false)
        {
            //if (TempData["AppGroupUserObjectView"] != null)
              //  myModel = (AppGroupUserObjectView)TempData["AppGroupUserObjectView"];

            List<AppGroupUserObjectView> model1 = new List<AppGroupUserObjectView>();

            if (updateall)
            {
                myModel.ObjectId = 0;
            }
            else
            {
                if (!isleaf)
                {
                    try
                    {
                        myModel.ObjectId = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_Node]);
                    }
                    catch
                    {
                        myModel.ObjectId = 0;
                    }
                }
            }

            ViewBag.SubTitle = "";
            if(myModel.GroupId!=0)
                ViewBag.SubTitle = "گروه: " + db.AppGroup.Find(myModel.GroupId).GroupName;
            if(myModel.UserId!=0)
                ViewBag.SubTitle = "کاربر: " + db.AppUser.Find(myModel.UserId).UserName;
            
            model1 = (from o in db.vwObject2.Where(m => m.ObjectId == myModel.ObjectId || myModel.ObjectId == 0)
                      join guo in (db.AppGroupUserObject.Where(x => (x.UserId == null && x.GroupId == myModel.GroupId) || (x.GroupId==null&&x.UserId==myModel.UserId))) on o.ObjectId equals guo.ObjectId into j1
                      from t in j1.DefaultIfEmpty()                      
                      select new AppGroupUserObjectView
                      {
                          //Id = t.Id,
                          ObjectId = o.ObjectId,
                          ObjectDs = o.ObjectDs,
                          GroupId = (myModel.GroupId==0)? null:myModel.GroupId,
                          ParentObjectId = o.ParentObjectId,
                          ParentObjectDs=o.ObjectHierarchy,
                          UserId = (myModel.UserId == 0) ? null : myModel.UserId,
                          HasDirectPath=o.HasDirectPath,                          
                          UrlPath=o.UrlPath,

                          CRUD = t.CRUD,

                          
                          CreateRight = (t.CRUD.Substring(0, 1) == "1") ? true : false,
                          ReadRight = (t.CRUD.Substring(1, 1) == "1") ? true : false,
                          UpdateRight = (t.CRUD.Substring(2, 1) == "1") ? true : false,
                          DeleteRight = (t.CRUD.Substring(3, 1) == "1") ? true : false

                          

                      }).OrderBy(o=>o.ParentObjectDs).ToList();


            return View("AppGroupUserObject_edit", model1);
        }

        [HttpPost]
        public ActionResult AppGroupUserObject_update(List<AppGroupUserObjectView> myModel, bool isleaf = false, bool updateall = false)
        {

            Nullable<int> nGroupId = myModel[0].GroupId;
            Nullable<int> nUserId = myModel[0].UserId;
            Nullable<int> nObjectId = myModel[0].ObjectId;

            if (ModelState.IsValid)
            {
                if (updateall)
                {
                    if (nGroupId != null && nGroupId != 0)
                    {
                        db.AppGroupUserObject.RemoveRange(db.AppGroupUserObject.Where(x => x.GroupId == nGroupId));
                    }

                    if (nUserId != null && nUserId != 0)
                    {
                        db.AppGroupUserObject.RemoveRange(db.AppGroupUserObject.Where(x => x.UserId == nUserId));
                    }
                }

                else
                {
                    db.AppGroupUserObject.RemoveRange(db.AppGroupUserObject.Where(x => (x.ObjectId == nObjectId && ((x.GroupId != null && x.GroupId == nGroupId) || (x.UserId != null && x.UserId == nUserId)))));
                }

                foreach (AppGroupUserObjectView row in myModel)
                {
                    row.CRUD = "CRUD";
                    row.CRUD = row.CRUD.Replace('C', row.CreateRight ? '1' : '0');
                    row.CRUD = row.CRUD.Replace('R', row.ReadRight ? '1' : '0');
                    row.CRUD = row.CRUD.Replace('U', row.UpdateRight ? '1' : '0');
                    row.CRUD = row.CRUD.Replace('D', row.DeleteRight ? '1' : '0');

                    //if (row.CRUD != "0000")
                    //{
                        AppGroupUserObject myRecord = new AppGroupUserObject();
                        myRecord.GroupId = row.GroupId;
                        myRecord.UserId = row.UserId;
                        myRecord.ObjectId = row.ObjectId;
                        myRecord.CRUD = row.CRUD;
                        db.AppGroupUserObject.Add(myRecord);
                    //}
                    
                //db.Database.ExecuteSqlCommand("spInsertAppGroupUserObject {0}, {1}, {2}, {3},{4}", row.Id, row.GroupId, row.UserId, row.ObjectId, row.CRUD);
                }

                db.SaveChanges();

            }

            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_GroupUserObject", groupid = nGroupId, userid = nUserId });

        }


        public ActionResult AppGroupUserObject_cancel()
        {
            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_GroupUserObject" });
        }


        public ActionResult AppGroupUserObject_delete(int id = 0)
        {
            AppGroupUserObject myModel = db.AppGroupUserObject.Find(id);

            return View(myModel);
        }

        public ActionResult AppGroupUserObject_delete_confirm(AppGroupUserObject myModel)
        {
            try
            {

                db.Entry(myModel).State = EntityState.Deleted;
                db.SaveChanges();
            }

            catch
            {

            }

            return RedirectToAction("UserManagement", "Prime", routeValues: new { activetab = "Tab_GroupUserObject" });

        }

        #endregion

        #region OrganizationChart

        /**********************************************
                            OrganizationChart
         **********************************************/
        public ActionResult OrganizationChart(int organizationid = 0, int personid = 0, string activetab = "")
        {
            if (HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserName] == null)
            {
                //Response.Redirect("~/Account/Login");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                string m = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]).ToString();
                Session[CommonUnits.GeneralModule.m_MessageList] = db.AppNotification.Where(a => (a.NotificationType == 0 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
                Session[CommonUnits.GeneralModule.m_NotificationList] = db.AppNotification.Where(a => (a.NotificationType == 1 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
            }

            ViewBag.Tab_Organization_Active = "";
            ViewBag.Tab_Person_Active = "";
            ViewBag.Tab_OrganizationUser_Active = "";
            Session[CommonUnits.GeneralModule.m_MessageModel] = null;

            switch (activetab)
            {
                case "Tab_Organization":
                    ViewBag.Tab_Organization_Active = "active";
                    break;

                case "Tab_Person":
                    ViewBag.Tab_Person_Active = "active";
                    break;

                case "Tab_OrganizationUser":
                    ViewBag.Tab_OrganizationUser_Active = "active";
                    break;

                default:
                    ViewBag.Tab_Organization_Active = "active";
                    break;
            }

            List<OrganizationUserView> myOrganizationList =
                             (from o in db.Organization
                              join o1 in db.Organization on o.ParentId equals o1.OrganizationId into j1
                              from oo in j1.DefaultIfEmpty()
                              join l in db.Lookup.Where(t => t.ParentId == 44) on o.OrganizationTypeCode equals l.PCode into j2
                              from ol in j2.DefaultIfEmpty()
                              select new OrganizationUserView
                              {
                                  OrganizationId = o.OrganizationId,
                                  Title = o.Title,
                                  ParentId = o.ParentId,
                                  LocationCode = o.LocationCode,
                                  AutorizeCode = o.AutorizeCode,
                                  OrganizationTypeCode = o.OrganizationTypeCode,
                                  ParentOrganizationDs = oo.Title,
                                  OrganizationTypeCodeDs = ol.Title

                              }).ToList();

            ViewBag.Organization = myOrganizationList;



            List<Person> myPersonList = (from s in db.Person
                                         select s
                //select new Site_Budjeh_View
                //{
                //    BudjehId = s.BudjehId,
                //    Sal = s.Sal,
                //    Mah = s.Mah,
                //    ServiceTypeId = (t == null ? 0 : t.ServiceTypeId),
                //    ServiceTypeDs = (t == null ? null : t.ServiceName),
                //    tedad = s.tedad,
                //    mablagh = s.mablagh,
                //}
                                         ).ToList();


            ViewBag.Person = myPersonList;


            List<OrganizationUserView> myOrganizationUserList =
                             (from t in db.OrganizationUser
                              join o1 in db.Organization on t.OrganizationId equals o1.OrganizationId into j1
                              from o in j1.DefaultIfEmpty()
                              join u1 in db.AppUser on t.UserId equals u1.UserId into j3
                              from u in j3.DefaultIfEmpty()
                              select new OrganizationUserView
                              {
                                  Id = t.Id,
                                  OrganizationId = t.OrganizationId,
                                  Title = o.Title,
                                  UserId = t.UserId,
                                  UserName = u.UserName,
                              }).ToList();

            ViewBag.OrganizationUser = myOrganizationUserList;


            return View("OrganizationChart");

        }

        public ActionResult Organization_edit(int organizationid)
        {
            Organization myModel = db.Organization.Find(organizationid);

            List<Lookup> myOrganizationTypeList = (from l in db.Lookup
                                                   where l.ParentId == 44
                                                   orderby l.ParentId
                                                   select l
                                                ).ToList();


            ViewBag.OrganizationType = myOrganizationTypeList;
            ViewBag.OrganizationList = db.Organization.ToList();

            return View(myModel);
        }

        [HttpPost]
        public ActionResult Organization_edit(Organization myModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(myModel).State = EntityState.Modified;
                    db.SaveChanges();
                    Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = "", Title = "", SubTitle = "" };
                    return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_Organization" });
                }
                catch (Exception ex)
                {
                    Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = "اطلاعات نامعتبر است", Title = "", SubTitle = "", MessageType = "Error" };
                    return RedirectToAction("Organization_edit", "Prime", routeValues: new { organizationid = myModel.OrganizationId });
                }


            }
            else
            {
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = "اطلاعات نامعتبر است", Title = "خطا", SubTitle = "بروزرسانی سازمان", MessageType = "Error", CallerAction = "OrganizationChart", CallerController = "Prime" };
                return View("MessageView", Session[CommonUnits.GeneralModule.m_MessageModel]);
                //return RedirectToAction("HandleMessage", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);
            }


        }

        public ActionResult Organization_create(int Organizationid = 0)
        {
            Organization myModel = db.Organization.Find(Organizationid);

            if (myModel == null)
                myModel = new Organization();

            List<Lookup> myOrganizationTypeList = (from l in db.Lookup
                                                   where l.ParentId == 44
                                                   orderby l.ParentId
                                                   select l
                                                ).ToList();


            ViewBag.OrganizationType = myOrganizationTypeList;
            ViewBag.OrganizationList = db.Organization.ToList();


            return View("Organization_edit", myModel);
        }

        [HttpPost]
        public ActionResult Organization_create(Organization myModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Organization.Add(myModel);
                    db.SaveChanges();
                    Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = "", Title = "", SubTitle = "" };
                    return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_Organization" });
                }
                catch (Exception ex)
                {
                    Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = "اطلاعات نامعتبر است", Title = "", SubTitle = "", MessageType = "Error" };
                    return RedirectToAction("Organization_create", "Prime", routeValues: new { organizationid = myModel.OrganizationId });
                }

            }
            else
            {
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = "اطلاعات نامعتبر است", Title = "خطا", SubTitle = "بروزرسانی سازمان", MessageType = "Error", CallerAction = "OrganizationChart", CallerController = "Prime" };
                return View("MessageView", Session[CommonUnits.GeneralModule.m_MessageModel]);
                //return RedirectToAction("HandleMessage", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);
            }

        }


        public ActionResult Organization_cancel()
        {
            Session[CommonUnits.GeneralModule.m_MessageModel] = null;
            return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_Organization" });
        }


        public ActionResult Organization_delete(int Organizationid = 0)
        {
            Organization myModel = db.Organization.Find(Organizationid);

            return View(myModel);
        }

        public ActionResult Organization_delete_confirm(Organization myModel)
        {
            try
            {

                db.Entry(myModel).State = EntityState.Deleted;
                db.SaveChanges();
            }

            catch
            {

            }


            return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_Organization" });

        }

        /**********************************************
                            Person
         **********************************************/

        public ActionResult Personnel_edit(int personid)
        {
            ViewBag.Organization = db.Organization.ToList();
            Person myModel = db.Person.Find(personid);

            return View(myModel);
        }

        [HttpPost]
        public ActionResult Personnel_edit(Person myModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myModel).State = EntityState.Modified;
                db.SaveChanges();
            }

            //return Personnel();
            return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_Person" });

        }
        public ActionResult Personnel_create(int personid = 0)
        {
            Person myModel = db.Person.Find(personid);
            ViewBag.Organization = db.Organization.ToList();
            myModel = new Person();

            return View("Personnel_edit", myModel);
        }

        [HttpPost]
        public ActionResult Personnel_create(Person myModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    db.Person.Add(myModel);
                    db.SaveChanges();
                }
                catch
                {

                }
            }

            return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_Person" });
        }

        public ActionResult Personnel_cancel()
        {
            return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_Person" });
        }


        public ActionResult Personnel_delete(int personid = 0)
        {
            Person myModel = db.Person.Find(personid);

            return View(myModel);
        }

        public ActionResult Personnel_delete_confirm(Person myModel)
        {
            try
            {

                db.Entry(myModel).State = EntityState.Deleted;
                db.SaveChanges();
            }

            catch
            {

            }

            return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_Person" });

        }

        public ActionResult OrganizationUser_create()
        {
            OrganizationUser myModel = new OrganizationUser();

            ViewBag.Organization = db.Organization.ToList();
            ViewBag.AppUser = db.AppUser.ToList();

            return View("OrganizationUser_edit", myModel);
        }

        [HttpPost]
        public ActionResult OrganizationUser_create(OrganizationUser myModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    db.OrganizationUser.Add(myModel);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    return View("Error", new MessageModel() { Title = "خطا", CallerAction = "OrganizationChart", CallerController = "Prime", MessageBody = ex.Message, SubTitle = "" });
                }
            }

            return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_OrganizationUser" });
        }

        public ActionResult OrganizationUser_edit(int organizationid, int userid)
        {
            OrganizationUser myModel = db.OrganizationUser.Where(m => m.OrganizationId == organizationid).Where(m => m.UserId == userid).First();

            ViewBag.Organization = db.Organization.ToList();
            ViewBag.AppUser = db.AppUser.ToList();

            return View(myModel);
        }

        [HttpPost]
        public ActionResult OrganizationUser_edit(OrganizationUser myModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(myModel).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_OrganizationUser" });
                }
                catch (Exception ex)
                {
                    return View();
                }


            }
            else
            {
                return View("MessageView", myModel);
                //return RedirectToAction("HandleMessage", "Home", new MessageModel() { Title = "خطا", CallerAction = "OrganizationChart", CallerController = "Prime", MessageBody = "", SubTitle = "" });
            }

        }

        public ActionResult OrganizationUser_cancel()
        {
            return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_OrganizationUser" });
        }


        public ActionResult OrganizationUser_delete(int organizationid = 0, int userid = 0)
        {
            OrganizationUser myModel = db.OrganizationUser.Where(m => m.OrganizationId == organizationid).Where(m => m.UserId == userid).First();

            return View(myModel);
        }

        public ActionResult OrganizationUser_delete_confirm(OrganizationUser myModel)
        {
            try
            {

                db.Entry(myModel).State = EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("OrganizationChart", "Prime", routeValues: new { activetab = "Tab_OrganizationUser", organizationid = myModel.OrganizationId });
            }

            catch (Exception ex)
            {
                Session[CommonUnits.GeneralModule.m_CurrentError] = ex;
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "اطلاعات پایه", MessageType = "Error", CallerAction = "OrganizationChart", CallerController = "Prime" };
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);
            }

            

        }

        #endregion

    }


}