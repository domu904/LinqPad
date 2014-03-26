<Query Kind="Program" />

public abstract class A
{
	public abstract void DoWork(int i);
	
	public void SomeWork()
	{
		//dosomething here
	}
}

public abstract class B
{
	public abstract void DoWorkB(int i);
}

public interface C
{
	void Method();
}


public class D : A, C
{
	public override void DoWork(int i)
	{
	}
	
	void C.Method()
	{
	}
}


static void Main()
{
	
}

// Define other methods and classes here
