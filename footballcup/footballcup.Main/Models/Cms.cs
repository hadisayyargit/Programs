using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace footballcup.Models
{
   
    public class Cms
    {        

        [Key]
        public int CmsId { get; set; }

        public int CupId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishDate { get; set; }
        public string PictureFile { get; set; }
        public int AuthorId { get; set; }
        public int TargetReceiver { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// True: Chat ,Opinion ,ViewPoint
        /// False: News ,Blog   
        /// </summary>
        public bool IsChat { get; set; }
        public bool IsHotNews { get; set; }
        public bool IsSlider { get; set; }
        public bool IsMessage { get; set; }

        /// <summary>
        /// 0:unread(defaut)
        /// 1:Readed
        /// 2:Like
        /// 3:dislike
        /// </summary>
        public byte ReadStatus { get; set; }
        public Nullable<int> ParentCmsId { get; set; }

        footballcupDbContext db = new footballcupDbContext();

        public void Insert()
        {
            try
            {
                db.Cms.Add(this);
                int n = db.SaveChanges();
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Update()
        {
            try
            {
                db.Entry(this).State = System.Data.Entity.EntityState.Modified;
                int n = db.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete()
        {
            try
            {
                db.Cms.Remove(this);
                int n = db.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    [NotMapped]
    public partial class CmsView : Cms
    {
        public byte[] AuthorThumbnail { get; set; }
        public string AuthorDs { get; set; }
        public string TargetDs { get; set; }
    }
}