using UnityEngine;

public class InputDetection : MonoBehaviour
{
    private const int _templateConst = 0;

    [SerializeField] private HeadRotator _headRotator;

    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.touchCount > _templateConst)
        {
            Ray ray = _mainCamera.ScreenPointToRay(Input.GetTouch(_templateConst).position);

            if (Physics.Raycast(ray, out RaycastHit raycast))
            {
                if (raycast.collider.gameObject.TryGetComponent<Washer>(out Washer washer))
                {
                    _headRotator.SetTarget(washer.gameObject.transform);
                    washer.Reposition(raycast.point);
                }
            }
        }
    }
}
