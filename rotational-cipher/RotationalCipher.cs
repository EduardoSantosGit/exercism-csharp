using System;
using System.Linq;

public static class RotationalCipher
{
  public static string Rotate(string text, int shiftKey)
  {

    char transform(char c, char offset) => (char)((c - offset + shiftKey) % 26 + offset);

    char map(char c)
    {
      if (char.IsLetter(c))
      { 
        //test function ternary
        return char.IsLower(c) ? transform(c, 'a') : transform(c, 'A');
      }

      return c;
    }

    return new string(text.Select(map).ToArray());
  }
}