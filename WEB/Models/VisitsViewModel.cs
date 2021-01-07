using BLL.Entities;
using BLL.DTO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class VisitsViewModel
    {
        public IEnumerable<Visit> Visits { get; set; }
        public List<DocsPatientsDTO> DocsPatientsDTO { get; set; }
    }
}