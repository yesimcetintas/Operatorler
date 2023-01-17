// See https://aka.ms/new-console-template for more information

// atama ve işlemli atama
int x=3;
int y=3;

y=y+2;
Console.WriteLine(y);

y+=2;
Console.WriteLine(y);

y/=1;
Console.WriteLine(y);

x*=2;
Console.WriteLine(x);

// mantıksal operatörler

bool isSuccess = true;
bool isCompoleted = false;

if(isSuccess && isCompoleted){
    Console.WriteLine("Perfect!");
}
if(isSuccess || isCompoleted){
    Console.WriteLine("Great!");
}
if(isSuccess && !isCompoleted){
    Console.WriteLine("Fine!");
}

//ilişkisel operatörler

int a = 3;
int b = 4;

bool sonuc = a<b;
Console.WriteLine(sonuc);

sonuc = a>b;
Console.WriteLine(sonuc);

sonuc = a>=b;
Console.WriteLine(sonuc);

sonuc = a<=b;
Console.WriteLine(sonuc);

sonuc = a==b;
Console.WriteLine(sonuc);

sonuc = a!=b;
Console.WriteLine(sonuc);

// aritmetik operatörler

int sayi1 = 10;
int sayi2 = 5;

int sonuc1 = sayi1/sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi1*sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 + sayi2;
Console.WriteLine(sonuc1);
sonuc1 = ++sayi1;
Console.WriteLine(sonuc1);

// % mod alma

int sonuc2= 20%3;

Console.WriteLine(sonuc2);
