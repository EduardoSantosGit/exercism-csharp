﻿using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = phrase.Replace("-"," ").Replace(":","");
        return new string(phrase.ToUpper()
                     .Split(' ')
                     .Select(x => x.First())
                     .ToArray());
    }
}