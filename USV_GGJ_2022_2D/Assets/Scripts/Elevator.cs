using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour
{
    [SerializeField] string _sceneName;
    [SerializeField] int _requiredKills = 10;

    bool _unlock = false;
    private Animator animator;

 // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_unlock == true && Kills.KillsCollected >= _requiredKills)
        Unlock();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        if (player == null)
            return;
        if (_unlock == false)
            return;
        StartCoroutine(LoadAfterDelay());
    }

    void Unlock()
    {   
        _unlock = true;
        GetComponent<Collider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = true;
        animator.Play("ElevatorUp");  
    }
    IEnumerator LoadAfterDelay()
    {
        animator.Play("ElevatorDown");
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(_sceneName);
    }
   
}
