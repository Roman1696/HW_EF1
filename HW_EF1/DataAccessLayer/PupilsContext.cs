using DataAccessLayer.Models;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class PupilsContext:DbContext
    {
        public PupilsContext() : base("DefaultConnection")
        { }

        public DbSet<Pupils> Pupils { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<ClassroomTeacher> Teachers { get; set; }
    }
}
