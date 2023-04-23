using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEmitter : MonoBehaviour
{
    public GameObject soundEmitter;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = soundEmitter.GetComponent<AudioSource>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (Vector3.Distance(transform.position, other.transform.position) < 2f)
            {
                audioSource.Play();
            }
        }
    }
}
