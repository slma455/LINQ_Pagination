using LINQTut06.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LINQTut06.Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var page = 0;
            var size = 10;

            Console.WriteLine("result per page");
            if(int.TryParse(Console.ReadLine(), out int resultPerPage))
            {
                size = resultPerPage;
            }
            Console.WriteLine("page no..:");
            if(int.TryParse(Console.ReadLine(),out int pageNo))
            {
                page = pageNo;
            }
            var emps = Repository.LoadEmployees();
            var result = emps.paginate(page, size);
            var resultCount = result.Count();
            var startRecord = ((page - 1) * size) + 1;
            var endRecord = resultCount < size ? startRecord + resultCount - 1 : size * (page - 1);

            result.Print($"showing employees {startRecord}{endRecord}");





            Console.ReadKey();
        }
    }
}
