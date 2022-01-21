using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : Creature
{
    private const float _templateConst = 0.5f;

    private const int _minimumBombsConst = 0;
    private const int _maximumBombsConst = 3;

    [SerializeField] private Joystick _joystick;
    [SerializeField] private Bomb _bomb;

    private Rigidbody2D _rigidbody;
    private Vector2 _direction;
    private int _bombsAmount;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.freezeRotation = true;

        _bombsAmount = _maximumBombsConst;
    }

    private void Update()
    {
        TryChangeSprite();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public override void Move()
    {
        Vector3 moveInput = new Vector3(_joystick.Horizontal, _joystick.Vertical);
        _direction = moveInput.normalized * Speed;
        _rigidbody.MovePosition(_rigidbody.position + _direction * Time.deltaTime);
    }

    public override void TryChangeSprite()
    {
        if (_joystick.Horizontal > _templateConst)
            SetSprite(FirstElementIndexConst);
        if (_joystick.Horizontal < -_templateConst)
            SetSprite(SecondElementIndexConst);
        if (_joystick.Vertical > _templateConst)
            SetSprite(FourthElemenIndexConst);
        if (_joystick.Vertical < -_templateConst)
            SetSprite(ThirdElementIndexConst);
    }

    public void PlantBomb()
    {
        if (gameObject.activeSelf == true)
        {
            if (_bombsAmount > _minimumBombsConst)
            {
                Instantiate(_bomb, Transform.position, Quaternion.identity);
                _bombsAmount--;
            }
        }
    }
}
