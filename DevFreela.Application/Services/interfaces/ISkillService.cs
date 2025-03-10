using System;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.interfaces;

public interface ISkillService
{

    List <SkillViewModel> GetAll();
}
