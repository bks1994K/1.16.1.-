﻿using System.Reflection.Metadata.Ecma335;

bool IdenticalDigitsInTwoNumbers(int a, int b)
{
    int tmpa = -1;
    int tmpb = -2;
    int bb = 0;
    while (tmpa != tmpb && a != 0)
    {
        tmpa = a % 10;
        a /= 10;
        bb = b;

        while (tmpa != tmpb && bb != 0)
        {
            tmpb = bb % 10;
            bb /= 10;
        }

        if (tmpa == tmpb)
        {
            return true;
        }
        else if (tmpa != tmpb)
        {
            return false;
        }
        return bool;
    }
}

bool number = IdenticalDigitsInTwoNumbers();
Console.WriteLine(number);