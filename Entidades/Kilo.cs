using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace recuperatorioPoo_SobrecargaDeMetodos.Entidades
{
    internal class Kilo
    {
        private float _peso;
        private readonly float _equivalenciaLibra= 0.45359237f;

        public float getPeso() => _peso;
        public float getEquivalenciaLibra() => _equivalenciaLibra;

        public Kilo(float peso)
        {
            _peso = peso;
        }
        public Kilo() : this(10) { }
        public static implicit operator float(Kilo k)
        {
            return k.getPeso();
        }
        public static explicit operator Libra(Kilo kilo)
        {
            return new Libra(kilo.getPeso() * kilo._equivalenciaLibra) ;
        }

        public static bool operator ==(Kilo k1, Kilo k2)
        {
            return k1.getPeso() == k2.getPeso();
        }

        public static bool operator !=(Kilo k1, Kilo k2)
        {
            return !(k1 == k2);
        }

        public static Kilo operator +(Kilo k1, Kilo k2)
        {
            return new Kilo(k1.getPeso() + k2.getPeso());
        }
        public static Kilo operator -(Kilo k1, Kilo k2)
        {
            return new Kilo(k1.getPeso() - k2.getPeso());
        }

        public static Kilo operator +(Kilo k,  Libra l)
        {
            return k + (Kilo)l;
        }
        
        public static Kilo operator -(Kilo k, Libra l)
        {
            return k - (Kilo)l;
        }
        
    }
}
