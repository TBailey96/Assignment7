using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject panel;
    public Toggle newPlayer;
    public Slider sliderSize;
    public Slider sliderSpawnSpeed;
    public Slider sliderFruitSpeed;
    public Slider sliderGravity;
    public Slider sliderBlade;
    public Dropdown timeChoice;
    public GameObject panelCredit;
    public void UserSelectPlay()
    {
        ResetValues();
        FruitSpawner.scale = sliderSize.value;
        FruitSpawner.delay = sliderSpawnSpeed.value;
        FruitSpawner.gravity = sliderGravity.value;
        Fruit.startForce = sliderFruitSpeed.value;
        Blade.bladeSize = sliderBlade.value;

        if(timeChoice.value == 0)
        {
            Timer.minutesLeft = 1;
        } else if(timeChoice.value == 1)
        {
            Timer.minutesLeft = 3;
        } else if (timeChoice.value == 2)
        {
            Timer.minutesLeft = 10;
        }

        if (newPlayer.isOn)
        {
            UserSelectInstructions();
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    public void UserSelectReplay()
    {
        Time.timeScale = 1;
        ResetValues();
        SceneManager.LoadScene(1);
    }
    public void UserSelectMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void UserSelectInstructions()
    {
        panel.SetActive(true);
    }
    public void UserSelectOK()
    {
        panel.SetActive(false);
        SceneManager.LoadScene(1);
    }
    private void ResetValues()
    {
        HealthController.health = 3;
        Timer.secondsCount = 0;
        Timer.minuteCount = 0;
        Timer.hourCount = 0;
        Score.CurrentScore = 0;
        Fruit.cutScore = 0;
        Fruit.cut = 0;
        Fruit.missed = 0;
        FruitSpawner.count = 0;
    }
    public void UserSelectCredits()
    {
        panelCredit.SetActive(true);
    }
    public void UserSelectDismiss()
    {
        panelCredit.SetActive(false);
    }
}
