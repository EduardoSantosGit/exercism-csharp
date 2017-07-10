using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
  private T[] _elements;

  public SimpleLinkedList(T value)
  {
    _elements = new T[] {value};
  }

  public SimpleLinkedList(IEnumerable<T> values){
    _elements = values.ToArray();
  }

  public T Value {
    get
    {
      return _elements[0];
    }
  }

  public SimpleLinkedList<T> Next
  {
    get
    {
      if (_elements.Length > 1) {
        return new SimpleLinkedList<T>(_elements.Skip(1));
      }
      return null;
    }
  }

  public SimpleLinkedList<T> Add(T value){
    return new SimpleLinkedList<T>(_elements.Concat(Enumerable.Repeat(value, 1)));
  }

  public IEnumerator<T> GetEnumerator(){
    foreach (var x in _elements) {
      yield return x;
    }
  }

  IEnumerator IEnumerable.GetEnumerator(){
    return _elements.GetEnumerator();
  }
}