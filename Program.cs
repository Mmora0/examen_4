
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//1

bool valor1 = true;
bool valor2 = true;
bool valor3 = true;

bool result = valor1 && valor2;
Console.WriteLine(result);

//#2

bool valor1 = true;
bool valor2 = true;
bool valor3 = true;

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 && valor2 && valor3;
Console.WriteLine(resultOr);

//#3

bool valor1 = false;
bool valor2 = false;
bool valor3 = false;

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);

//#4

var (valor1, valor2, valor3) = (true, true, false);

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultAndOr = (valor1 && valor2) || valor3; Console.WriteLine(resultAndOr);

//#5

var (valor1, valor2, valor3) = (true, true, false);

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultAnd0r = (valor1 && valor2) || valor3;
Console.WriteLine(resultAnd0r);

bool resultNot = !valor1;

Console.WriteLine(resultNot);

//#6

var (valor1, valor2, valor3) = (true, true, false);

bool resultand = valor1 && valor2 && valor3;
Console.WriteLine(resultand);

bool resultor = valor1 || valor2 || valor3;
Console.WriteLine(resultor);

bool resultandor = (valor1 && valor2) || valor3;
Console.WriteLine(resultandor);

bool resultNot = !valor1;
Console.WriteLine(resultNot);

bool resultXor = valor1 ^ valor2;
Console.WriteLine(resultXor);

//#7

var (valor1, valor2, valor3) = (18, 1, 2);
Console.WriteLine("los valores son:" + valor1 + valor2 + valor3);

/*
== igual a  
!= diferente a  
> mayor que
< menor que
>= mayor o igual
<= menor o igual
*/

bool resultado1 = valor1 == valor2;

Console.WriteLine("El resultado de la compración valor1 == valor2: " + resultado1);

//#8

var (valor1, valor2, valor3) = (10, 1, 2);

Console.WriteLine("los valores son:" + valor1 + valor2 + valor3);


bool resultado1 = valor1 == valor2;
Console.WriteLine("El resultado de la compración valori = valor2: " + resultado1);

bool resultado2 = valor1 != valor2;

Console.WriteLine("El resultado de la compración valori != valor2: " + resultado2);