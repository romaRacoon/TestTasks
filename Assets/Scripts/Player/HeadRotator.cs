using UnityEngine;

public class HeadRotator : MonoBehaviour
{
    [SerializeField] private Washer[] _washers;

    private Transform _target;
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void OnEnable()
    {
        for (int i = 0; i < _washers.Length; i++)
        {
            _washers[i].Moved += OnMoved;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < _washers.Length; i++)
        {
            _washers[i].Moved -= OnMoved;
        }
    }

    private void OnMoved()
    {
        _transform.LookAt(_target);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
