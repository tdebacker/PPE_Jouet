using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTR_PPE_Jouet
{
    public class TrancheAge
    {
        //attributs
        private int id;
        private int ageMin;

        //construct
        public TrancheAge(int id, int ageMin)
        {
            this.id = id;
            this.ageMin = ageMin;
        }

        //get/set
        public int getId()
        {
            return id;
        }


        public int getAgeMin()
        {
            return ageMin;
        }

        public void setAgeMin(int ageMin)
        {
            this.ageMin = ageMin;
        }

        public override string ToString()
        {
            return " "+getAgeMin();
        }
    }
}
