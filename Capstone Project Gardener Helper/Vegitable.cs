using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capstone_Project_Gardener_Helper
{

    public class Vegitable
    {
        #region ENUMERABLES

            public enum Sun
            {
                fullsun,
                partsun,
                shade,
            }

        #endregion

        #region FIELDS
        private string _name;
        private int _spacing;
        private double _seedDepth;
        private Sun ammountOfSun;
        private double _ph;
        private string _plantTime;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Spacing
        {
            get { return _spacing; }
            set { _spacing = value; }
        }

        public double SeedDepth
        {
            get { return _seedDepth; }
            set { _seedDepth = value; }
        }

        public Sun AmmountOfSun
        {
            get { return ammountOfSun; }
            set { ammountOfSun = value; }
        }
        
        public double Ph
        {
            get { return _ph; }
            set { _ph = value; }
        }

        public string PlantTime
        {
            get { return _plantTime; }
            set { _plantTime = value; }
        }

        #endregion

        #region CONSTRUCTORS
        public Vegitable()
        {

        }

        #endregion

        #region METHODS

        #endregion
    }

}
