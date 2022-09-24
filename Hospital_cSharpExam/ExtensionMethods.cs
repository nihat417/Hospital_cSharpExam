﻿namespace Hospital_cSharpExam;

static class ExtensionMethods
{
    static public void Print<T>(this IEnumerable<T> values)
    {
        foreach (var item in values)
        {
            Console.WriteLine(item);
        }
    }
}
