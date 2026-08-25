using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shahriarco.Anbar.Models
{
    public class MessageModel
    {
        [Key]
        public int MessageId { get; set; }

        public string MessageType { get; set; }
        /// <summary>
        /// Success
        /// Info
        /// Warning
        /// Error
        /// </summary>
        
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string MessageBody { get; set; }

        public string BackUrl { get; set; }
    }
}