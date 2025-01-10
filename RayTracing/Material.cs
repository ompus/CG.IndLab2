﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Material
    {
        public float reflection;    // коэффициент отражения
        public float refraction;    // коэффициент преломления
        public float environment;   // коэффициент преломления среды
        public float ambient;       // коэффициент ёмкости фонового освещения
        public float diffuse;       // коэффициент ёмкости диффузного освещения
        public Point clr;         // цвет материала

        public Material(float refl, float refr, float amb, float dif, float env = 1)
        {
            reflection = refl;
            refraction = refr;
            ambient = amb;
            diffuse = dif; 
            environment = env;
        }

        public Material(Material m)
        {
            reflection = m.reflection;
            refraction = m.refraction;
            environment = m.environment;
            ambient = m.ambient;
            diffuse = m.diffuse;
            clr = new Point(m.clr);
        }

        public Material() { }
    }
}
