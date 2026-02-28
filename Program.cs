// initial data

string weaponName = "Colt 1911";
double price = 500;
double stateTax = 8.25;
double myMoney;

Console.WriteLine("Welcome to the gun shop!");
Console.WriteLine($"I have {weaponName} for you, it costs $500 without a State Tax");

// input user funds
Console.WriteLine("How much cash do you have on you?");
Console.Write(">>> ");

while (!double.TryParse(Console.ReadLine(), out myMoney))
{
    Console.WriteLine("Buddy, I need numbers, not words.");
    Console.WriteLine("How much money do you actually have?");
    Console.Write(">>> ");
}

// calculate tax and total cost
double taxAmount = price * (stateTax / 100);
double totalCost = price + taxAmount;

// purchase check
if (myMoney >= totalCost)
{
    myMoney -= totalCost;
    Console.WriteLine($"{weaponName} (tax included) costs ${totalCost}");
    Console.WriteLine($"You've purchased the {weaponName}");
    Console.WriteLine($"Change remaining: ${myMoney:f2}");
    Console.WriteLine("Thanks for purchase, have a nice day!");
}

// case; not enough for TAX ONLY
else if (myMoney >= price)
{
    Console.WriteLine($"Hey, looks like you can afford the {weaponName}, but not the State Tax.");
    Console.WriteLine("You might want to hit the ATM and withdraw some extra cash.");
    Console.WriteLine($"You need another ${(totalCost - myMoney):f2}");
}

// case; no money AT ALL
else
{
    Console.WriteLine("Pal, you don't even have enough for the piece. Come back when you're loaded.");
}

Console.ReadKey();