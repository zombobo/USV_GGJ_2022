using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Movement : MonoBehaviour
{
    private Rigidbody2D hero_body;
    private Vector3 initialVel = Vector3.zero;
    [Range(0, .3f)] [SerializeField] private float smoothing = .05f;
    [SerializeField]
    int characterSpeed = 35;
    float horizontalMove = 0;
    float verticalMove = 0;


    private void Move(float moveX, float moveY)
    {
        Vector3 targetVelocity = new Vector3(moveX * 10f, moveY * 10f).normalized;
        hero_body.velocity = Vector3.SmoothDamp(hero_body.velocity, targetVelocity, ref initialVel, smoothing);
    }

    private void Awake()
    {
        hero_body = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * Time.deltaTime * (float)characterSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * Time.deltaTime * (float)characterSpeed;
    }

    private void FixedUpdate()
    {
        Move(horizontalMove, verticalMove);
    }


}