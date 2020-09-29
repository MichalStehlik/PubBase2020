using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PubBase.Models;

namespace PubBase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _db;

        public List<Pub> Pubs { get; set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            Pubs = _db.Pubs.ToList();
        }

        /*
         * _db.Pubs.Add(new Pub { Name = "", Municipality = ""});
         * _db.SaveChanges();
         */

        /*
         * var pub = _db.Pubs.Find(id);
         * var pubList = _db.Pubs.Where(p => p.Municipality == "Liberec").ToList();
         * 
         * var pub = _db.Pubs.Where(p => p.Name == "U tupé vydry").FirstOrDefault();
         * var pub = _db.Pubs.SingleOrDefault(p => p.Name == "U tupé vydry");
         * 
         * if (pub != null) { } 
         * pub.Name = "U chytrého hrocha";
         * _db.SaveChanges();
         * 
         * _db.Pubs.Remove(pub);
         * _db.SaveChanges();
         * */
    }
}
