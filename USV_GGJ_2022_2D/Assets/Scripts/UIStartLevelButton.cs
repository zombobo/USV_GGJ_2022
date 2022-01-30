using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIStartLevelButton : MonoBehaviour
{
    [SerializeField] string _levelName;

    public string LevelName => _levelName;

    public void Loadlevel()
    {
        SceneManager.LoadScene(_levelName);
    }
}
