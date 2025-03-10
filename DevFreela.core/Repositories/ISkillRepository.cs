using System;
using DevFreela.core.DTOs;

namespace DevFreela.core.Repositories;

public interface ISkillRepository
{
    Task<List<SkillDTO>> GetAllAsync();
}
