using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Mvc5.Controllers
{
    public class DataTablesController : Controller
    {
        // GET: DataTables
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult List(DataTableAjaxRequest request)
        {
            var dataList = new List<DataItem>();
            for (int loop = 0; loop < 10; loop++)
            {
                dataList.Add(new DataItem()
                {
                    Id = loop,
                    Name = loop.ToString(),
                    Price = 12.5F,
                    BirthDay = DateTime.Now.AddMinutes(loop),
                    Age = loop + DateTime.Now.Second
                });
            }
            return Json(new DataTableAjaxResponse<DataItem>() { aaData = dataList, iTotalDisplayRecords = dataList.Count, iTotalRecords = dataList.Count,sEcho=request.sEcho }, JsonRequestBehavior.AllowGet);
        }
    }

    public class DataItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Pic { get; set; }
        public DateTime BirthDay { get; set; }
        public int Age { get; set; }
    }

    public class DataTableAjaxResponse<TData>
    {
        /// <summary>
        /// 
        /// </summary>
        public int iTotalRecords { get; set; }
        /// <summary>
        /// 过滤之后，实际的行数。
        /// </summary>
        public int iTotalDisplayRecords { get; set; }
        public IEnumerable<TData> aaData { get; set; }
        public string sColumns { get; set; }
        public string sEcho { get; set; }
    }
    public class DataTableAjaxRequest
    {
        public int iDisplayStart { get; set; }
        public int iDisplayLength { get; set; }
        public int iColumns { get; set; }
        public string sSearch { get; set; }
        public bool bEscapeRegex { get; set; }
        public int iSortingCols { get; set; }
        public string sEcho { get; set; }

    }
}