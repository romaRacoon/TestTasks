using UnityEngine;
using UnityEngine.UI;

public class BombButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        _player.PlantBomb();
    }
}
