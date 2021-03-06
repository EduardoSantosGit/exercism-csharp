﻿using System;
using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    public static string Line(int line)
    {   
        Dictionary<int, string> lines = frases();
        return lines.Where(x => x.Key == line).Select(x => x.Value).FirstOrDefault();
        /* 
        string frase = "";
        Dictionary<int, string> lines = frases();
        foreach(var item in lines){
            if(line == item.Key){
                frase = item.Value;
            }
        }
        return frase;*/
    }

    public static string AllLines()
    {     
        List<string> listValues = new List<string>();
        listValues.AddRange(frases().Values);
        return listValues.Aggregate((a , b) => a + "\n" +  b);
       
       /* 
        var etset =  lines.Select(x => x.Value.Select(s => s)).FirstOrDefault(); 
        string nfrases = "";
        Dictionary<int, string> lines = frases();
        foreach(var item in lines){
            if(lines.Count != item.Key){
                nfrases += item.Value + "\n";
            } else {
                nfrases += item.Value;
            }
        }
        return nfrases;*/
    }

    public static Dictionary<int, string> frases(){
        Dictionary<int, string> hashFrases = new Dictionary<int, string>();
        hashFrases.Add(1, "For want of a nail the shoe was lost.");
        hashFrases.Add(2, "For want of a shoe the horse was lost.");
        hashFrases.Add(3, "For want of a horse the rider was lost.");
        hashFrases.Add(4, "For want of a rider the message was lost.");
        hashFrases.Add(5, "For want of a message the battle was lost.");
        hashFrases.Add(6, "For want of a battle the kingdom was lost.");
        hashFrases.Add(7, "And all for the want of a horseshoe nail.");
        return hashFrases;
    }
}