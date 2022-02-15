using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public event UnityAction Died;

    public void Die()
    {
        Died?.Invoke();
        gameObject.SetActive(false);
    }
}
