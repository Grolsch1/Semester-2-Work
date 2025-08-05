using UnityEngine;

public class Cat : MonoBehaviour
{
    // This method is virtual, allowing derived classes to override it
    public virtual void MakeSound()
    {
        print("Meow!");
    }

}
