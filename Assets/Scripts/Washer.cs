using UnityEngine;
using UnityEngine.Events;

public class Washer : MonoBehaviour
{
    private Transform _transform;
    private Rigidbody _rigidbody;

    public event UnityAction Moved;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();

        _rigidbody.freezeRotation = true;
    }

    public void Reposition(Vector3 newPosition)
    {
        _transform.position = new Vector3(newPosition.x, newPosition.y, _transform.position.z);
        
        Moved?.Invoke();
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }
}
