using UnityEngine;
using UnityEngine.SceneManagement;

public class KillOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.collider.GetComponent<Player>();
        if (player != null)
        {
            GameManager.Instance.KillPlayer();
        }
    }
}
