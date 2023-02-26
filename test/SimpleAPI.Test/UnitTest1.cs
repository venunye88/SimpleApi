using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test;

public class UnitTest1
{
    private static ILogger<WeatherForecastController> _logger=null!;

    WeatherForecastController controller = new WeatherForecastController(_logger);
[Fact]
public void GetReturnsMyName(){
var returnValue=controller.Get(1);
Assert.Equal("Daniel Perez",returnValue.Value);
}

    [Fact]
    public void Test1()
    {

    }
}