using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using StudentInformation.Models;

namespace StudentInformation.Repository
{

    public class StudentRepository
    {
        private readonly StudentDBEntities _entities = new StudentDBEntities();
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public object Insert(List<Student> stusList)
        {
           
                try
                {
                    foreach (var student in stusList)
                    {
                        _entities.Students.Add(student);
                        _entities.SaveChanges();
                    }

                }
                catch (Exception exception)
                {
                     
                    throw exception;
                    return false;
                }
            
            return true;

        }
    }
}