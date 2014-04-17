<Query Kind="Program" />

void Main()
{

}

public abstract class AbstractFactory
{
	public abstract AbstractProductA CreateProductA();
	public abstract AbstractProductB CreateProductB();
}

public class ConcreteFactory1: AbstractFactory
{
	public override AbstractProductA CreateProductA()
	{
		return new ProductA1();
	}
	
	public override AbstractProductB CreateProductB()
	{
		return new ProductB1();
	}
	
		
}

public abstract class AbstractProductA
{
}


public abstract class AbstractProductB
{
	public abstract void Interact(AbstractProductA a);
}

public class ProductA1: AbstractProductA
{

}

public class ProductB1: AbstractProductB
{
	public override void Interact(AbstractProductA a)
	{
		Console.WriteLine(this.GetType().Name + 
		" interacts with " + a.GetType().Name);
	}
}