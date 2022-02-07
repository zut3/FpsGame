using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private bool _isOpened = false;


    public void Open()
    {
        _animator.SetBool("isOpened", _isOpened);
        _isOpened = !_isOpened;
    }
}
