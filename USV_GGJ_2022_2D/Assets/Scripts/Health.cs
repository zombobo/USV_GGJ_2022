using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;

    public int CurrentHealth { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = maxHealth;
        Debug.Log("start health: " + CurrentHealth);
    }

    //Health debug
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("current health: " + CurrentHealth);
        }
    }
}
