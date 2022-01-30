using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsFillUp : MonoBehaviour
{
    int visibleHearts = 4;
    int health; 

    public Image[] heartMeter;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    // Update is called once per frame
    void Update()
    {
        health = GetComponent<Health>().CurrentHealth;
        for (int i = 0; i < heartMeter.Length; i++ )
        {
            if (i < health)
            {
                heartMeter[i].sprite = fullHeart;
            }
            else
            {
                heartMeter[i].sprite = emptyHeart;
            }

            if (i < visibleHearts)
            {
                heartMeter[i].enabled = true;
            } else
            {
                heartMeter[i].enabled = false;
            }

            if (health == 0)
            {
                //somehow kill all images in array
            }
        }
    }
}
