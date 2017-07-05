using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        string numeros = "1234567890";
        if(numeros.Contains(input)){
            return 1;
        } 
        return null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {   
        string numeros = "1234567890";
        if(numeros.Contains(input)){
            result = 1;
            return true;
        }
        result = 0;
        return false;
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        disposableObject.Dispose();
        throw new Exception();
    }
}
