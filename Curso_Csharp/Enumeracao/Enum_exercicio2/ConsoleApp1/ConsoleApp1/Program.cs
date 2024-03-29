﻿using System;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that´s awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new zealand",
                "I´m going to visit this wonderfull country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Have a nice trip");
            Comment c4 = new Comment("Wow that´s awesome");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 13:05:44"),
                "Traveling ",
                "I´m going",
                12);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
