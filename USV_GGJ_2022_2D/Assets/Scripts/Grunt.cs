using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grunt : MonoBehaviour
{
    public Transform player;
    public GameObject projectile;

    int moveSpeed = 1;
    int maxShootDist = 5;
    int minFollowDist = 2;
    float shootWaitTime = 2.0f;
    float shootTimer = 0.0f;

    void Awake()
    {
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) >= minFollowDist)
        {
            Quaternion startRotation = transform.rotation;

            transform.LookAt(player);
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

            // Revert to original rotation so sprite doesn't disappear.
            transform.rotation = startRotation;
        }

        if (Vector3.Distance(transform.position, player.position) <= maxShootDist && shootTimer <= 0)
        {
            Vector3 moveDr = player.position - transform.position;
            Instantiate(projectile, transform.position, Quaternion.identity, transform).GetComponent<LaunchMe>().clickPos = moveDr.normalized;
            shootTimer = shootWaitTime;
        }
        if (shootTimer >= 0)
        {
            shootTimer -= Time.deltaTime;
        }
    }
}
