
int a = 1345;
int b = 3;
int c = 8;
int d = 122;
int e = 6;

int max = a;

if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.WriteLine(max);