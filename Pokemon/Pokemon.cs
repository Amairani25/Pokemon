using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public enum tipotipo
    {
        fuego,
        agua,
        tierra,
        planta,
    }
    public enum tipoesatados
    {
        envenenado,
        somnoliento,
        paralizado,
        congelado,
        quemado,
    }
    public enum pokerus
    {
        si,
        no,
    }

    public class Pokemon
    {
        public int numero { get; set; }
        public string nombre { get; set; }
        public int hp { get; set; }
        public tipotipo tipo { get; set; }
        public tipoesatados estado { get; set; }
        public pokerus pokeruss { get; set; }
    }
}

