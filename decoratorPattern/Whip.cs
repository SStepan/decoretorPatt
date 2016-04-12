namespace decoratorPattern {
	public class Whip : CondimentDecorator {
		Beverage beverage;

		public Whip(Beverage beverage) {
			this.beverage = beverage;
		}

		public override string Description {
			return beverage.Description() + ", Whip";
		}

		public override double Cost() {
			return .20 + beverage.Cost();
		}
	}
}
