﻿using System.Collections.Generic;
using Application.Core.Data;
using LMPlatform.Models;

namespace LMPlatform.Data.Repositories.RepositoryContracts
{
    public interface IProjectsRepository : IRepositoryBase<Project>
    {
        void DeleteProject(Project project);

        List<Group> GetGroups(int lecturerId = 0);
    }
}
