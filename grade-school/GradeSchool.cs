using System;
using System.Collections.Generic;
using System.Linq;

public class School
{   
    Dictionary<string, int> hashAlunos = new Dictionary<string,int>(); 
    List<string> nomeAlunos = new List<string>();
    public void Add(string student, int grade)
    {
        hashAlunos.Add(student,grade);
    }

    public IEnumerable<string> Roster()
    {
        return addSorter(hashAlunos);
    }

    public IEnumerable<string> Grade(int grade)
    {
        foreach(var value in hashAlunos){
            if(value.Value == grade){
                nomeAlunos.Add(value.Key);
            }
        }
        nomeAlunos.Sort();
        return nomeAlunos;
    }

    public IEnumerable<string> addSorter(Dictionary<string,int> values){
         List<int> tempGrade = new List<int>();
         List<int> distinctGrade = new List<int>();
         List<string> nomes = new List<string>();
         List<string> nomesSort = new List<string>();

        foreach(var key in values){
            tempGrade.Add(key.Value);
        }

        distinctGrade.AddRange(tempGrade.Distinct());

        distinctGrade.Sort(); 
        foreach(var key in distinctGrade){
            foreach(var hash in hashAlunos){
                if(key == hash.Value){
                    nomes.Add(hash.Key);
                }
            }
            nomes.Sort();
            nomesSort.AddRange(nomes);
            nomes.Clear();
        }
        return nomesSort;
    }
}