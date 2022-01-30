using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITakeDamage : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    public int currentHealth;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
