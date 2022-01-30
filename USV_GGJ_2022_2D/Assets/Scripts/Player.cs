using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    public int currentHealth;

    Rigidbody2D _rigidbody2D;
    Vector3 _startPosition;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    internal void ResetToStart()
    {
        _rigidbody2D.position = _startPosition;
        SceneManager.LoadScene("Scene1");
    }
}
