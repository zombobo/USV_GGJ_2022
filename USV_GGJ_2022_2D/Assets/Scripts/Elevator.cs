using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour
{
    [SerializeField] string _sceneName;
    [SerializeField] int _requiredKills = 10;

    bool _unlock = false;

 // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_unlock == false && Kills.KillsCollected >= _requiredKills)
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
        
    }
    IEnumerator LoadAfterDelay()
    {
        PlayerPrefs.SetInt(_sceneName + "Unlocked", 1);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(_sceneName);
    }
   
}
