using UnityEngine;
using UnityEngine.Events;

public class FinishArea : MonoBehaviour
{
    public event UnityAction Winned;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Player>(out Player player))
        {
            Winned?.Invoke();
        }
    }
}
