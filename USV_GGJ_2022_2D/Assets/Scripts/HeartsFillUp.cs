using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsFillUp : MonoBehaviour
{
    public int visibleHearts = 1;
    // public int health = 1; 

    public Image[] heartMeter;
    public Sprite fullHeart;
    public Sprite emptyHeart; 

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < heartMeter.Length; i++ )
        {
            //if(i < health)
            //{
            //    heartMeter[i].sprite = fullHeart;
            //}else
            //{
            //    heartMeter[i].sprite = emptyHeart;
            //}

            if (i < visibleHearts)
            {
                heartMeter[i].enabled = true;
            } else
            {
                heartMeter[i].enabled = false;
            }
        }
    }
}
