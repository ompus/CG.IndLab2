﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Sphere: Cube
    {
        private float radius;

        public Pen drawing_pen = new Pen(Color.Black);

        public Sphere(Point p, float r)
        {
            points.Add(p);
            radius = r;
        }

        public static bool ray_sphere_intersection(Ray r, Point sphere_pos, float sphere_rad, out float t)
        {
            Point k = r.start - sphere_pos;
            float b = Point.scalar(k, r.direction);
            float c = Point.scalar(k, k) - sphere_rad * sphere_rad;
            float d = b * b - c;
            t = 0;

            if (d >= 0)
            {
                float sqrtd = (float)Math.Sqrt(d);
                float t1 = -b + sqrtd;
                float t2 = -b - sqrtd;

                float min_t = Math.Min(t1, t2);
                float max_t = Math.Max(t1, t2);

                t = (min_t > EPS) ? min_t : max_t;
                return t > EPS;
            }
            return false;
        }

        public override void set_pen(Pen dw)
        {
            drawing_pen = dw;
        }

        public override bool figure_intersection(Ray r, out float t, out Point normal)
        {
            t = 0;
            normal = null;

            if (ray_sphere_intersection(r, points[0], radius, out t) && (t > EPS))
            {
                normal = (r.start + r.direction * t) - points[0];
                normal = Point.norm(normal);
                figure_material.clr = new Point(drawing_pen.Color.R / 255f, drawing_pen.Color.G / 255f, drawing_pen.Color.B / 255f);
                return true;
            }
            return false;
        }
    }
}
