using System.Collections.Generic;
using UnityEngine;

public class Enemy : Creature
{
    [SerializeField] private List<Transform> _waypoints;

    private int _waypointIndex = 0;

    private void Start()
    {
        Transform.position = _waypoints[_waypointIndex].position;
    }

    private void Update()
    {
        Move();
        TryChangeSprite();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.Die();
        }
    }

    public override void Move()
    {
        Transform.position = Vector3.MoveTowards(Transform.position, _waypoints[_waypointIndex].position, Speed * Time.deltaTime);

        if (Transform.position == _waypoints[_waypointIndex].position)
            _waypointIndex++;
        if (_waypointIndex == _waypoints.Count)
            _waypointIndex = 0;
    }

    public override void TryChangeSprite()
    {
        if (Transform.position.y < _waypoints[_waypointIndex].position.y)
        {
            SetSprite(SecondElementIndexConst);
        }
        else
        {
            SetSprite(FirstElementIndexConst);
        }
    }
}
