using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;
using LabSQLEF.Logic;

namespace LabSQLEFWeb.Controllers
{
    

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeesController : ApiController
    {
       
        private EmployeeLogic emp = new EmployeeLogic();

        
        public List<LabSQLEF.Entities.Employees> GetEmployees()
        {
            try
            {
                return emp.GetAll();
            }
            catch(Exception ex)
            {
                NotFound();
                return null;
            }
        }

        
        
       
        public IHttpActionResult GetEmployees(int id)
        {
            List<LabSQLEF.Entities.Employees> employees = emp.GetAll();
            var result = employees.FirstOrDefault(e => e.EmployeeID == id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);    
        }

        
        public IHttpActionResult PutEmployees(LabSQLEF.Entities.Employees employees)
        {
            try
            {
                emp.Update(employees);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
            
        }

        
        [HttpPost]
        public IHttpActionResult PostEmployees(LabSQLEF.Entities.Employees employees)
        {
            try
            {
                emp.Add(employees);
                return Ok();
            }
            catch(Exception ex)
            {
                return NotFound();
            }

        }

        
        
        public IHttpActionResult DeleteEmployees(int id)
        {
            try
            {
                emp.Delete(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }

    }
}