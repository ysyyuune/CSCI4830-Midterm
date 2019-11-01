using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCut: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject apple;
    public GameObject strawberry;
    public GameObject kiwi;
    public GameObject applegenerator;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

        // Update is called once per frame

    void SpawnApple()
    {
        Vector3 position = new Vector3(Random.Range(-10,10), 28, Random.Range(-10,10));
        Instantiate(apple,position, Quaternion.identity);
    }
    void OnCollisionEnter(Collision collision)
    {
        // other object is close
        if (collision.collider.tag == "apple")
        {
            audioSource.Play();
            SumScore.Add(10);
            Destroy(apple);
            SpawnApple();
        }
        if (collision.collider.tag == "strawberry")
        {
            audioSource.Play();
            SumScore.Add(10);
            Destroy(strawberry);
        }
        if (collision.collider.tag == "kiwi")
        {
            audioSource.Play();
            SumScore.Add(10);
            Destroy(kiwi);
        }
    }
}
