using DietDash.Shared;
using DietDash.Shared.Patient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DietDash.Server.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/v1/dietitian/{dietitianId}/[controller]")]
    public class PatientController : ControllerBase
    {
        static List<Dietitian> dietitans = new List<Dietitian>
        {
            new Dietitian
            {
                Id = Guid.NewGuid(),
                FirstName = "Inge",
                LastName = "Jung",
                IdNumber = "987456321456",
                EmailAddress = "Test@Test.com"
            }
        };

        List<Patient> patients = new List<Patient>
        {
            new Patient
            {
                DietitianId = dietitans[0].Id,
                FileName = "TestFileName",
                FirstName = "TestFirst",
                SecondName = "TestSecond",
                LastName = "TestLast",
                DateOfBirth = DateTime.Now.AddYears(-21),
                CreatedOn = DateTime.Now,
                CreatedBy = "TestDietitian",
                IdNumber = "9844569875548",
                Anthropology = anthropologies[0]
            },
            new Patient
            {
                DietitianId = dietitans[0].Id,
                FileName = "TestFileNameSecond",
                FirstName = "TestFirstSecond",
                LastName = "TestLastSecond",
                DateOfBirth = DateTime.Now.AddYears(-18),
                CreatedOn = DateTime.Now,
                CreatedBy = "TestDietitian",
                IdNumber = "9844569875548",
                Anthropology = anthropologies[1]
            }
        };

        static List<Anthropology> anthropologies = new List<Anthropology>
        {
            new Anthropology
            {
                Height = 185,
                Weight = 66,
            },
            new Anthropology
            {
                Height = 168,
                Weight = 56,
            }
        };

        [HttpGet(Name = "GetPatients")]
        public async Task<ActionResult> Get(Guid dietitianId)
        {
            return Ok(patients);
        }
    }
}
