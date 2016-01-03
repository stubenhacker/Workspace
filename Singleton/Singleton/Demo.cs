using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Demo
    {
        // Statisches Feld vom Typ Demo. Statische Felder können in einer laufenden Anwendung nur einmal existieren.
        private static Demo _Instance = null;
        
        public int Value { get; set; }

        // Parameterloser Standardkonstruktor ist private. Es ist auch kein weiterer Konstruktor definiert.
        // Natürlich kann der private Konstruktor auch innerhalb dieser Klasse aufgerufen werden. 
        // Die Logik der Methode Instance garantiert jedoch, das nur einmal ein Demo-Objekt erzeugt werden kann.
        private Demo() { }

        // Statische Methode / Eigenschaftsmethode / Property auf Feld _Instance
        public static Demo Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Demo();
                }
                return _Instance;
            }
        }
    }
}
