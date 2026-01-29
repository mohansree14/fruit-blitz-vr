using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // move object circular motion around object named cuby 

        // get cuby position

        Vector3 cubyPos = GameObject.Find("cuby").transform.position;

        // get direction from object position to cuby position

        Vector3 direction = cubyPos - transform.position;

        // get rotation from direction

        Quaternion rotation = Quaternion.LookRotation(direction);

        // set rotation

        transform.rotation = rotation;

        // move object around cuby

        transform.Translate(Vector3.right * Time.deltaTime * 2f);

        

  
        




        
    }
}
