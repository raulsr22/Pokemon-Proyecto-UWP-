using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ControlDeUsuarioPokemon
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void cambiarVida(object sender, RangeBaseValueChangedEventArgs e)
        {
            gengarControl.Vida = e.NewValue;

        }

        private void cambiarEnergía(object sender, RangeBaseValueChangedEventArgs e)
        {
            gengarControl.Energia = e.NewValue;

        }

        private void EjecutarAtaqueFuerte(object sender, RoutedEventArgs e)
        {
            gengarControl.animacionAtaqueFuerte();
        }

        private void EjecutarAtaqueFlojo(object sender, RoutedEventArgs e)
        {
            gengarControl.animacionAtaqueFlojo();
        }

        private void EjecutarDefensa(object sender, RoutedEventArgs e)
        {
            gengarControl.animacionDefensa();
        }

        private void EjecutarDescansar(object sender, RoutedEventArgs e)
        {
            gengarControl.animacionDescasar();
        }

        private void activarIddle(object sender, RoutedEventArgs e)
        {
            gengarControl.activarAniIdle(true);
        }

        private void desactivarIddle(object sender, RoutedEventArgs e)
        {
            gengarControl.activarAniIdle(false);
        }

        private void desactivarCansado(object sender, RoutedEventArgs e)
        {
            gengarControl.animacionNoCansado();
        }

        private void activarCansado(object sender, RoutedEventArgs e)
        {
            gengarControl.animacionCansado();
        }

        private void activarHerido(object sender, RoutedEventArgs e)
        {
            gengarControl.animacionHerido();
        }

        private void desactivarHerido(object sender, RoutedEventArgs e)
        {
            gengarControl.animacionNoHerido();
        }

        private void desactivarEscudo(object sender, RoutedEventArgs e)
        {
            gengarControl.verEscudo(false);
        }

        private void activarEscudo(object sender, RoutedEventArgs e)
        {
            gengarControl.verEscudo(true);
        }

        private void verFondo(object sender, RoutedEventArgs e)
        {
            gengarControl.verFondo(true);
        }

        private void noVerFondo(object sender, RoutedEventArgs e)
        {
            gengarControl.verFondo(false);
        }

        private void noVerFilaVida(object sender, RoutedEventArgs e)
        {
            gengarControl.verFilaVida(false);
        }

        private void verFilaVida(object sender, RoutedEventArgs e)
        {
            gengarControl.verFilaVida(true);
        }

        private void verFilaEnergia(object sender, RoutedEventArgs e)
        {
            gengarControl.verFilaEnergia(true);
        }

        private void noVerFilaEnergía(object sender, RoutedEventArgs e)
        {
            gengarControl.verFilaEnergia(false);
        }

        private void verPocimaVida(object sender, RoutedEventArgs e)
        {
            gengarControl.verPocionVida(true);
        }

        private void noVerPocimaVida(object sender, RoutedEventArgs e)
        {
            gengarControl.verPocionVida(false);
        }

        private void noVerPocimaEnergia(object sender, RoutedEventArgs e)
        {
            gengarControl.verPocionEnergia(false);
        }

        private void verPocimaEnergia(object sender, RoutedEventArgs e)
        {
            gengarControl.verPocionEnergia(true);
        }

        private void verNombrePokemon(object sender, RoutedEventArgs e)
        {
            gengarControl.verNombre(true);
        }

        private void noVerNombrePokemon(object sender, RoutedEventArgs e)
        {
            gengarControl.verNombre(false);
        }
    }
}

