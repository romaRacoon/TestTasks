using System.Collections.Generic;
using UnityEngine;

public class Enemy : Creature
{
    [SerializeField] private List<Waypoint> _waypoints;

    private int _waypointIndex = 0;

    private void Start()
    {
        Transform.position = _waypoints[_waypointIndex].transform.position;
    }

    private void Update()
    {
        Move();
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
        Transform.position = Vector3.MoveTowards(Transform.position, _waypoints[_waypointIndex].transform.position, Speed * Time.deltaTime);

        if (Transform.position == _waypoints[_waypointIndex].transform.position)
            _waypointIndex++;
        if (_waypointIndex == _waypoints.Count)
            _waypointIndex = 0;
    }

    public override void TryChangeSprite()
    {
        if (_waypoints[_waypointIndex].IsTop)
            SetSprite(FirstElementIndexConst);
        else
            SetSprite(SecondElementIndexConst);
    }
}
