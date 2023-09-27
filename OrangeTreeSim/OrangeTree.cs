using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;
        private int eatOrange;
        public int count;
        public void SetAge(int Age)
        {
            this.age = Age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetHeight(int Height)
        {
            this.height = Height;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }
        public bool GetTreeAlive()
        {
            return treeAlive;
        }
        public int GetOrangesEaten()
        {

            return count;
        }
        public int GetNumOranges()
        {
            return numOranges - count;
        }
        public void EatOrange(int eatOrange)
        {
            this.eatOrange = eatOrange;
            count += eatOrange;
        }
        public void OneYearPasses()
        {
            if (treeAlive == true)
            {
                count = 0;
                age++;
                if (age < 80) { height += 2; }
                if (age > 1 && age < 80) 
                { 
                    numOranges=(age-1)*5; 
                }
                if (age >=80) { treeAlive = false; }
                
            }
            else if (treeAlive == false)
            {
                numOranges = 0;
                age++;
                count = 0;
            }
            
        }
        
        
    }

}
