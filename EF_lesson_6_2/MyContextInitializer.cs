using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_2
{
    class MyContextInitializer : DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext db)
        {
            Company c1 = new Company { Name = "Samsung" };
            Company c2 = new Company { Name = "Apple" };
            db.Companies.Add(c1);
            db.Companies.Add(c2);

            db.SaveChanges();

            Phone p1 = new Phone { Name = "Samsung Galaxy S5", Company = c1 };
            Phone p2 = new Phone { Name = "Samsung Galaxy S4", Company = c1 };
            Phone p3 = new Phone { Name = "iPhone5", Company = c2 };
            Phone p4 = new Phone { Name = "iPhone 4S", Company = c2 };

            db.Phones.AddRange(new List<Phone>() { p1, p2, p3, p4 });
            db.SaveChanges();
        }
    }
}
