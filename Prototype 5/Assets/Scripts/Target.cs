/*
 * Gregory Blevins
 * Prototype 5
 * Handles Target Behaviour
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    private Rigidbody targetRB;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawn = 6;

    private GameManager scoreIncrementer;

    public ParticleSystem onDestroy;

    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();

        targetRB.AddForce(RandomForce(), ForceMode.Impulse);

        targetRB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        transform.position = RandomSpawnRange();

        scoreIncrementer = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private Vector3 RandomSpawnRange()
    {
        return new Vector3(Random.Range(-xRange, xRange), -ySpawn);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomForce()
    {
        return (Vector3.up * Random.Range(minSpeed, maxSpeed));
    }

    private void OnMouseDown()
    {
        if (scoreIncrementer.isGameActive)
        {
            scoreIncrementer.UpdateScore(pointValue);

            Instantiate(onDestroy, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!gameObject.CompareTag("Bad"))
        {
            scoreIncrementer.GameOver();
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
