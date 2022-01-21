using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    protected const int FirstElementIndexConst = 0;
    protected const int SecondElementIndexConst = 1;
    protected const int ThirdElementIndexConst = 2;
    protected const int FourthElemenIndexConst = 3;

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
