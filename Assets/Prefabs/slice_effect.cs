using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class slice_effect : MonoBehaviour
{
    public Transform splashed;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("animate",4);
    }

    // Update is called once per frame
    void Update()
    {
        
            
        
    }

    void animate()
    {
        ParticleSystem ps=splashed.GetComponent<ParticleSystem>();
        ps.Play();
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }
}
