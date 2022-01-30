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
    int characterSpeed = 3;
    float horizontalMove = 0;
    float verticalMove = 0;

    private void Move(float move)
    {
        Vector3 targetVelocity = new Vector2(move * 10f, hero_body.velocity.y);
        hero_body.velocity = Vector3.SmoothDamp(hero_body.velocity, targetVelocity, ref initialVel, smoothing);

    }

    private void Move_vert(float movex)
    {
        Vector3 targetVelocityx = new Vector2(movex * 10f, hero_body.velocity.x);
        hero_body.velocity = Vector3.SmoothDamp(hero_body.velocity, targetVelocityx, ref initialVel, smoothing);
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
        Move(horizontalMove);
        Move_vert(verticalMove);
    }


}