using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    private const float _templateConst = 0f;

    private Transform _transform;
    private Camera _camera;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody2D>();

        _camera = Camera.main;
        _rigidbody.isKinematic = true;
    }

    private void OnMouseDrag()
    {
        Move();
    }

    private void Move()
    {
        Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = _templateConst;
        _transform.position = mouseWorldPosition;
    }
}
