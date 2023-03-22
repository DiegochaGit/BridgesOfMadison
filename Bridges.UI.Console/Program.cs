using Bridges.Logic;

var myBridges = new MyString[]
{
    new MyString("**"),                   //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*=*"),                  //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*==*"),                 //b=t, c=t, sim=t, pr=t, v=t 
    new MyString("*===*"),                //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*=+=*"),                //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*=++=*"),               //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*==+==*"),              //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*==++==*"),             //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*==+==+==*"),           //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*==+===+==*"),          //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*==+====+==*"),         //b=t, c=t, sim=t, pr=f, v=f
    new MyString("*==+===+===+==*"),      //b=t, c=t, sim=t, pr=f, v=f
    new MyString("*==++==++==*"),         //b=t, c=t, sim=t, pr=t, v=t
    new MyString("*===+==+===*"),         //b=t, c=t, sim=t, pr=f, v=f
    new MyString("*==*==*==*"),           //b=f, c=t, sim=t, pr=f, v=f
    new MyString("*==+==?==*"),           //b=t, c=f, sim=f, pr=f, v=f
    new MyString("?==+==+==?"),           //b=f, c=f, sim=t, pr=t, v=f
    new MyString("==+==+=="),             //b=f, c=t, sim=t, pr=t, v=f
    new MyString("*==+==+=="),            //b=f, c=t, sim=f, pr=t, v=f
    new MyString("==+==+==*"),            //b=f, c=t, sim=f, pr=t, v=f
    new MyString("*==*==*"),              //b=f, c=t, sim=t, pr=t, v=f
    new MyString("*==*==*==*"),           //b=f, c=t, sim=t, pr=f, v=f
    new MyString("?==+==+===?")           //b=f, c=f, sim=f, pr=t, v=f
 };

foreach (var myBridge in myBridges)
{
    Console.WriteLine("\n___________________________________");
    Console.Write("\nThe bridge is: ");
    Console.WriteLine(myBridge.PrintString(myBridge));

    if (myBridge.ValidateBases())
    {
        Console.Write("The bridge has valid bases");
    }
    else
    {
        Console.Write("\nThe bridge hasn't valid bases");
    }

    if (myBridge.ValidateComponents())
    {
        Console.Write("\nThe bridge has valid components");
    }
    else
    {
        Console.Write("\nThe bridge hasn't valid components");
    }

    if (myBridge.IsSimetric())
    {
        Console.Write("\nThe bridge is simmetrical");
    }
    else
    {
        Console.Write("\nThe bridge isn't simmetrical");
    }

    if (myBridge.ValidatePlatformsAndReinforcements())
    {
        Console.Write("\nThe bridge has valid platforms and reinforcements");
    }
    else
    {
        Console.Write("\nThe bridge hasn't valid platforms and reinforcements");
    }

    if (myBridge.ValidateBases() && myBridge.ValidateComponents() 
        && myBridge.IsSimetric() && myBridge.ValidatePlatformsAndReinforcements())
    {
        Console.Write("\nVALID");
    }
    else
    {
        Console.Write("\nNONVALID");
    }
}


