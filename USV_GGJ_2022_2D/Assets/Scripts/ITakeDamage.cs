
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITakeDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
            
        }
    }

    public void TakeDamage(int damage)
    {
        GetComponent<Health>().CurrentHealth -= damage;

        //play hurt animation

        if(GetComponent<Health>().CurrentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Died");
        GetComponent<Health>().CurrentHealth = 0;
        Destroy(gameObject);
        //play die animation
    }
}
