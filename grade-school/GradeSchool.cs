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

    public IEnumerable<string> Grade(int grade){   
        nomeAlunos.AddRange(hashAlunos.Where(x => x.Value == grade).Select(x => x.Key));
        nomeAlunos.Sort();
        return nomeAlunos;
    }

    public IEnumerable<string> addSorter(Dictionary<string,int> values){
         
         List<int> distinctGrade = new List<int>();
         List<string> names = new List<string>();
         List<string> namesSort = new List<string>();
     
        distinctGrade.AddRange(values.Select(x => x.Value).ToList().Distinct());
        distinctGrade.Sort();

        foreach(var key in distinctGrade){
            foreach(var hash in hashAlunos){
                if(key == hash.Value){
                    names.Add(hash.Key);
                }
            }
            names.Sort();
            namesSort.AddRange(names);
            names.Clear();
        }
        return namesSort;
    }
}