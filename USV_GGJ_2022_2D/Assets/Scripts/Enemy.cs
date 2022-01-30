using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    public int currentHealth;

    Transform player;
    public int moveSpeed = 1;
    public int maxShootDist = 5;
    public int minFollowDist = 2;

    void Start()
    {
        currentHealth = maxHealth;
    }
    void Awake()
    {
        player = FindObjectOfType<Player>().transform;
    }
    // Update is called once per frame
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
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //play hurt animation

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Died");
        Destroy(gameObject);
        //play die animation
    }
}
