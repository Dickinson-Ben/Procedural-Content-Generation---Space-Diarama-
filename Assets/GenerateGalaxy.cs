using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGalaxy : MonoBehaviour
{
    public GameObject star;
    public GameObject Ship1;
    public GameObject Ship2;
    public GameObject Ship3;
    public GameObject Ship4;
    public GameObject Ship5;
    public GameObject Ship6;
    public GameObject Ship7;
    public GameObject Ship8;
    public GameObject Ship9;

    public int numberOfStars;
    public int numberOfShips;

            


	// Use this for initialization
	void Start () {
        spawnStars();
        spawnShips();
            }
	
	// Update is called once per frame
	void Update () {
        Ship1.transform.forward = new Vector3(1.0f, 1.0f, 100.10f) * Time.deltaTime;

	}

    void spawnStars()
    {
        for (int i = 0; i < numberOfStars; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 60f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(star, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
    }
    void spawnShips()
    {

        for (int i = 0; i < numberOfShips; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship1, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i < numberOfShips; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship2, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i < numberOfShips; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship3, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i < numberOfShips; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship4, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i < numberOfShips; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship5, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i < numberOfShips; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship6, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i < numberOfShips; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship7, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i < numberOfShips; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship8, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
        for (int i = 0; i < numberOfShips + 1; i++)
        {
            //Get a random angle
            float randAngle = Random.value * 360f;

            //Get a random distance
            float randDistance = Random.value * 80f;

            //Get a random position from this angle and distance
            float x = Mathf.Cos(randAngle * Mathf.Deg2Rad) * randDistance;
            float z = Mathf.Sin(randAngle * Mathf.Deg2Rad) * randDistance;

            //Instantiate a star (prefab or something) here on xz plane
            Instantiate(Ship9, transform.position = new Vector3(x, 0, z), transform.rotation);
        }
    }


}
