using System.Collections.Generic;
using Parole.Models;

namespace Parole.Data.Services
{
    public interface IServices
    {
        ///this scope is for subjects only
         IEnumerable<Subject> SubjectList();
         void NewSubject(Subject subject);
         void DeletSubject(int? id);

         Subject DisplaySubject(int? id);


         ///this scope is for responses
         IEnumerable<Response> ResponsesList();
         void NewResponse(int idSubject,Response response);
         
    }
}