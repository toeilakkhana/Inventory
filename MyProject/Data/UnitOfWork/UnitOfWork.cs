using MyProject.Data.Context;
using MyProject.Data.Repositories;
using MyProject.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationRepository ApplicationRepo { get; set; }
        private ConfigRepository ConfigRepo { get; set; }
        private CustomerRepository CustomerRepo { get; set; }
        private EmployeeRepository EmployeeRepo { get; set; }
        private CollectProjectRepository CollectProjectRepo { get; set; }
        private UserRepository UserRepo { get; set; }

        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public ApplicationRepository ApplicationRepository => ApplicationRepo == null ? new ApplicationRepository(_dbContext) : ApplicationRepository;
        public CustomerRepository CustomerRepository => CustomerRepo == null ? new CustomerRepository(_dbContext) : CustomerRepository;
        public ConfigRepository ConfigRepository => ConfigRepo == null ? new ConfigRepository(_dbContext) : ConfigRepository;
        public EmployeeRepository EmployeeRepository => EmployeeRepo == null ? new EmployeeRepository(_dbContext) : EmployeeRepository;
        public CollectProjectRepository CollectProjectRepository => CollectProjectRepo == null ? new CollectProjectRepository(_dbContext) : CollectProjectRepository;

        public UserRepository UserRepository => UserRepo == null ? new UserRepository(_dbContext) : UserRepository;

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
    }
}
