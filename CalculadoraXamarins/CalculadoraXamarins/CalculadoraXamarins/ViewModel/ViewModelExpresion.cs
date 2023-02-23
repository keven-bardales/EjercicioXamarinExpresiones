using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using CalculadoraXamarins.Models;

namespace CalculadoraXamarins.ViewModel
{
    public class ViewModelExpresion : INotifyPropertyChanged
    {

        public string Prueba = "Hola Mundo";
        double num1;
        string operacion;
        double resultado;
        double num2;
        public ViewModelExpresion()
        {
            CrearExpresion = new Command(

                () =>
                {
                    Expresion p1 = new Expresion()
                    {
                        num1 = this.num1,
                        num2 = this.num2
                    };

                    Resultado = p1.sumar();


                    var arg = new PropertyChangedEventArgs(nameof(Resultado));
                    PropertyChanged?.Invoke(this, arg);

                    Operacion = $"El resultado de la suma entre {num1} y {num2} es: {resultado}";
      Prueba = "Hola Mundo";
    }

                );
            }
               

        

        public string Operacion
        {
            get => operacion; set
            {
                operacion = value;
                var arg = new PropertyChangedEventArgs(nameof(Operacion));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public double Resultado
        {
            get => resultado;
            set
            {
                resultado = value;
                var arg = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public double Num2
        {
            get => num2;
            set
            {
                num2 = value;
                var arg = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public double Num1
        {
            get => num1;
            set
            {
                num1 = value;
                var arg = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public Command CrearExpresion { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
