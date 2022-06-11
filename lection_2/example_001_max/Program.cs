int a1 = 1;
int a2 = 20;
int a3 = 3;
int b1 = 4;
int b2 = 50;
int b3 = 6;
int c1 = 7;
int c2 = 8;
int c3 = 9;
int max = a1;

if(a2 > max) max = a2;
if(a3 > max) max = a3;
if(b1 > max) max = b1;
if(b2 > max) max = b2;
if(b3 > max) max = b3;
if(c1 > max) max = c1;
if(c2 > max) max = c2;
if(c3 > max) max = c3;

Console.WriteLine(max);