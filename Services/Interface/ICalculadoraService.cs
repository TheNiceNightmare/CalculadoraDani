using CalculadoraDani.Models;

namespace CalculadoraDani.Services.Interface;

public interface ICalculadoraService
{
    public int SumarDosNumeros(int N1, int N2);
    public int CalcularDosNumeros(int N1, int N2, Operaciones.Operacion operacion);

}