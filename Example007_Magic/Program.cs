﻿Console.Clear();
//Console.SetCursorPosition(4, 4);
//Console.WriteLine("+");

int xa = 35;
int ya = 1;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("1");

int xb = 1, yb = 20;

Console.SetCursorPosition(xb, yb);
Console.WriteLine("2");

int xc = 70, yc = 20;

Console.SetCursorPosition(xc, yc);
Console.WriteLine("3");


int x = xb, y = yb;

Console.SetCursorPosition(x, y);
Console.WriteLine("s");

 
 int count = 0;

 while (count < 1000) 
 {
    int what = new Random().Next(0, 3);//[0;3) полуинтервал

    if (what == 0){
        x = (x + xa)/2;
        y = (y +ya)/2;
    }

    if (what == 1){
        x = (x + xb)/2;
        y = (y +yb)/2;
    }

    if (what == 2){
        x = (x + xc)/2;
        y = (y +yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count ++;
 }