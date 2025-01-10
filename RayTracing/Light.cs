using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Light
    {
        public Point point_light;       // точка, где находится источник света
        public Point color_light;       // цвет источника света
         
        public Light(Point p, Point c)
        {
            point_light = new Point(p);
            color_light = new Point(c);
        }

        // Вычисление диффузного освещения локальной модели освещения
        public Point shade(Point hit_point, Point normal, Point color_obj, float diffuse_coef)
        {
            Point dir = point_light - hit_point; dir = Point.norm(dir); // направление луча из источника света в точку попадания луча
            Point diff = diffuse_coef * color_light * Math.Max(Point.scalar(normal, dir), 0);
            return new Point(diff.x * color_obj.x, diff.y * color_obj.y, diff.z * color_obj.z);
        }
    }
}
