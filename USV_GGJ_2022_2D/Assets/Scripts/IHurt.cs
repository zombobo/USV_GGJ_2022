using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IHurt : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<ITakeDamage>().TakeDamage(attackDamage);
        }
        //play attack animation
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
