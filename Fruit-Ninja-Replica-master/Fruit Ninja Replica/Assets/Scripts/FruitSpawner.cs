using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitSpawner : MonoBehaviour {

	public GameObject fruitPrefab;
    public Transform[] spawnPoints;
   

	public static float minDelay = .1f;
	public static float maxDelay = 1f;
    public static float delay;

    public static float scale;
    public static float gravity;
    public static int count = 0;

	// Use this for initialization
	void Start () {
        SetGravity();
		StartCoroutine(SpawnFruits());
	}

	IEnumerator SpawnFruits ()
	{
		while (true)
		{
			//delay = Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];

            FruitSize();
           
            GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            count++;

            Destroy(spawnedFruit, 5f);
        }
	}
	private void FruitSize()
    {
        fruitPrefab.transform.localScale = new Vector3(scale, scale, scale);
    }
    private void SetGravity()
    {
        Physics.gravity = new Vector3(0, gravity, 0);
    }
}
