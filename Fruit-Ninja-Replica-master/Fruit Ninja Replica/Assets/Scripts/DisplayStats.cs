using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStats : MonoBehaviour
{
    public Text txtStat;

    void Update()
    {
        txtStat.text = "Cut: " + Fruit.cut + "\nMissed: " + Fruit.missed;
    }
}
