using System;
using Dapper;
using DevFreela.Application.Services.interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Application.Services.Implementations
{


    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly string _connectionString;
        public SkillService(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }

        public List<SkillViewModel> GetAll()
        {

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var scrippt = "SELECT Id, Description FROM Skills";

                return sqlConnection.Query<SkillViewModel>(scrippt).ToList();
            }
            /* var skills = _dbContext.Skills;

            var skillsViewModel = skills
                .Select(s => new SkillViewModel(s.Id, s.Description))
                .ToList();

            return skillsViewModel; */
        }
    }

}