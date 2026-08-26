using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ShakelliReportsUI.DataLayer.Models
{
    public class MessageModel
    {
        [Key]
        public int MessageId { get; set; }

        public string MessageType { get; set; }
        /// <summary>
        /// Warning
        /// Success
        /// Info
        /// Error
        /// </summary>
        public string Title { get; set; }
        
        public string SubTitle { get; set; }

        public string MessageBody { get; set; }

        public string CallerController { get; set; }

        public string CallerAction { get; set; }


    }


}