using UnityEngine;
using UnityEngine.Events;

public class Ground : MonoBehaviour
{
    public event UnityAction Contacted;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Player>(out Player player))
        {
            Contacted?.Invoke();
        }
    }
}
