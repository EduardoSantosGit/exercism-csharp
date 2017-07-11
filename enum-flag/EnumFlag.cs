using System;

public static class EnumFlag
{   
    public enum SslProtocol
    {
        Sslv1=1,
        Sslv2=2,
        Sslv3=4,
        Tls=8,
        Tlsv1=16,
        Tlsv2=32        
    }
}