using UnityEngine;

public class PlayerDropedOff : MonoBehaviour
{
    [SerializeField] private ExceedanceChecker _exceedanceChecker;

    private Player _player;

    private void Start()
    {
        _player = GetComponentInChildren<Player>();
    }

    private void OnEnable()
    {
        _exceedanceChecker.Exceeded += OnExceeded;
    }

    private void OnDisable()
    {
        _exceedanceChecker.Exceeded -= OnExceeded;
    }

    private void OnExceeded()
    {
        _player.DisableWashers();
    }
}
