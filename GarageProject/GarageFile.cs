
using System;
using System.Collections.Generic;
using System.Text;


using System.Linq;
using System.Threading.Tasks;

namespace GarageProject
{
    [Serializable]
    class GarageFile
    {
        private string Name;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        private int ID;
        public int id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        //[NonSerialized]
        //public string additionalInfo;
    }
}
