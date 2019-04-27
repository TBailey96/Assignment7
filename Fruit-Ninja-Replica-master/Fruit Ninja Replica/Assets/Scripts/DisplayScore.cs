using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text txtScore;
    
    void Update()
    {
        txtScore.text = "Score: " + Fruit.cutScore;
        Score.CurrentScore = Fruit.cutScore;
    }
}
