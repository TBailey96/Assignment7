using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float secondsCount;
    public static int minuteCount;
    public static int hourCount;
    public static string time;
    public static int minutesLeft;
    void Update()
    {
        secondsCount += Time.deltaTime;
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
        time = minuteCount + "m:" + (int)secondsCount + "s";

        if (minuteCount == minutesLeft)
        {
            SceneManager.LoadScene(2);
        }
    }
}
