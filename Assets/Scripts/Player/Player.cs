using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private const string _moneyBalanceConst = "Money Balance";

    [SerializeField] private Washer[] _washers;

    private int _moneyBalance = 0;

    public event UnityAction<int> MoneyChanged;
    public int MoneyBalance => _moneyBalance;

    public void DisableWashers()
    {
        for (int i = 0; i < _washers.Length; i++)
        {
            _washers[i].Disable();
        }
    }

    public void AddMoney()
    {
        _moneyBalance++;
        PlayerPrefs.SetInt(_moneyBalanceConst, _moneyBalance);
        MoneyChanged?.Invoke(_moneyBalance);
    }

    public void PayBack(int amount)
    {
        _moneyBalance -= amount;
    }
}
