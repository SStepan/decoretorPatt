namespace decoratorPattern {
	public class Expresso : Beverage {
		public Expresso()
		{
			description = "Expresso";
		}
		public override double Cost()
		{
			return 1.99;
		}
		public override Description()
		{
			return description;
		}
	}
}
