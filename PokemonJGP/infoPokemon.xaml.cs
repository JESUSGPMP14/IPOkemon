﻿using System;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PokemonJGP
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class infoPokemon : Page
    {
        public infoPokemon()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is Dictionary<string, object> pokemonProperties)
            {

                myNombre.Text = pokemonProperties["Nombre"].ToString();
                myCategoria.Text = pokemonProperties["Categoría"].ToString();
                myTipo.Text = pokemonProperties["Tipo"].ToString();
                myAltura.Text = pokemonProperties["Altura"].ToString();
                myPeso.Text = pokemonProperties["Peso"].ToString();
                myEvolucion.Text = pokemonProperties["Evolucion"].ToString();
                myDescripcion.Text = pokemonProperties["Descripcion"].ToString();

            }
        }
    }
 
}
