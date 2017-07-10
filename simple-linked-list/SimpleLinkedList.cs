using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{   
    private T _value;
    public SimpleLinkedList(T value)
    {
        _value = value;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public T Value 
    { 
        get
        {
            return _value;
        } 
    }

    public SimpleLinkedList<T> Next
    { 
        get
        {
            throw new NotImplementedException("You need to implement this function.");
        } 
    }

    public SimpleLinkedList<T> Add(T value)
    {
        throw new NotImplementedException("You need to implement this function.");
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