namespace CRUD_For_Entity_FrameWork.Guide.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUD_For_Entity_FrameWork.Guide.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CRUD_For_Entity_FrameWork.Guide.MyDatabase context)
        {
            Student stu1 = new Student() { FirstName = "Jack", LastName = "Nicholson", TuitionFees = 2250 };
            Student stu2 = new Student() { FirstName = "Johnny", LastName = "Depp", TuitionFees = 2550 };
            Student stu3 = new Student() { FirstName = "Keanu", LastName = "Reeves", TuitionFees = 2250 };

            context.Students.AddOrUpdate(stu => stu.LastName, stu1, stu2, stu3);
        }
    }
}
