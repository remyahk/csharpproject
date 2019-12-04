using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeelattecafemanagement
{
    class Cafe
    {//initialize the member value to double
        //constructor
        public Cafe()
        {
            newcaffelatte = 0.0;
            newcafemisto = 0.0;
            newcappachino = 0.0;
            newflatwhite = 0.0;
            newcaramellatte = 0.0;
            newespresso = 0.0;
            newmocha = 0.0;
            newwhitechocolate = 0.0;
            newchocolatepop = 0.0;
            newcanberry = 0.0;
            newsnowman = 0.0;
            newcheesedanish = 0.0;
            neweggsandwich = 0.0;
            newhamsandwich = 0.0;
            newspinach = 0.0;
            newoatmeal = 0.0;


        }
        //constructor overload
        public Cafe(double caffelatte, double cafemisto, double cappachino, double flatwhite, double caramellatte, double espresso, double mocha, double whitechocolate, double chocolatepop, double canberry, double snowman, double cheesedanish, double eggsandwich, double hamsandwich, double spinach, double oatmeal) 


        {

            newcaffelatte = caffelatte;
            newcafemisto = cafemisto;
            newcappachino = cappachino;
            newflatwhite = flatwhite;
            newcaramellatte = caramellatte;
            newespresso = espresso;
            newmocha = mocha;
            newwhitechocolate = whitechocolate;
            newchocolatepop = chocolatepop;
            newcanberry = canberry;
            newsnowman = snowman;
            newcheesedanish = cheesedanish;
            neweggsandwich = eggsandwich;
            newhamsandwich = hamsandwich;
            newspinach = spinach;
            newoatmeal = oatmeal;

        }
        //accessor function

        public double getcaffelatte()
        {
            return newcaffelatte;
        }
        public double getcafemisto()
        {
            return newcafemisto;
        }
        public double getcappachino()
        {
            return newcappachino;
        }
        public double getflatwhite()
        {
            return newflatwhite;
        }
        public double getcaramellatte()
        {
            return newcaramellatte;
        }
        public double getespresso()
        {
            return newespresso;
        }
        public double getmocha()
        {
            return newmocha;
        }
        public double getwhitechocolate()
        {
            return newwhitechocolate;
        }
        public double getchocolatepop()
        {
            return newchocolatepop;
        }
        public double getcanberry()
        {
            return newcanberry;
        }
        public double getsnowman()
        {
            return newsnowman;
        }
        public double getcheesedanish()
        {
            return newcheesedanish;
        }
        public double geteggsandwich()
        {
            return neweggsandwich;
        }
        public double gethamsandwich()
        {
            return newhamsandwich;
        }
        public double getspinach()
        {
            return newspinach;
        }
        public double getoatmeal()
        {
            return newoatmeal;
        }







        //member variable declared for coffee
        private double newcaffelatte;
        private double newcafemisto;
        private double newcappachino;
        private double newflatwhite;
        private double newcaramellatte;
        private double newespresso;
        private double newmocha;
        private double newwhitechocolate;
        //member variable declared for drink
        private double newchocolatepop;
        private double newcanberry;
        private double newsnowman;
        private double newcheesedanish;
        //member variable declared fro sandwich
        private double neweggsandwich;
        private double newhamsandwich;
        private double newspinach;
        private double newoatmeal;

    }





     

    

}
