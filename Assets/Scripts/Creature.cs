using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites;
    [SerializeField] private float _speed;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    [SerializeField] protected Transform Transform;

    protected float Speed => _speed;

    public void Die()
    {
        gameObject.SetActive(false);
    }

    public void SetSprite(int index)
    {
        _spriteRenderer.sprite = _sprites[index];
    }

    public abstract void Move();

    public abstract void TryChangeSprite();
}
