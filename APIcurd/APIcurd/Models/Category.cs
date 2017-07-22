using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIcurd.Models
{
    public class Category
    {
        public int Id { get; set; }

        
        public string Code { get; set; }

       
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        public int? OrderId { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public DateTime? ModifiedDatetime { get; set; }

        public int? CreatedUserId { get; set; }

        public int? ModifiedUserId { get; set; }

       
    }
}