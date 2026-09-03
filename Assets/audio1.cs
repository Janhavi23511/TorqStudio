using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio1 : MonoBehaviour
{
    public AudioSource audioSource;
    public float cooldown = 10f;
    private float nextPlayTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Time.time >= nextPlayTime)
        {
            audioSource.Play();
            nextPlayTime = Time.time + cooldown;
        }
    }

    
}
