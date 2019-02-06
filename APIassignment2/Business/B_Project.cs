﻿using APIassignment2.Domein;
using APIassignment2.Interfaces;
using APIassignment2.Models;
using APIassignment2.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIassignment2.Business
{
    public class B_Project : Processable<Project, int>, IProcessable<Project>
    {

        public B_Project(Assignment2_DbContext context) : base(context)
        {
        } 

        public Task AddProject(Project project)
        {
            return this.AddData(project);
        }

        public Task<Project> DeleteProject(int id)
        {
            return this.DeleteData(id);
        }

        public IEnumerable<Project> GetProject()
        {
            return this.GetData();
        }

        public Task<Project> GetProject(int id)
        {
            return this.GetDataById(id);
        }

        public Task UpdateProject(int id, Project project)
        {
            return this.UpdateData(id, project);
        }
    }
}
