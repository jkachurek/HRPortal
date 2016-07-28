using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.Repositories
{
    public class JobRepository
    {
        private static List<Job> _jobs;

        #region Ipsums

        private static string saganIpsum = "Cosmic ocean another world hearts of " +
                                           "the stars explorations Orion's sword, " +
                                           "world lets dream of the mind's eye, galaxies " +
                                           "cosmos colonies descended from astronomers " +
                                           "courage of our questions vanquish the " +
                                           "impossible culture prime number? Colonies " +
                                           "vanquish the impossible, muse about dispassionate " +
                                           "extraterrestrial observer a mote of dust suspended " +
                                           "in a sunbeam? Emerged into consciousness Flatland " +
                                           "network of wormholes muse about Cambrian " +
                                           "explosion white dwarf, how far away across the " +
                                           "centuries Apollonius of Perga! Rings of Uranus " +
                                           "cosmic ocean, from which we spring, at the edge " +
                                           "of forever. A very small stage in a vast cosmic " +
                                           "arena concept of the number one and billions upon " +
                                           "billions upon billions upon billions upon billions " +
                                           "upon billions upon billions.";

        private static string corporateIpsum = "Leverage agile frameworks to provide a robust " +
                                               "synopsis for high level overviews. Iterative " +
                                               "approaches to corporate strategy foster " +
                                               "collaborative thinking to further the overall " +
                                               "value proposition. Organically grow the holistic " +
                                               "world view of disruptive innovation via workplace " +
                                               "diversity and empowerment.";

        #endregion

        static JobRepository()
        {
            _jobs = new List<Job>
            {
                new Job
                {
                    Company = "SpaceChem Industries",
                    Title = "Chemical Engineer",
                    Description = saganIpsum,
                    StartDate = new DateTime(2016, 9, 1)
                },
                new Job
                {
                    Company = "Generic Business Company Place",
                    Title = "Cubicle King",
                    Description = corporateIpsum,
                    StartDate = new DateTime(2016, 8, 27)
                }
            };
        }

        public static Job Get(int id)
        {
            return _jobs.FirstOrDefault(j => j.JobId == id);
        }

        public static IEnumerable<Job> GetAll()
        {
            return _jobs;
        }
    }
}