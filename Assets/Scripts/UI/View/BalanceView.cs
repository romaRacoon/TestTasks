using UnityEngine;
using UnityEngine.UI;

public class BalanceView : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Text _text;

    private void OnEnable()
    {
        _player.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _player.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int newMoneyAmount)
    {
        _text.text = newMoneyAmount.ToString();
    }
}
