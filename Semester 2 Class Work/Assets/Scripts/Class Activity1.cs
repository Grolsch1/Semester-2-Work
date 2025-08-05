using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClassActivity1 : MonoBehaviour
{
    
    private void Start ()
    {
        //Activity 1
        int score = 0;
        int coins = 3;
        int points = 25;

        score += coins * points;
        print ("Total Score: " + score);

        //Activity 2
        bool hasKey = true;
        if (hasKey)
        {
            print ("Door unlocked.");
        }
        else
        {
            print ("Find they key first.");
        }

        //Activty 3 
        int playerHealth = 100;
        int damage = 30;
        playerHealth -= damage;
        
        print ("Player Health: " + playerHealth);

    }

    private void Update ()
    {
        //Activity 4
        int rotationSpeed = 50; // degrees per second
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

}