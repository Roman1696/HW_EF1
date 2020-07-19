

namespace DataAccessLayer.Models
{
    public class Pupils
    {
        public Pupils()
        {
            Schools = new School();
            Teacher = new ClassroomTeacher();
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public virtual School Schools { get; set; }
        public virtual ClassroomTeacher Teacher { get; set; }
    }
}
