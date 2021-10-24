using DietDash.Shared.Patient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DietDash.Client.Services.Interfaces
{
    public interface IPatientService
    {
        Task<List<Patient>> GetPatientsAsync(Guid dietitanId);
    }
}
