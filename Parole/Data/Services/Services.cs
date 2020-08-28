using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Parole.Models;

namespace Parole.Data.Services
{
    public class Services : IServices
    {
        private readonly ApplicationDbContext _db;
        public Services(ApplicationDbContext db)
        {
            _db = db;
        }

        public async void DeletSubject(int? id)
        {
            if(id == null)
                Debug.WriteLine("id is empty , it does'nt contains anything");

            try
            {
                var subjectToDel = await _db.FindAsync<Subject>(id);

                _db.Subjects.Remove(subjectToDel);
                await _db.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                Debug.WriteLine("Ooops! Something goes wrong there!");
                throw;
            }
        }

        public Subject DisplaySubject(int? id)
        {
            if (id == null)
            {
               
                Debug.WriteLine("Id is null");
            }

            try
            {
                var subjectToDisplay = _db.Find<Subject>(id);
                return subjectToDisplay;
            }
            catch (System.Exception)
            {
                Debug.WriteLine("there nothing to display");
                throw;
                
            }
        }

        public void NewResponse(int idSubject, Response response)
        {
            throw new System.NotImplementedException();
        }

        public async void NewSubject(Subject subject)
        {
            if (!Object.ReferenceEquals(subject,null))
            {
                try
                {
                    await _db.AddAsync<Subject>(subject);
                    await _db.SaveChangesAsync();
                }
                catch (System.Exception)
                {
                    Debug.WriteLine("insert error");
                    throw;
                }
            }
        }

        public IEnumerable<Response> ResponsesList()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Subject> SubjectList()
        {
            try
            {
              var subjects = _db.Subjects.ToList();

              if (Object.ReferenceEquals(subjects,null))
              {
                  return null;
              }

              return subjects;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}