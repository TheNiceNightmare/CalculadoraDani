using CalculadoraDani.Services.Interface;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalculadoraDani.ViewModels
{
    public class CalculadoraPageViewModel : INotifyPropertyChanged
    {
        private int resultado;

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Resultado
        {
            get => resultado; 
            set
            {
                resultado = value;
            }
        }

        public Command HacerCalculo { get; set; }
        public ICalculadoraService CalculadoraService { get; }

        public CalculadoraPageViewModel(ICalculadoraService calculadoraService)
        {
            CalculadoraService = calculadoraService;
            HacerCalculo = new Command(CalcularDosNumeros);
        }

        private void CalcularDosNumeros()
        {
            
            Resultado = CalculadoraService.SumarDosNumeros(Numero1 , Numero2);
        }

        public void OnPropertyChanged([CallerMemberName] String name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
