using UnityEngine;

public class FixCamera : MonoBehaviour
{
    [SerializeField] private Transform fixedPosition;

    private void LateUpdate()
    {
        transform.position = fixedPosition.position;
        transform.rotation = fixedPosition.rotation;
    }
}
