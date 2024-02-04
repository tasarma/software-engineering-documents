.
namespace DESIGNPATTERNS.CSharp_Example.BuilderPattern
{
	public interface IToyBuilder
	{
		void SetModel();
		void SetHead();
		void SetLimbs();
		void SetBody();
		void SetLegs();
		Toy GetToy();
	}

}