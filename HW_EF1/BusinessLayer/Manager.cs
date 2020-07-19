using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BusinessLayer
{
    public class Manager
    {
        public IEnumerable<Pupils> GetInfoAboutPupil()
        {
            using (var context = new PupilsContext())
            {
                return context.Pupils.ToList();
            }
        }
        public IEnumerable<Pupils> DeletePupilById(int id)
        {
            using (var context = new PupilsContext())
            {
                var pupils = context.Pupils.Where(o => o.ID == id).FirstOrDefault();
                context.Pupils.Remove(pupils);
                context.SaveChanges();
                return context.Pupils.ToList();
            }
        }      

        public IEnumerable<Pupils> Insert()
        {
            var context = new PupilsContext();
            var pupils = new List<Pupils>()
            {
                new Pupils() {ID= 2,FirstName="Vasya",LastName="Pupkin",Phone="0987543222"}
            };
            var school = new School() { Name = "KHNURE", Id = 2 };
            var teacher = new ClassroomTeacher() { LastName = "MIchailuk", FirstName = "Ivan", Id = 2 };
                      
            
            context.Pupils.AddRange(pupils);
            context.Schools.Add(school);
            context.Teachers.Add(teacher);
            
            context.SaveChanges();

            return context.Pupils.ToList();

        }
    }
}
