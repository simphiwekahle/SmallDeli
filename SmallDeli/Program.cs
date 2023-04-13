using SmallDeli;
using System.Diagnostics;
//loop the fillings

class Program
{
    static void Main(string[] args)
    {
        double vat = 0.14;
        double AmountDue = 0;
        var bag = new Bagle();

        Console.WriteLine("Insert Preffered Flavour: ");
        bag.bagleFlavour = Console.ReadLine();
        bag.baglePrice = 0;

        var fill = new Filling();

        Console.WriteLine("Insert Filling: ");
        fill.fillingOption = Console.ReadLine();
        fill.fillingCost = 0;

        if ((bag.bagleFlavour == "Plain") || (bag.bagleFlavour == "P"))
        {
            bag.baglePrice = 7.50;

            if (fill.fillingOption == "")
            {
                fill.fillingCost = 0;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if ((fill.fillingOption == "Cream Cheese") || (fill.fillingOption == "C"))
            {
                fill.fillingCost = 1.50;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if ((fill.fillingOption == "Salad") || (fill.fillingOption == "S"))
            {
                fill.fillingCost = 3.25;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if (((fill.fillingOption == "Salad") || (fill.fillingOption == "S")) && ((fill.fillingOption == "Cream Cheese") || (fill.fillingOption == "C")))
            {
                fill.fillingCost = 3.25 + 1.50;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            
        }

        else if ((bag.bagleFlavour == "Whole Wheat") || (bag.bagleFlavour == "W"))
        {
            bag.baglePrice = 9.25;

            if (fill.fillingOption == "")
            {
                fill.fillingCost = 0;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if ((fill.fillingOption == "Cream Cheese") || (fill.fillingOption == "C"))
            {
                fill.fillingCost = 1.50;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if ((fill.fillingOption == "Salad") || (fill.fillingOption == "S"))
            {
                fill.fillingCost = 3.25;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if (((fill.fillingOption == "Salad") || (fill.fillingOption == "S")) && ((fill.fillingOption == "Cream Cheese") || (fill.fillingOption == "C")))
            {
                fill.fillingCost = 3.25 + 1.50;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
        }

        else if ((bag.bagleFlavour == "Raisin") || (bag.bagleFlavour == "R"))
        {
            bag.baglePrice = 10.50;

            if (fill.fillingOption == "")
            {
                fill.fillingCost = 0;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if ((fill.fillingOption == "Cream Cheese") || (fill.fillingOption == "C"))
            {
                fill.fillingCost = 1.50;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if ((fill.fillingOption == "Salad") || (fill.fillingOption == "S"))
            {
                fill.fillingCost = 3.25;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
            else if (((fill.fillingOption == "Salad") || (fill.fillingOption == "S")) && ((fill.fillingOption == "Cream Cheese") || (fill.fillingOption == "C")))
            {
                fill.fillingCost = 3.25 + 1.50;
                AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);
            }
        }
        //AmountDue = (bag.baglePrice + fill.fillingCost) * (1 + vat);

        Console.WriteLine("Amount Due To Customer: " + AmountDue);

    }
}
