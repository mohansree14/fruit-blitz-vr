using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretSpawner : MonoBehaviour
{

    public GameObject[] projectilePrefabs;

    private GameObject projectilePrefab;
    public GameObject temperaturePrefab;

    private int projectilesCount = 0;
    public int reloadAfter;

    public GameObject target;
    public Transform projectileSpawnPoint;
    public float shootForce = 1.5f;
    public float shootDelay = 1f;
    public float shootRadius = 5f;
    public float shootAngle = 25f;
    public float shootLifeTime = 5f;

    private void OnEnable()
    {
        // wait two seconds before starting to shoot

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

        parent.LookAt(target.transform.position);

        // set parent rotation y to 0

        parent.eulerAngles = new Vector3(0, parent.eulerAngles.y, 0);

       
    }



    private IEnumerator Shoot()
    {
        yield return new WaitForSeconds(5f);
        while (enabled)
        {
            // throw projectile at at player

            Vector3 spawnPos = transform.position;

            // get player position

            Vector3 playerPos = target.transform.position;


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

            // add 1 to projectile count

            projectilesCount++;

            if (temperaturePrefab.GetComponent<Renderer>().material.color == Color.red)
            {
                temperaturePrefab.GetComponent<Renderer>().material.color = Color.green;
            }

            // wait for next shoot
            if (projectilesCount > reloadAfter)
            {
                projectilesCount = 0;
                temperaturePrefab.GetComponent<Renderer>().material.color = Color.red;
                yield return new WaitForSeconds(5f);
               
            }
            else
            {
                yield return new WaitForSeconds(shootDelay);
            }
            

    }
    }


}


