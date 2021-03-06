﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Entities;

namespace DAL.Repositories
{
    public class VisitRepository : IVisitRepository
    {
        private HContext context;

        public VisitRepository(HContext arg)
        {
            context = arg;
        }

        public void AddVisit(Visit visit)
        {
            context.Visits.Add(visit);
            context.SaveChanges();
        }

        public IEnumerable<Visit> GetVisits()
        {
            return context.Visits;
        }

        public IEnumerable<Visit> GetVisitsByDoctor(int id)
        {
            return context.Visits.Where(x => x.DoctorId == id).OrderBy(x => x.VisitTime);
        }
    }
}
