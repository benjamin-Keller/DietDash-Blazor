using DietDash.Client.Services.Interfaces;
using DietDash.Shared.Patient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DietDash.Client.Services
{
    public class PatientService : IPatientService
    {
        private readonly HttpClient _httpClient;

        public PatientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Patient>> GetPatientsAsync(Guid dietitanId)
        {
            var result = await _httpClient.GetFromJsonAsync<List<Patient>>($"api/v1/dietitian/{dietitanId}/patient");

            return result;
        }
    }
}
