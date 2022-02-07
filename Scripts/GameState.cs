using UnityEngine;

public class GameState : MonoBehaviour
{

    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _playerui;
    private bool IsPause = false;

    private void Update()
    {
        Pause();
    }

    private void Pause()
    {
        if (IsPause)
        {
            _menuPanel.SetActive(true);
            _playerui.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
            _menuPanel.SetActive(false);
            _playerui.SetActive(true);
        }
    }

    public void Resume()
    {
        IsPause = false;
    }

    public void MenuButton()
    {
        IsPause = true;
    }
}
