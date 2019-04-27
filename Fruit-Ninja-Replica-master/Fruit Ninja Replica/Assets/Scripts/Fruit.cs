using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public static float startForce;
    public static int cutScore = 0;
    public static int cut = 0;
    public static int missed = 0;

    Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
        if (col.tag == "Blade")
        {
            Vector3 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
            slicedFruit.transform.localScale = new Vector3(FruitSpawner.scale, FruitSpawner.scale, FruitSpawner.scale);
            Destroy(slicedFruit, 3f);
            Destroy(gameObject);

            cutScore += 5;
            cut++;

            missed += transform.childCount;
        }
    }
    private void Update()
    {
        if (Time.time > 5)
        {
            missed = FruitSpawner.count - (cut + 1);
        }
    }
}
