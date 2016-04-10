namespace decoratorPattern {
	public abstract class Beverage {
		public string description = "Unknown beverage";
		public string Description { get { return description; } }

		public abstract double Cost();
	}
}
