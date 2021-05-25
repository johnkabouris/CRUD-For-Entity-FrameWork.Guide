using System.Data.Entity;

namespace CRUD_For_Entity_FrameWork.Guide
{
    class MyDatabase:DbContext
    {
        public DbSet<Student>Students { get; set; }
    }
}
