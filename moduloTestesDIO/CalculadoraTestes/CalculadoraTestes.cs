using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //Variaveis
        int num1 = 5;
        int num2 = 10;

        //ACao
        int resultado = _calc.Somar(num1, num2);

        //Validacao
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10com10ERetornar20()
    {
        //Variaveis
        int num1 = 10;
        int num2 = 10;

        //ACao
        int resultado = _calc.Somar(num1, num2);

        //Validacao
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificar4EhParERetornarVerdadeiro()
    {
        //Variaveis
        int num = 4;

        //ACao
        bool resultado = _calc.EhPar(num);

        //Validacao
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeSaoParesERetornarVerdadeiro(int numero)
    {
        //ACao
        bool resultado = _calc.EhPar(numero);

        //Validacao
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2,4})]
    [InlineData(new int[] {6,8,10})]
    public void DeveVerificarSeSaoTodosParesERetornarVerdadeiro(int[] numeros)
    {
        //ACao e Validacao
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}