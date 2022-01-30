using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] KeyLock _keyLock;
    [SerializeField] int _totalUses = 2;

    int _usedCount;

    AudioSource _audioSource;

    void Awake() => _audioSource = GetComponent<AudioSource>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        if (player != null)
        {
            transform.SetParent(player.transform);
            transform.localPosition = Vector3.up;
            if (_audioSource != null)
                _audioSource.Play();
        }

        var keyLock = collision.GetComponent<KeyLock>();
        if (keyLock != null && keyLock == _keyLock)
        {
            keyLock.unlock();
            _usedCount++;
            if (_usedCount >= _totalUses)
            Destroy(gameObject);
        }
    }
}
