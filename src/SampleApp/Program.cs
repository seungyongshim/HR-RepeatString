using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Linq;
using FluentAssertions;

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        var s1 =  s.Where(x => x == 'a').Count();


        var sLength = s.Count();

        var repeat = n / sLength;

        var mod = n % sLength;

        var s2 = s.Substring(0, (int)mod).Where(x => x == 'a').Count();

        return (s1 * repeat) + s2;
    }

    static void Main(string[] args)
    {
        repeatedString("abcac", 10).Should().Be(4);
        repeatedString("aba", 10).Should().Be(7);
        repeatedString("ceebbcb", 817723).Should().Be(0);
    }
}
