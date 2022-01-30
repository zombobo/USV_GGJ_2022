using System.Collections.Generic;
using UnityEngine;

public class Kills : MonoBehaviour
{
     public static int KillsCollected;

    public int CurrentHealth { get; private set; }

    void OnTriggerEnter2D(Collider2D collision)
    {
        var shooting = collision.GetComponent<Enemy>();
        if (shooting == null)
            return;
        if (shooting != null && CurrentHealth <= 0)
        {
            KillsCollected++;
            Debug.Log(KillsCollected);
            //ScoreSystem.Add(100);
        }
    }
}
