﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEpic.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _db;

        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for CRUD operation

        //Get All Employee

        public List<EmployeeInfo> GetEmployee()
        {
            var empList = _db.Employees.ToList();
            return empList;
        }

        //Insert employee info
        public string Create(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            _db.SaveChanges();
            return "Save Successfully";
        }

        //Get Employee By ID
        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s=>s.EmployeeId== id);
            return employee;
        }

        //Update Employee Info
        public string UpdateEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Update(objEmployee);
            _db.SaveChanges();
            return "Update Successfully";
        }

        //Delete Employee
        public string DeleteEmpInfo(EmployeeInfo objEmployee)
        {
            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "Deleted Successfully";
        }
    }
}
