using Calculadora.Controllers;

namespace TDD_Pratica;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int num1, int num2, int esperado)
    {
        //Arrange
       CalculadoraControllers calc = new CalculadoraControllers();     
        //Act
       int resultado = calc.Somar(num1, num2);
        //Assert
       Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(10, 5, 5)]
    public void TesteSubtrair(int num1, int num2, int esperado)
    {
        //Arrange
       CalculadoraControllers calc = new CalculadoraControllers();     
        //Act
       int resultado = calc.Subtrair(num1, num2);
        //Assert
       Assert.Equal(esperado, resultado);
    }
    
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int esperado)
    {
        //Arrange
       CalculadoraControllers calc = new CalculadoraControllers();     
        //Act
       int resultado = calc.Multiplicar(num1, num2);
        //Assert
       Assert.Equal(esperado, resultado);
    }

    
    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(8, 4, 2)]
    public void TesteDivisao(int num1, int num2, int esperado)
    {
        //Arrange
       CalculadoraControllers calc = new CalculadoraControllers();     
        //Act
       int resultado = calc.Dividir(num1, num2);
        //Assert
       Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TestarDivisaoPorZero()
    {
        // Arrange
            CalculadoraControllers calc = new CalculadoraControllers();

    
        // Then
        Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3,0)
            );
    }


    [Fact]
    public void TestarHistorico_NaoVazia()
    {
        // Arrange
            CalculadoraControllers calc = new CalculadoraControllers();

        //Act
        calc.Somar(1,1);
        calc.Subtrair(2, 1);
        calc.Multiplicar(3, 2);
        calc.Dividir(10, 5);

        var lista = calc.Historico();

    
        // Then
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}