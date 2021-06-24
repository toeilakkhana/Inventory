using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.Data.Context;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public List<Employee> MptAllEmployeePer(string en)
        //{
        //    return _context.Employees.FromSqlRaw(@$"SELECT * FROM MPT_ALL_EMPLOYEE WHERE EMPL_CODE = '" + en + "' AND PERSON_TYPE_ID <> 33 and CURRENT_EMPLOYEE_FLAG = 'Y';").ToList();
        //}

        //public List<Employee> MptAllEmployee()
        //{
        //    return _context.Employees.FromSqlRaw(@$"SELECT * FROM MPT_ALL_EMPLOYEE").ToList();
        //}

        //public List<Employee> MptAllEmployee2Parameter(string en , string id)
        //{
        //    return _context.Employees.FromSqlRaw(@$"SELECT * FROM MPT_ALL_EMPLOYEE WHERE EMPL_CODE = '" + en + "' AND CURRENT_EMPLOYEE_FLAG = '"+ id +"'").ToList();
        //}


        //public void AddPermission(string role, string en, string autsetup)
        //{
        //    string a = @"INSERT INTO SETUP_SECURE (SUBJECT, ROLE_GROUP, EMPL_CODE , AUT_CREATE, AUT_EDIT , AUT_DELETE, AUT_APPROVE, AUT_SETUP,PLANT,STEP_APPV) 
        //   VALUES ('ES','" + role + "','" + en + "','N','N','N','N','" + autsetup + "','WN','0')";
        //    ExecuteSQL(a);
        //}

        //public void UpdatePermission(string en, string autsetup)
        //{
        //    string a = @"UPDATE SETUP_SECURE  SET AUT_SETUP = '" + autsetup + "' WHERE EMPL_CODE = '" + en + "' AND SUBJECT ='ES'";
        //    ExecuteSQL(a);
        //}

        //public void DeletePermission(string en)
        //{
        //    string a = @"DELETE FROM SETUP_SECURE WHERE SUBJECT = 'ES' AND EMPL_CODE ='" + en + "'";
        //    ExecuteSQL(a);
        //}


    }
}
