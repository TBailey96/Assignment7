using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore;

	public Text scoreText;
    public Text CutText;

	void Start ()
	{
		scoreText.text = "Score: " + CurrentScore.ToString();
        CutText.text = "Cut: " + Fruit.cut + "\nMissed: " + Fruit.missed;
	}
}
