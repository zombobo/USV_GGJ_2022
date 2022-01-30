using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMe : MonoBehaviour
{
    public Vector3 clickPos;
    public bool inBounds = true;
    public float speed = 10f;

    // Start is called before the first frame update
    /*private void Awake()
    {
        // clickPos = GetComponent<Shooting>().clickPosition;
        clickPos = FindObjectOfType<Shooting>().clickPosition;
    }
    */

    // Update is called once per frame
    void Update()
    {
        //       transform.position = Vector3.MoveTowards(transform.position, clickPos, (speed * Time.deltaTime));
        transform.position += clickPos * Time.deltaTime * speed;
  
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.collider.CompareTag("Bounds")){
            Destroy(this.gameObject);
        }
    }
}
