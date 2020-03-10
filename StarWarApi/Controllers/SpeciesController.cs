using StarWarApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StarWarApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SpeciesController : ApiController
    {
        /// <summary>
        /// getMostNumberOfSpecies
        /// </summary>
        /// <returns></returns>
        public List<SpeciesModel> getMostNumberOfSpecies()
        {
            try
            {
                using (var db = new StarWar())
                {
                    int filmId = db.films.OrderByDescending(order => order.people.Count).FirstOrDefault().id;
                    if (filmId > 0)
                    {
                        return db.films
                            .Where(condition => condition.id == filmId)
                            .SelectMany(species => species.species.Select(obj => new SpeciesModel
                            {
                                Name = obj.name,
                                Count = obj.people.Count
                            }))
                           .OrderByDescending(order=>order.Count)
                           .ToList();
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return null;
        }
    }
}
