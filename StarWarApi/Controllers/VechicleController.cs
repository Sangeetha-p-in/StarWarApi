using StarWarApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StarWarApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VechicleController : ApiController
    {
        /// <summary>
        /// getLargestNumberOfVechiclePilots
        /// </summary>
        /// <returns></returns>
        public List<PilotsModel> getLargestNumberOfVechiclePilots()
        {
            try
            {
                using (var db = new StarWar())
                {
                    int result = db.vehicles
                        .OrderByDescending(d => d.people.Count)
                        .FirstOrDefault()
                        .id;
                    return db.planets
                        .Where(y =>
                        (
                            db.people
                            .Where(vehicles => vehicles.vehicles
                                    .Where(whereCondition => whereCondition.id == result)
                                    .Any())
                            .SelectMany(films => films.films)
                            .SelectMany(planets => planets.planets)
                        )
                        .Contains(y))
                        .Select(p => new PilotsModel()
                        {
                            PlanetName = p.name,
                            Count = p.films
                                .SelectMany(ss => ss.people)
                                .Count(),
                            PilotNames = p.films
                                .SelectMany(people => people.people)
                                .Select(i => new PilotsData { 
                                    PilotName = i.name, 
                                    SpeciesName = i.species.FirstOrDefault().name
                                })
                            .ToList()
                        })
                        .OrderByDescending(order => order.Count)
                        .ToList();

                }
            }
            catch (Exception ex)
            {

            }
            return null;

        }
    }
}
