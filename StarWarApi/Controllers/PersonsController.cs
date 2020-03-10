using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StarWarApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PersonsController : ApiController
    {
        /// <summary>
        /// getMostActedPerson
        /// </summary>
        /// <returns></returns>
        public string getMostActedPerson()
        {
            try
            {
                using (var db = new StarWar())
                {
                    return db.people
                        .OrderByDescending(s => s.films.Count)
                        .FirstOrDefault()
                        .name;
                }
            }
            catch (Exception ex)
            {

            }
            return string.Empty;
        }
    }
}
