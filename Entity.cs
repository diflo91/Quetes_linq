using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Entity
    {
        public class CougarsBlanc
        {
            int NbCougars;
            private void _NbCougars()
            {

                for (int i = 0; i <= 3; i++)
                {
                    NbCougars = i;
                }
               
            }
             
        }


        public class TigresBlanc
        {
            int NbTigre;
            private void _NbTigre()
            {

                for (int i = 0; i <= 100; i++)
                {
                    NbTigre = i;
                }


            }

        }


        public class TortuesAlbinos
        {
            int NbTortue;
            private int _NbTigre()
            {

                for (int i = 0; i <= 15; i++)
                {
                    NbTortue = i;
                }
                return NbTortue;
            }

        }
    }
}
