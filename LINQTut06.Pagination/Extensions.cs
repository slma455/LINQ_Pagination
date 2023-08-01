﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTut06.Pagination
{
    public static class Extensions
    {
       public static IEnumerable <T> paginate <T> (this IEnumerable<T> source , int page =1 , int size =10)
        {
            if (page <= 0)
                page = 1;
            if (size <= 10)
                size = 10;
            var total = source.Count();
            var pages = (int)Math.Ceiling((decimal)total / size);
            var result = source.Skip((page - 1) * size).Take(size).ToList();
            return result;

        }
    }
}
