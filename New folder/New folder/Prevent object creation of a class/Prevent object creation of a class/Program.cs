using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent_object_creation_of_a_class
{
    class Program
    {
        public abstract class Maths
        {

        }
        private class Science
        {

        }
        public static class Social
        {

        }
        public class student
        {
            Maths objMaths = new Maths();
            Science objScience = new Science();
            Social objSocial = new Social();

        }

        static void Main(string[] args)
        {
        }
    }
}
