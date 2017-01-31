﻿using System;


namespace ExpFinance
{
    static class Number2Lettres
    {
         private static string Convertir(int chiffre)
        {
         
            int centaine, dizaine, unite, reste, y;
            bool dix = false;
            string lettre = "";
            //strcpy(lettre, "");
 
            reste = chiffre;
 
            for (int i = 1000000000; i >= 1; i /= 1000)
            {
                y = reste / i;
                if (y != 0)
                {
                    centaine = y / 100;
                    dizaine = (y - centaine * 100) / 10;
                    unite = y - (centaine * 100) - (dizaine * 10);
                    switch (centaine)
                    {
                        case 0:
                            break;
                        case 1:
                            lettre += "cent ";
                            break;
                        case 2:
                            if ((dizaine == 0) && (unite == 0)) lettre += "deux cents ";
                            else lettre += "deux cent ";
                            break;
                        case 3:
                            if ((dizaine == 0) && (unite == 0)) lettre += "trois cents ";
                            else lettre += "trois cent ";
                            break;
                        case 4:
                            if ((dizaine == 0) && (unite == 0)) lettre += "quatre cents ";
                            else lettre += "quatre cent ";
                            break;
                        case 5:
                            if ((dizaine == 0) && (unite == 0)) lettre += "cinq cents ";
                            else lettre += "cinq cent ";
                            break;
                        case 6:
                            if ((dizaine == 0) && (unite == 0)) lettre += "six cents ";
                            else lettre += "six cent ";
                            break;
                        case 7:
                            if ((dizaine == 0) && (unite == 0)) lettre += "sept cents ";
                            else lettre += "sept cent ";
                            break;
                        case 8:
                            if ((dizaine == 0) && (unite == 0)) lettre += "huit cents ";
                            else lettre += "huit cent ";
                            break;
                        case 9:
                            if ((dizaine == 0) && (unite == 0)) lettre += "neuf cents ";
                            else lettre += "neuf cent ";
                            break;
                    }// endSwitch(centaine)
 
                    switch (dizaine)
                    {
                        case 0:
                            break;
                        case 1:
                            dix = true;
                            break;
                        case 2:
                            lettre += "vingt ";
                            break;
                        case 3:
                            lettre += "trente ";
                            break;
                        case 4:
                            lettre += "quarante ";
                            break;
                        case 5:
                            lettre += "cinquante ";
                            break;
                        case 6:
                            lettre += "soixante ";
                            break;
                        case 7:
                            dix = true;
                            lettre += "soixante ";
                            break;
                        case 8:
                            lettre += "quatre-vingt ";
                            break;
                        case 9:
                            dix = true;
                            lettre += "quatre-vingt ";
                            break;
                    } // endSwitch(dizaine)
 
                    switch (unite)
                    {
                        case 0:
                            if (dix) lettre += "dix ";
                            break;
                        case 1:
                            if (dix) lettre += "onze ";
                            else lettre += "un ";
                            break;
                        case 2:
                            if (dix) lettre += "douze ";
                            else lettre += "deux ";
                            break;
                        case 3:
                            if (dix) lettre += "treize ";
                            else lettre += "trois ";
                            break;
                        case 4:
                            if (dix) lettre += "quatorze ";
                            else lettre += "quatre ";
                            break;
                        case 5:
                            if (dix) lettre += "quinze ";
                            else lettre += "cinq ";
                            break;
                        case 6:
                            if (dix) lettre += "seize ";
                            else lettre += "six ";
                            break;
                        case 7:
                            if (dix) lettre += "dix-sept ";
                            else lettre += "sept ";
                            break;
                        case 8:
                            if (dix) lettre += "dix-huit ";
                            else lettre += "huit ";
                            break;
                        case 9:
                            if (dix) lettre += "dix-neuf ";
                            else lettre += "neuf ";
                            break;
                    } // endSwitch(unite)
 
                    switch (i)
                    {
                        case 1000000000:
                            if (y > 1) lettre += "milliards ";
                            else lettre += "milliard ";
                            break;
                        case 1000000:
                            if (y > 1) lettre += "millions ";
                            else lettre += "million ";
                            break;
                        case 1000:
                            lettre += "mille ";
                            break;
                    }
                } // end if(y!=0)
                reste -= y * i;
                dix = false;
            } // end for
            if (lettre.Length == 0) lettre += "zero";
 
            return lettre;
        }
 
        public static string NumberConverted(double number)
        {
            string integerLetter = "", decimalLetter ="", formattedLetter = "";
            int decimalValue=0;
 
            var splits = number.ToString("N2").Split(',');
             
            int intergerValue = Convert.ToInt32(splits[0]);
 
            if (splits.Length > 1) //get decimal value
            {
 
                var decimalPart = splits[1] ;
                const int partPrecision = 2;
                string result;
 
                if (partPrecision != decimalPart.Length)
                {
                    var decimalPartLength = decimalPart.Length;
 
                    for (var i = 0; i < partPrecision - decimalPartLength; i++)
                    {
                        decimalPart += "0"; //Fix for 1 number after decimal ( 10.5 , 1442.2 , 375.4 ) 
                    }
 
                    result = String.Format("{0}.{1}", decimalPart.Substring(0, partPrecision), decimalPart.Substring(partPrecision, decimalPart.Length - partPrecision));
 
                    result = (Math.Round(Convert.ToDecimal(result))).ToString("");
                }
                else
                    result = decimalPart;
 
                for (int i = 0; i < partPrecision - result.Length; i++)
                {
                    result += "0";
                }
 
                decimalValue = Convert.ToInt32(result);
 
            }
 
            #region integerValuevalue
 
            if(intergerValue != 0)
                integerLetter = Convertir(intergerValue);
 
            #endregion
 
            #region decimalvalue
 
            if(decimalValue != 0)
                decimalLetter = Convertir(decimalValue);
 
            #endregion
 
            if ((decimalValue != 0 && intergerValue != 0))
                formattedLetter = integerLetter + " Dinars et " + decimalLetter + " Centimes";
 
            if ((decimalValue == 0 && intergerValue != 0))
                formattedLetter = integerLetter + " Dinars";
 
            if ((decimalValue == 0 && intergerValue == 0))
                formattedLetter = "Zéro Dinars";
 
            return formattedLetter.ToUpper();
        }
 
    }

    
}
