using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class GraphicCircle : Circle
    {
        // -------------- Konstruktoren
        public GraphicCircle() : base(0,0,0) {}       
        public GraphicCircle(int radius) : base(radius, 0,0) { }
        public GraphicCircle(int radius, double x, double y) : base(radius, x, y) { }

        // ---------------- Instanzmethoden --------------------------------
        public void Draw()
        {
            Console.WriteLine("Der Kreis wird gezeichnet.");
        }
    }
}
