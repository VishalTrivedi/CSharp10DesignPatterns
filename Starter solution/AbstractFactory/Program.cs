using AbstractFactory;

Console.Title = "Abstract Factory";

Console.WriteLine("Belgium");
var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
shoppingCartForBelgium.CalculateCosts();

Console.WriteLine("France");
var franceShoppingCartPurchaseFactory = new FranceShippingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

Console.ReadKey();