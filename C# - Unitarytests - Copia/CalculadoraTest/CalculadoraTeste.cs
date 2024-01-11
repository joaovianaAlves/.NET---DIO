using Calculadora.Services;

namespace CalculadoraTest;

public class CalculadoraTeste
{
    private CalculadoraImp _calc;
    Random rand = new Random();

    public CalculadoraTeste()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void TesteSoma()
    {
        //arrange
        int num1 = 5;
        int num2 = 10;

        //act
        int resultado = _calc.somar(num1, num2);

        //assert
        Assert.Equal(15, resultado);
    }
}