﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                foreach (Phone ph in db.Phones)
                {
                    Console.WriteLine("Id - {0}, Name - {1}", ph.Id, ph.Name);
                }
                Console.ReadLine();
            }
        }
    }
}
