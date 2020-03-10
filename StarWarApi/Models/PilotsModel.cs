using System.Collections.Generic;

namespace StarWarApi.Models
{
    /// <summary>
    /// PilotsData
    /// </summary>
    public class PilotsData
    {
        /// <summary>
        /// PilotName
        /// </summary>
        public string PilotName
        {
            get;
            set;
        }

        /// <summary>
        /// SpeciesName
        /// </summary>
        public string SpeciesName
        {
            get;
            set;
        }

    }
    /// <summary>
    /// PilotsModel
    /// </summary>
    public class PilotsModel
    {
        /// <summary>
        /// Name
        /// </summary>
        public string PlanetName
        {
            get;
            set;
        }

        /// <summary>
        /// Count
        /// </summary>
        public int Count
        {
            get;
            set;
        }

        /// <summary>
        /// PilotsData
        /// </summary>
        public List<PilotsData> PilotNames
        {
            get;
            set;
        }
    }



}