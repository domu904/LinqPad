<Query Kind="Program" />

void Main()
{
	var s1 = Singleton.GetInstance();
	var s2 = Singleton.GetInstance();
	
	if(s1 == s2)
		Console.WriteLine("objects are the same instance");

}

public class Singleton
{
	private static Singleton instance;
	
	public Singleton()
	{
	}
	
	public static Singleton GetInstance()
	{
		if(instance == null)
			instance = new Singleton();
		
		return _instance;
	}

}


public class DoubleLockSingleton
{
	//Declared volatile to ensure the instance completes 
	//before the instance variable can be accessed. 
	private static volatile DoubleLockSingleton instance;
	
	//Uses syncRoot instance to lock on rather than locking 
	//on the type itself, to avoid deadlocks.
	private static object syncRoot = new Object();
	
	private DoubleLockSingleton() {}
	
	public static DoubleLockSingleton Instance
	{
		get
		{
		
			if(Instance == null)
			{
				lock(syncRoot)
				{
					if(instance == null)
						instance = new DoubleLockSingleton();
				}
			}		
		}
	}
	
	

}