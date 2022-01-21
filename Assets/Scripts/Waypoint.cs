using UnityEngine;

[RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
public class Waypoint : MonoBehaviour
{
    [SerializeField] private bool _isTop;

    public bool IsTop => _isTop;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TryChangeSprite();
        }
    }
}
