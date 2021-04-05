using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Calories
    {
        public int fatCalories(int gramsFat)
        {
            int caloriesFromFat;
            
            caloriesFromFat = gramsFat * 9;
            
            return caloriesFromFat;
        }

        public int carbCalories(int gramsCarbs)
        {
            int caloriesFromCarbs;
            
            caloriesFromCarbs = gramsCarbs * 4;

            return caloriesFromCarbs;
        }
    }
}
