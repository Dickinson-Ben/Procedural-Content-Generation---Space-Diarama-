using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroids : MonoBehaviour {

    public int numberOfAsteroids;
    public GameObject Asteroid;

    // Use this for initialization
    void Start () {
        SpawnAsteroids();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= Vector3.forward * Time.deltaTime;

    }
    void SpawnAsteroids()
    {
        for (int i = 0; i < numberOfAsteroids; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 60f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Asteroid, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
    }
}
