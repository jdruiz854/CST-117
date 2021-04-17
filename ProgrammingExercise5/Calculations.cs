using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercise5
{

    
    class Calculations
    {
        public Calculations()
        {

        }

        public string calculateBirthStone(string month)
        {
            string stone = "";

            switch(month)
            {
                case "January":
                    stone = "Garnet";
                    break;

                case "February":
                    stone = "Amethyst";
                    break;

                case "March":
                    stone = "Aquamarine";
                    break;

                case "April":
                    stone = "Diamond";
                    break;

                case "May":
                    stone = "Emerald";
                    break;

                case "June":
                    stone = "Alexandrite";
                    break;

                case "July":
                    stone = "Ruby";
                    break;

                case "August":
                    stone = "Peridot";
                    break;

                case "September":
                    stone = "Sapphire";
                    break;

                case "October":
                    stone = "Opal";
                    break;

                case "November":
                    stone = "Citrine";
                    break;

                case "December":
                    stone = "Tanzanite";
                    break;
            }

            return stone;
        }

        public int calculateYear(int year)
        {
            int calc = 0;

            List<int> listOfInts = new List<int>();

            while(year > 0)
            {
                listOfInts.Add(year % 10);
                year = year / 10;
            }

            for(int i = 0; i < listOfInts.Count; i++)
            {
                calc = calc + listOfInts[i];
            }

            return calc;
        }

        public int calculateMonth(string month)
        {
            int calc = 0;

            for(int i = 0; i < month.Length; i++)
            {
                calc = calc + month[i];
            }

            return calc;
        }

        public int calculateDay(int day)
        {
            int calc = 0;

            calc = day * 2;
       
            return calc;
        }

        public int calculateName(string name)
        {
            int calc = 0;

            for(int i = 0; i < name.Length; i++)
            {
                calc = calc + name[i];
            }

            return calc;
        }

        public int convertBirthStone(string stone)
        {
            int calc = 0;

            switch(stone)
            {
                case "Garnet":
                    calc = 5;
                    break;

                case "Amethyst":
                    calc = 10;
                    break;

                case "Aquamarine":
                    calc = 15;
                    break;

                case "Diamond":
                    calc = 20;
                    break;

                case "Emerald":
                    calc = 25;
                    break;

                case "Alexandrite":
                    calc = 30;
                    break;

                case "Ruby":
                    calc = 35;
                    break;

                case "Peridot":
                    calc = 40;
                    break;

                case "Saphhire":
                    calc = 45;
                    break;

                case "Opal":
                    calc = 50;
                    break;

                case "Citrine":
                    calc = 55;
                    break;

                case "Tanzanite":
                    calc = 60;
                    break;
            }
            return calc;
        }

        public int luckNumberCalc(int year, int month, int day, int stone, int name)
        {
            int luckyNumber = 0;

            luckyNumber = (year + month + day + name) / stone;

            return luckyNumber;
        }
            

    }
}
