using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veloz.Models.Widgets
{

    public class Tiles
    {
        public string Title { get; set; }
        public fa_icons Icon { get; set; }
        public double ValorPeriodoAtual { get; set; }
        public double ValorPeriodoAnterior { get; set; }
        public Colors DefaultColor { get; set; }
        public string TituloPeriodo { get; set; }

        public Tiles()
        { }

        public Tiles(string title, fa_icons icon)
        {
            this.Title = title;
            this.Icon = icon;
            this.DefaultColor = Colors.gray;
            this.TituloPeriodo = "No período anterior";
        }

        public Tiles(string title, fa_icons icon, double valorAtual, double valorAnterior)
        {
            this.Title = title;
            this.Icon = icon;
            this.ValorPeriodoAtual = valorAtual;
            this.ValorPeriodoAnterior = valorAnterior; 
            this.DefaultColor = Colors.gray;
            this.TituloPeriodo = "No período anterior";
        }


        public Tiles(string title, fa_icons icon, double valorAtual, double valorAnterior, string tituloPeriodo)
        {
            this.Title = title;
            this.Icon = icon;
            this.ValorPeriodoAtual = valorAtual;
            this.ValorPeriodoAnterior = valorAnterior;
            this.DefaultColor = Colors.gray;
            this.TituloPeriodo = tituloPeriodo;
        }


        public Tiles(string title, fa_icons icon, double valorAtual, double valorAnterior, string tituloPeriodo, Colors corTitulo)
        {
            this.Title = title;
            this.Icon = icon;
            this.ValorPeriodoAtual = valorAtual;
            this.ValorPeriodoAnterior = valorAnterior;
            this.DefaultColor = Colors.gray;
            this.TituloPeriodo = tituloPeriodo;
            this.DefaultColor = corTitulo;
        }
    }
}