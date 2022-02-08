using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseControll : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Scene _currentScene;

    // Update is called once per frame
    private void Start()
    {
        _currentScene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        if (_player.position.y < -5f)
        {
            Invoke(nameof(RestartGame), 1f);
        }
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(_currentScene.buildIndex);
    }
}
