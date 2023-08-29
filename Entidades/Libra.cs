using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorioPoo_SobrecargaDeMetodos.Entidades
{
    internal class Libra
    {
        private float _peso;
        private readonly float _equivalenciaKilo = 2.2046226219f;
        public float getEquivalenciaKilo() => _equivalenciaKilo;

        public Libra(float peso = 10)
        {
            _peso = peso;
        }

        public float GetPeso()
        {
            return _peso;
        }

        public static implicit operator Libra(float value)
        {
            return new Libra(value);
        }

        public static explicit operator Kilo(Libra libra)
        {
            return new Kilo(libra.GetPeso() * libra.getEquivalenciaKilo());
        }

        public static bool operator ==(Libra libra1, Libra libra2)
        {
            return libra1._peso == libra2._peso;
        }

        public static bool operator !=(Libra libra1, Libra libra2)
        {
            return libra1._peso != libra2._peso;
        }

        public static Libra operator +(Libra libra, Kilo kilo)
        {
            return new Libra(libra._peso + (float)kilo);
        }

        public static Libra operator -(Libra libra, Kilo kilo)
        {
            return new Libra(libra._peso - (float)kilo);
        }

        public override string ToString()
        {
            return $"{_peso} L";
        }
    }
}
