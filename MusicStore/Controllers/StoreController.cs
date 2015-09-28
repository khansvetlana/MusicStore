using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            //return "Hello from Store.Index()";
            var genres = new List<Genre>
            {
                new Genre {Name = "Blues"},
                new Genre {Name = "Jazz"},
                new Genre {Name = "Rock"}
            };

            return View(genres);
        }

        // GET: /Store/Browse?genre=Rock

        public ActionResult Browse(string genre)
        {
            //return "Hello from Store.Browse()";
            //return HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            var genreModel = new Genre {Name = genre};
            return View(genreModel);
        }

        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            //return "Hello from Store.Details()";
            //return "Store.Details, Id = " + id;
            var album = new Album {Title = "Album " + 5};
            return View(album);
        }
    }
}
