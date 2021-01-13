package com.company;

import java.util.Scanner;

public class KattisTest {

    public static void main(String[] args)
    {

            double x1, x2, y1, y2, p, absx, absy, total;

            Scanner scanDouble = new Scanner(System.in);

            for (int i = 0; i < 1000; i++)
            {
                x1 = scanDouble.nextDouble();
                if (x1 == 0)
                    break;
                y1 = scanDouble.nextDouble();
                x2 = scanDouble.nextDouble();
                y2 = scanDouble.nextDouble();
                p = scanDouble.nextDouble();
                absx = x1 - x2 > 0 ? x1 - x2 : x2 - x1;
                absy = y1 - y2 > 0 ? y1 - y2 : y2 - y1;
                total = Math.pow(absx, p) + Math.pow(absy, p);

                System.out.println(Math.pow(total, (1/p)));
            }
    }
}


