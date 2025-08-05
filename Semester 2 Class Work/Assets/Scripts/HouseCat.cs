using UnityEngine;

public class HouseCat : Cat
{
    public override void MakeSound()
    {
        print("Purrr");
    }

    HouseCat()
    {
        MakeSound();
    }
}
