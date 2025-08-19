using UnityEngine;

namespace myGame.characters
{
    public class Hero: MonoBehaviour
    {
        public int health = 100;
        
        public void PrintHealth()
        {
            print("Player Health is" + health);
        }

    }

}
