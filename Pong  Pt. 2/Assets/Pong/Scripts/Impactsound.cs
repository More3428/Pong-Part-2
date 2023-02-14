using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impactsound : MonoBehaviour
{

    public AudioClip impacto;

    public AudioClip impactotwo;

    private AudioSource source;


    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision coll)
    {
        source.PlayOneShot(impacto, 1f);
    }
}  