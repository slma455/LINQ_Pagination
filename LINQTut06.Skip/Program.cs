﻿using LINQTut06.Shared;
using System;
using System.Linq;

namespace LINQTut06.Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Skip(10);
            q1.Print("Skip first 10 employees");
            var q2 = emps.SkipWhile(x => x.Salary != 214400);
            q2.Print("salary = 214440 ");
            var q3 = emps.SkipLast(10);
            q3.Print("skip last 10 elements");
            //var chank = emps.Chunk(10);
        }
    }
}
