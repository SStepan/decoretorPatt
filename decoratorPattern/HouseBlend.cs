namespace decoratorPattern {
	public class HouseBlend : Beverage {
		public HouseBlend()
		{
			description = "HouseBlend";
		}
		public override double Cost() {
			return .89;
		}
		public override string Description()
		{
			return description;
		}
	}
}
