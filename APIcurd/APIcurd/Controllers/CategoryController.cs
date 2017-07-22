using APIcurd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using iWeb.DbLib;
using System.Data;

namespace APIcurd.Controllers
{
   
    public class CategoryController : ApiController
    {
        JobEntities database = new JobEntities();
        [Route("api/GetName")]
        [HttpGet]
        public string GetString()
        {
            return "Shashika";
        }

        [Route("api/SelectCatogories")]
        [HttpGet]
        [EnableCors(origins:"*", headers:"*",methods:"*")]
        public List<Category> ReturnCatogories()
        {
            List<Category> cp = new List<Category>();
            //cp.Add(new Category { Id = 1, Code = "c001", Name = "Category 1" });
            //cp.Add(new Category { Id = 2, Code = "c002", Name = "Category 2" });
            //cp.Add(new Category { Id = 3, Code = "c003", Name = "Category 3" });

            DBUtilities db = new DBUtilities();
            DataTable dt = db.Select("SelectAllCategories");
            foreach (DataRow r in dt.Rows)
            {
                Category c = new Category();
                c.Code = r["Code"].ToString();
                c.Description = r["Description"].ToString();
                c.Id =Convert.ToInt32( r["Id"].ToString());
                c.ImageURL = r["ImageURL"].ToString();
                c.IsActive =Convert.ToBoolean( r["IsActive"].ToString());
                c.Name = r["Name"].ToString();
                c.OrderId =Convert.ToInt32( r["OrderId"].ToString());

                cp.Add(c);
            }
            return cp;
        }


        [Route("api/InsertCategory")]
        [HttpPost]
        public void InsertCategory(Category cato)
        {
            Category catoToInsert=cato;
        }

        [Route("api/jobs")]
        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<jobdet> jobCatogories()
        {
            jobdet cp = new jobdet();
            List<jobdet> ll = new List<jobdet>();
            ////cp.Add(new Category { Id = 1, Code = "c001", Name = "Category 1" });
            ////cp.Add(new Category { Id = 2, Code = "c002", Name = "Category 2" });
            ////cp.Add(new Category { Id = 3, Code = "c003", Name = "Category 3" });

            //DBUtilities db = new DBUtilities();
            //DataTable dt = db.Select("SelectAllCategories");
            //foreach (DataRow r in dt.Rows)
            //{
            //    Category c = new Category();
            //    c.Code = r["Code"].ToString();
            //    c.Description = r["Description"].ToString();
            //    c.Id = Convert.ToInt32(r["Id"].ToString());
            //    c.ImageURL = r["ImageURL"].ToString();
            //    c.IsActive = Convert.ToBoolean(r["IsActive"].ToString());
            //    c.Name = r["Name"].ToString();
            //    c.OrderId = Convert.ToInt32(r["OrderId"].ToString());

            //    cp.Add(c);
            //}
            List<JobDec> co = database.JobDecs.ToList();
            foreach (var item in co)
            {
                cp.JobID = item.JobID;
                cp.JobCategory = item.JobCategory;
                cp.JobDescription = item.JobDescription;
                cp.JobName = item.JobName;
                ll.Add(cp);
            }
            return ll;
        }


    }
}
