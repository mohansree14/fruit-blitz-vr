using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

  
        
    }

    // Update is called once per frame
    void Update()
    {

        // Move the object attached to this script

        transform.Translate(Vector3.forward * Time.deltaTime * 1f);



        
    }
}
