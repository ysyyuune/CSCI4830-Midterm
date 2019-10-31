﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCut: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject apple;
    public float maxDistance = 5;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

        // Update is called once per frame
        void Update()
    {
        
    }

    void SpawnApple()
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        Instantiate(apple, position, Quaternion.identity);
    }
    void OnTriggerStay(Collider other)
    {
        // other object is close
        if (Vector3.Distance(other.transform.position, this.transform.position) < maxDistance)
        {
            audioSource.Play();
            SumScore.Add(10);
            Destroy(apple);
            SpawnApple();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
