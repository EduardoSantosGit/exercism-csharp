using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class Garden
    {
    private List<string> inomes = new List<string>();
    private string iniPlantas;    
    public Garden(IEnumerable<string> children, string windowSills)
    {
       inomes.AddRange(children);
       iniPlantas = windowSills;
    }

    public IEnumerable<Plant> GetPlants(string child)
    {
        Dictionary<string,Plant> hashPlantas = new Dictionary<string,Plant>();
        List<Plant> plantasL1 = new List<Plant>();
        List<Plant> plantasL2 = new List<Plant>();
        List<Plant> plantas = new List<Plant>();

        hashPlantas.Add("V",Plant.Violets);
        hashPlantas.Add("R",Plant.Radishes);
        hashPlantas.Add("C",Plant.Clover);
        hashPlantas.Add("G",Plant.Grass);

        List<string> p1 = new List<string>();
        List<string> p2 = new List<string>();

        int quebra = iniPlantas.IndexOf("\n");
        string linha1 = iniPlantas.Substring(0,quebra);
        string linha2 = iniPlantas.Substring(quebra+1,iniPlantas.Length-quebra-1);
        int pos = 0;

       inomes.Sort();

       if(!inomes.Contains(child)){
           return plantas.ToArray();
       }

       for(int i=0;i<inomes.Count;i++){
           if(inomes[i] == child){
              pos = i;
           }
       }
       pos = pos * 2;
       
       string letras1 = linha1.Substring(pos,2);
       string letras2 = linha2.Substring(pos,2);

       for(int i=0;i<letras1.Length;i++){
          foreach(var item in hashPlantas){
              if(item.Key == letras1[i].ToString()){
                 plantas.Add(item.Value);
              }
          }
       }

       for(int i=0;i<letras2.Length;i++){
          foreach(var item in hashPlantas){
              if(item.Key == letras2[i].ToString()){
                 plantas.Add(item.Value);
              }
          }
       }
       return plantas;
    }

    public static Garden DefaultGarden(string windowSills)
    {   
        var garden = new Garden(new [] { "Alice", "Bob", "Charlie", "David",
        "Eve","Fred","Ginny","Harriet", "Ileana","Joseph","Kincaid","Larry"}, windowSills);
        return garden;
    }
}