using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{   
    private T _value;
    private T _element;
    private List<T> _lstElements = new List<T>();
    private int pointer;
    public SimpleLinkedList(T value)
    {
        _value = value;
        _lstElements.Add(value);
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
       _lstElements.AddRange(values);
    }

    public T Value 
    { 
        get
        {
            return _lstElements.ElementAt(pointer);
        } 
    }

    public SimpleLinkedList<T> Next
    { 
        get
        {    
            if(_lstElements.Count < 2){
                return null;
            }
            pointer = pointer + 1;
            _value = _lstElements.ElementAt(pointer);
            return new SimpleLinkedList<T>(_lstElements.ElementAt(pointer));
        } 
    }

    public SimpleLinkedList<T> Add(T value)
    {
        _element = value;
        _lstElements.Add(_element);
        return new SimpleLinkedList<T>(_lstElements);
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}