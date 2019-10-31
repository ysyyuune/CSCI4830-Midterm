using System.Collections;
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
    void OnTriggerStay(Collider other)
    {
        // other object is close
        if (Vector3.Distance(other.transform.position, this.transform.position) < maxDistance)
        {
            audioSource.Play();
            SumScore.Add(10);
            Destroy(apple);
        }
        else
        {
            audioSource.Stop();
        }
    }
}
