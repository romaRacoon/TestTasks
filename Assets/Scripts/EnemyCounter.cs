using UnityEngine;
using UnityEngine.Events;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField] private Enemy[] _enemies;

    private int _enemyAmount;

    public event UnityAction Finished;

    private void Start()
    {
        _enemyAmount = _enemies.Length;
    }

    private void OnEnable()
    {
        for (int i = 0; i < _enemies.Length; i++)
        {
            _enemies[i].Died += OnDied;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < _enemies.Length; i++)
        {
            _enemies[i].Died -= OnDied;
        }
    }

    private void OnDied()
    {
        _enemyAmount--;

        TryFinishGame();
    }

    private void TryFinishGame()
    {
        if (_enemyAmount == 0)
        {
            Finished?.Invoke();
        }
    }
}
