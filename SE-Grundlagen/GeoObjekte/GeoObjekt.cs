using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoObjekte
{
    public abstract class GeoObjekt
    {
        protected System.Drawing.Color _farbe;

        public virtual System.Drawing.Color farbe // objekt.farbe = Color.black; btn.backcolor = objekt.farbe
        {
            get { return _farbe; }
            set { _farbe = value; }
        }

        public abstract void Verschieben(double deltaX, double deltaY);

        public abstract string GetInfo();

    }
}
