using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private bool _isDoorOpen;

    private void Awake()
    {
        _isDoorOpen = false;
    }

    public void OpenDoor()
    {
        _isDoorOpen = !_isDoorOpen;
        animator.SetBool("IsOpen", _isDoorOpen);
    }
}
