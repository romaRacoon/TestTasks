using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContinueGame : MonoBehaviour
{
    private const string _levelTextConst = "Level";

    [SerializeField] private Button _continueButton;

    private int _levelNumber = 1;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        _continueButton.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _continueButton.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        _levelNumber++;
        PlayerPrefs.SetInt(_levelTextConst, _levelNumber);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
