using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    [SerializeField] string _sceneName;

    void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        if (player == null)
            return;
       
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        PlayerPrefs.SetInt(_sceneName + "Unlocked", 1);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(_sceneName);
    }
}
