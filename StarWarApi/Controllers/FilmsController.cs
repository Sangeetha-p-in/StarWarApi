using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StarWarApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FilmsController : ApiController
    {
        /// <summary>
        /// For getting longest crawl
        /// </summary>
        /// <returns></returns>
        public string getLongestCrawl()
        {
            try
            {
                using (var db = new StarWar())
                {
                    return db.films
                        .OrderByDescending(g => g.opening_crawl.Length)
                        .Select(d => d.title)
                        .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return string.Empty;
        }
    }
}
