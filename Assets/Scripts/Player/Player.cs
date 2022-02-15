using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private int _collectedAmount = 0;

    public event UnityAction<int> Collected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            _collectedAmount++;
            enemy.Die();
            Collected?.Invoke(_collectedAmount);
        }
    }
}
