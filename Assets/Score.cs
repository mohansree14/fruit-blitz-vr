using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    
    public void AddPoints(int points)
    {
        score += points;
    }
}
