using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnerPauline : MonoBehaviour
{
    [SerializeField] GameObject[] asteroids;
    [SerializeField] float timer = 2f;
    [SerializeField] float radius = 5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Random.insideUnitCircle * radius;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
