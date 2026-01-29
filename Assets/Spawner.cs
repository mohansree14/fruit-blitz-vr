using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{

    public GameObject[] projectilePrefabs;

    private GameObject projectilePrefab;
    
    public string target = "Teleportation anchor";

    public Transform projectileSpawnPoint;
    public float shootForce = 1.5f;
    public float shootDelay = 1f;
    public float shootRadius = 5f;
    public float shootAngle = 25f;
    public float shootLifeTime = 5f;

    private void OnEnable()
    {
        StartCoroutine(Shoot());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private void Update()
    {
        

        // make parent object look at player position but only on y axis

        Transform parent = transform.parent;

        // set parent rotation

        parent.LookAt(GameObject.Find(target).transform.position);

        // set parent rotation y to 0

        parent.eulerAngles = new Vector3(0, parent.eulerAngles.y, 0);
      
    }



    private IEnumerator Shoot()
    {
        yield return new WaitForSeconds(2f);
        while (enabled)
        {
            // throw projectile at at player

            Vector3 spawnPos = transform.position;

            // get player position

            Vector3 playerPos = GameObject.Find(target).transform.position;


            // get direction from spawn position to player position

            Vector3 direction = playerPos - spawnPos;


            // spawn projectile

            projectilePrefab = projectilePrefabs[Random.Range(0, projectilePrefabs.Length)];
            GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);

            // set projectile direction

            projectile.transform.forward = direction;

            // set projectile force

            projectile.GetComponent<Rigidbody>().AddForce(direction * shootForce, ForceMode.Impulse);

            // destroy projectile after lifetime

            Destroy(projectile, shootLifeTime);

            // wait for next shoot

            yield return new WaitForSeconds(shootDelay);



        }
    }


}


