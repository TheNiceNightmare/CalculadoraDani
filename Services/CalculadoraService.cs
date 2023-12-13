using CalculadoraDani.Models;
using CalculadoraDani.Services.Interface;

namespace CalculadoraDani.Services
{
    public class CalculadoraService : ICalculadoraService
    {

        private bool ValidarNumero(int N)
        { 
            if (N == 0)
            {
                return false;
            }
            return true;            
        
        }
        public int CalcularDosNumeros(int N1, int N2, Operaciones.Operacion operacion)
        {

            if (!ValidarNumero(N1))
            {
                return 0;
            }
            if (!ValidarNumero(N2))
            {
                return 0;
            }
            switch (operacion)
            {
                case Operaciones.Operacion.suma:
                    return N1 + N2;
                case Operaciones.Operacion.Resta:
                    return N1 - N2;
                case Operaciones.Operacion.Multiplicacion:
                    return N1 * N2;
                case Operaciones.Operacion.Division:
                    return N1 / N2;
                default:
                    return 0;
            }
        }

        public int SumarDosNumeros(int N1, int N2)
        {

            if (!ValidarNumero(N1))
            {
                return 0;
            }
            if (!ValidarNumero(N2))
            {
                return 0;
            }
            return N1 +N2;
        
        }

    }
}
