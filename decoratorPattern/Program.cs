using System;

namespace decoratorPattern {
	class Program {
		static void Main(string[] args) {
			Beverage bevarage = new Expresso();
			bevarage = new Mocha(bevarage);
			bevarage = new Whip(bevarage);
			Console.WriteLine($"{bevarage.Description}");
			Console.ReadKey();
		}
	}
}
