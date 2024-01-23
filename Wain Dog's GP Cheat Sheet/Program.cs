
GpCalculator();

static void GpCalculator()
{
    Console.Clear();

    Console.WriteLine("Wain Dog's GP Cheat Sheet.");
    Console.WriteLine();
    Console.WriteLine("Cost Of Main Element By KG?");
    string CostByWeight = Console.ReadLine();
    double costByWeight = double.Parse(CostByWeight);
    Console.Clear();

    Console.WriteLine("Wain Dog's GP Cheat Sheet.");
    Console.WriteLine();
    Console.WriteLine("£" + costByWeight + " Per KG.");
    Console.WriteLine();
    Console.WriteLine("Weight, In g, Per Portion?");
    string WeightPerPortion = Console.ReadLine();
    double weightPerPortion = double.Parse(WeightPerPortion);
    Console.Clear();

    // cost/1000*weight=costPerPortion
    Console.WriteLine("Wain Dog's GP Cheat Sheet.");
    Console.WriteLine();
    Console.WriteLine("£" + costByWeight + " Per KG.  " + weightPerPortion + "g Per Portion.");
    double pricePerPortion = (costByWeight / 1000 * weightPerPortion);
    Console.WriteLine("£" + pricePerPortion + " Price Per Portion.");
    Console.WriteLine();
    Console.WriteLine("Add £2.50 To Gestimate Acompliments.");
    Console.WriteLine();
    Console.WriteLine("Gestimated Cost Of Final Product. ");
    double finalCostOfDish = pricePerPortion + 2.5;
    Console.WriteLine("£" + finalCostOfDish);
    Console.WriteLine(); 
    Console.WriteLine("What Pacentage% GP are You After?");
    string GPValue = Console.ReadLine();
   

    double gpValue = double.Parse(GPValue);
    double gpFinalDish = gpValue / 100 * finalCostOfDish;


    Console.Clear();
    Console.WriteLine("Wain Dog's GP Cheat Sheet.");
    Console.WriteLine();
    Console.WriteLine("£" + costByWeight + " Per KG.  " + weightPerPortion + "g Per Portion.");
    Console.WriteLine("£" + pricePerPortion + " Price Per Portion.");
    Console.WriteLine();
    Console.WriteLine("Final Dish.");
    Console.WriteLine("£" + gpFinalDish + " for" + gpValue + "% GP.");
    Console.WriteLine();
    Console.WriteLine("Reference GPs.");
    Console.WriteLine();
    Console.WriteLine("70%  £(Example)");
    Console.WriteLine();
    Console.WriteLine("60%  £(Example)");
    Console.WriteLine();
    Console.WriteLine("50%  £(Example)");
    ProgramLoop();
}   
 static void ProgramLoop()
{   
        Console.WriteLine();
        Console.WriteLine("Pres Esc To Close Program");
        Console.WriteLine("Or Space To Restart>");
    static void ExitLoop()
    {
        ConsoleKey keyPressed;

        ConsoleKeyInfo LoopBreak = Console.ReadKey(true);
        keyPressed = LoopBreak.Key;
        if (keyPressed == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
        else if (keyPressed == ConsoleKey.Spacebar)
        {
            GpCalculator();
        }
        else
        {
            ExitLoop();
        }
    }
}


static void GPCalculator()
{
    //CostOfDish = £2 Profit = £3 SalePrice = £5  GP=50% 
    // (£3/£5)*100=60%
    // x/(2+x) = 0.6
    //gp%/100=(Profit?)/SalePrice?)

    //gp%/100 = (Profit?) / (CostOfDish + (Profit?))

    //0.6 = 3/(2+3)
    //(2+X)/X = 0.6 

    //  GP%, CostOfDish, (Profit?), (SalePrice?)

    // CostOfDish + (Profit?) = (SalePrice?)
    // (Profit?) / (salesPrice?) = anser*100= Gp%
}


// fix the maths befor fixing loop.



//convert String Values to float. set paraiters to make safe. 
