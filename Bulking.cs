using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionApp
{
    class Bulking
    {
        private int age; // in whole years 
        private double weight; //in kg 
        private double height; // in cm
        private string gender; // m or f 


        //men BMR calc 
        static void MenBMRCalc(int age, double weight, double height, string gender)
        {
            double  menBMR = 66.5 + 13.8 * (weight) + (height) / 6.8 * (age); 
             
        }

        //women BMR calc 
        static void WomenBMRCalc(int age, double weight, double height, string gender)
        {
            double womenBMR = 655.1 + 9.6 * (weight) + 1.9 * (height) / 4.7 * (age);

        }

        
    }
}
