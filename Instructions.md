Steps
1)Select from navigation bar Tools and Download EntityFramework

2)Create your first class with properties u want.In this case Student is our class.
SOS first property which will be the id must have the same name as the class:For example StudentId

3)Create a Database class.Pass a propert on it like this "public DbSet<Student>Students { get; set; }"
  Also make sure this class will inherit all DBContext properties.
  Add on top of page the using:System.Data.Entity 
  
  4)On Package Manager Console .Type:enable-migrations.This will open a new folder on 
  your solution with the name "Migrations->Configuration".Firstly change AytomaticMigrationsEnabled from
  false to true;
  You can also create some synthetic data on Seed Method 
  
  5)Go on Package Manager Console and type:update-database to see your changes 
  
  6)You may now go onto Program.cs and start making CRUD operations as above.
  
  
