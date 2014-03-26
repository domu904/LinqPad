<Query Kind="Program">
  <Reference Relative="..\modules\Autofac-2.6.1.841\Autofac.Configuration.dll">S:\LinqPad\modules\Autofac-2.6.1.841\Autofac.Configuration.dll</Reference>
  <Reference Relative="..\modules\Autofac-2.6.1.841\Autofac.dll">S:\LinqPad\modules\Autofac-2.6.1.841\Autofac.dll</Reference>
  <Reference Relative="..\modules\Autofac-2.6.1.841\Autofac.Integration.Mef.dll">S:\LinqPad\modules\Autofac-2.6.1.841\Autofac.Integration.Mef.dll</Reference>
  <Reference Relative="..\modules\Autofac-2.6.1.841\Autofac.Integration.Mvc.dll">S:\LinqPad\modules\Autofac-2.6.1.841\Autofac.Integration.Mvc.dll</Reference>
  <Reference Relative="..\modules\Autofac-2.6.1.841\Autofac.Integration.Wcf.dll">S:\LinqPad\modules\Autofac-2.6.1.841\Autofac.Integration.Wcf.dll</Reference>
  <Reference Relative="..\modules\Autofac-2.6.1.841\Autofac.Integration.Web.dll">S:\LinqPad\modules\Autofac-2.6.1.841\Autofac.Integration.Web.dll</Reference>
  <Namespace>Autofac.Integration</Namespace>
  <Namespace>Autofac.Configuration</Namespace>
  <Namespace>Autofac</Namespace>
  <Namespace>Autofac.Integration.Web</Namespace>
  <Namespace>Autofac.Integration.Wcf</Namespace>
</Query>

void Main()
{	
	var builder = new ContainerBuilder();	
	builder.RegisterType<Address>();
	builder.RegisterType<Customer>();	
	builder.Register(c => new Customer(c.Resolve<Address>()));
	var container = builder.Build();
	
	var customerA = container.Resolve<Customer>();
	
	customerA.InitializeAddress();
	customerA.GetAddress();	
}

public class Customer
{
	Address address;
	
	public Customer(Address address)
	{	
		this.address = address;
	}
	
	public void InitializeAddress()
	{
		address.address = "12 Palm Beach";
	}
	
	public void GetAddress()
	{
		address.address.Dump();
	}
}

public class Address
{
	public Address()
	{
	}
	
	public string address {get; set;}
	public string state {get; set;}
	public string zipcode {get; set;}
}