using UnityEngine;
using UnityEngine.UI;

public class CollectedView : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Text _text;

    private void Start()
    {
        _text = GetComponentInChildren<Text>();
    }

    private void OnEnable()
    {
        _player.Collected += OnCollected;
    }

    private void OnDisable()
    {
        _player.Collected -= OnCollected;
    }

    private void OnCollected(int collectedAmount)
    {
        _text.text = collectedAmount.ToString();
    }
}
