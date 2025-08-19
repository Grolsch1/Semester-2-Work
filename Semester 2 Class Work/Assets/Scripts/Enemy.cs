using UnityEngine;

namespace myGame.characters
{
    public class Enemy : MonoBehaviour
    {
        public int damage = 25;

        public void PrintDamage()
        {
            print("Enemy Damage " + damage);
        }
    }

}