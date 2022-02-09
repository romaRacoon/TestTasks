using UnityEngine;
using UnityEngine.Events;

public class ExceedanceChecker : MonoBehaviour
{
    public event UnityAction Exceeded;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.TryGetComponent<Washer>(out Washer washer))
        {
            Exceeded?.Invoke();
        }
    }
}
