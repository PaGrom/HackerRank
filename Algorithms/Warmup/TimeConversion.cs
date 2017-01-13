// https://www.hackerrank.com/challenges/time-conversion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        DateTime dateTime = DateTime.ParseExact(time, "hh:mm:sstt", new System.Globalization.CultureInfo("en-US"));
        Console.WriteLine(dateTime.ToString("HH:mm:ss"));
    }
}
