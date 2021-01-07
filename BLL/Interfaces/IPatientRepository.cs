﻿using BLL.Entities;
using BLL.DTO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients();
        List<DocsPatientsDTO> GetDocsPatientsDTO();
        void AddPatient(Patient patient);
    }
}