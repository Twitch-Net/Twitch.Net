﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Twitch.Net.Shared.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach(var item in enumeration)
                action(item);
        }
        
        public static string Join(this IEnumerable<string> source, char separator) 
            => string.Join(separator, source);
        
        public static async Task ForEachAsync<T>(this IEnumerable<T> list, Func<T, Task> func)
        {
            foreach (var value in list)
                await func(value);
        }
    }
}