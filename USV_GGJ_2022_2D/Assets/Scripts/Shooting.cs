using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
    [SerializeField]
    public Vector3 clickPosition;
    public GameObject projectile;
    Camera playerCamera;

    [Header("Wwise Events")]
    public AK.Wwise.Event playerShoot;

    private void Start()
    {
        playerCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Transform playerTform = this.transform;
        Vector3 playerPos = this.transform.position;


        if (Input.GetButtonDown("Fire2"))
        {
            Vector3 moveDr = (playerCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position);
            moveDr.z = 0;
            

            Instantiate(projectile, playerPos, Quaternion.identity, playerTform).GetComponent<LaunchMe>().clickPos = moveDr.normalized;

            playerShoot.Post(gameObject);
        }
    }
}