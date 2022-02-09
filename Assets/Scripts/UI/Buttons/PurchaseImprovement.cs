using UnityEngine;
using UnityEngine.UI;

public class PurchaseImprovement : MonoBehaviour
{
    private const string _moneyBalanceConst = "Money Balance";
    private const string _purchaseImprovementTextConst = "Buy improvement for ";
    private const int _templateConst = 1;

    [SerializeField] private Button _purchaseImprovementButton;
    [SerializeField] private Player _player;

    private Text _buttonText;
    private int _cost = 1;

    private void Start()
    {
        _buttonText = _purchaseImprovementButton.GetComponentInChildren<Text>();

        LoadData();
    }

    private void OnEnable()
    {
        _purchaseImprovementButton.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _purchaseImprovementButton.onClick.RemoveListener(OnClick);
    }

    private void LoadData()
    {
        if (PlayerPrefs.HasKey(_moneyBalanceConst))
        {
            _cost = PlayerPrefs.GetInt(_moneyBalanceConst);
            _buttonText.text = _purchaseImprovementTextConst + _cost.ToString();
        }
        else
        {
            _buttonText.text = _purchaseImprovementTextConst + _cost.ToString();
        }
    }

    private void OnClick()
    {
        if (_player.MoneyBalance >= _cost)
        {
            Debug.Log("improvement is obtained");

            _player.PayBack(_cost);
            _cost += _templateConst;
        }
    }
}
