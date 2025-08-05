using UnityEngine;

public class Lion : Cat
{
    public override void MakeSound()
    {
        print("Roar!");
    }

    Lion()
    {
        MakeSound();
    }

}
