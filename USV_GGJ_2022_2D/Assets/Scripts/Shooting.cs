using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectile;
    [SerializeField]
    int projectileSpeed;

     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = gameObject.transform.position; 
        if (Input.GetButtonDown("Fire2")) {
            float step = projectileSpeed * Time.deltaTime;

            Vector3 clickPosition = Input.mousePosition;
            Instantiate(projectile);
            projectile.transform.position = playerPosition;
            projectile.transform.position = Vector3.MoveTowards(transform.position, clickPosition, step);
            }
        }
 }
