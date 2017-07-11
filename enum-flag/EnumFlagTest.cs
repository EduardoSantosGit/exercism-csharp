using Xunit;

public class EnumFlagTest
{
    [Fact]
    public void CreateFlag_WithTwoValues()
    {
        var supportedSsl = EnumFlag.SslProtocol.Sslv1 
                            | EnumFlag.SslProtocol.Sslv2;

        var checkSupportedSslv1 = supportedSsl & EnumFlag.SslProtocol.Sslv1;

        Assert.Equal(EnumFlag.SslProtocol.Sslv1, checkSupportedSslv1);
    }

    [Fact]
    public void CheckWhenProtocolHasSslv3ReturnsFalse()
    {
        var supportedSsl = EnumFlag.SslProtocol.Sslv1 
                            | EnumFlag.SslProtocol.Sslv2;

        var checkSupportedSslv1 = supportedSsl & EnumFlag.SslProtocol.Sslv1;

        Assert.NotEqual(EnumFlag.SslProtocol.Sslv3, checkSupportedSslv1);
    }

    
    [Fact]
    public void CheckWhen2Within5()
    {
        Assert.NotEqual(2, 2 & 5);
    }

    [Fact]
    public void CheckWhen2Within12()
    {
        Assert.Equal(2, 2 & 6);
    }

    
    [Fact]
    public void CheckWhen2Within1()
    {
        var s = 6; // 110
        var a = s >> 1; // 11

        Assert.Equal(3, a);
    }
    
    [Fact]
    public void CheckWhen1001Within100()
    {
        var s = 9; // 1001
        var a = s >> 1; // 100

        Assert.Equal(4, a);
    }

    [Fact]
    public void CheckWhen1001Within10010()
    {
        var s = 9; // 1001
        var a = s << 2; // 10010

        Assert.Equal(36, a);
    }
}