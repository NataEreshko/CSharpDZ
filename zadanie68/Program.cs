// http://study.sfu-kras.ru/DATA/docs/ProgramTheory/recurs/fun_akkr.htm
int Foo(int number, int argument)
{
    if (number == 0)
 	   return argument + 1;

    if (argument == 0)
    	return Foo(number - 1, 1);

    return Foo(number - 1, Foo(number, argument -1 ));
}


int n, m;
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine(), out n) ;
Console.Write("Введите число M: ");
int.TryParse(Console.ReadLine(), out m) ;

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Foo(m,n)}");
