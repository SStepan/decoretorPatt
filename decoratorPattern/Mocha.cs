namespace decoratorPattern {
	public class Mocha : Beverage {
		Beverage beverage;

		public Mocha(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string Description {
			get { return beverage.Description() + ", Mocha";}
		}

		public override double Cost() {
			return .20 + beverage.Cost();
		}
	}
}
