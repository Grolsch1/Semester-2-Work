using UnityEngine;

public class ClassActivity1 : MonoBehaviour
{
    
    private void Start ()
    {
        int score = 0;
        int coins = 3;
        int points = 25;

        score += coins * points;
        print ("Total Score: " + score);
    }

}