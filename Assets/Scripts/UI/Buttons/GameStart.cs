using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _playZone;
    [SerializeField] private Button _playButton;

    private void OnEnable()
    {
        _playButton.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        _menu.SetActive(false);
        _playZone.SetActive(true);
    }
}
