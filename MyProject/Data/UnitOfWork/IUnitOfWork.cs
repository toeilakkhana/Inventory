using Microsoft.AspNetCore.Mvc;
using MyProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        ApplicationRepository ApplicationRepository { get; }
        ConfigRepository ConfigRepository { get; }
        CustomerRepository CustomerRepository { get; }
        EmployeeRepository EmployeeRepository { get; }
        CollectProjectRepository CollectProjectRepository { get; }
        UserRepository UserRepository { get; }
        int Commit();
    }
}
