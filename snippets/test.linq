<Query Kind="Program" />


delegate int Transformer(int i);

void Main()
{
	Transformer sqr = x => {
							x++;
							return x * x; };
	Console.WriteLine(sqr(3));
}
