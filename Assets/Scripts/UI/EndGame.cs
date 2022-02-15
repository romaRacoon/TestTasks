using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] private EnemyCounter _enemyCounter;
    [SerializeField] private Button _restartButton;
    
    private void Start()
    {
        _restartButton = GetComponentInChildren<Button>();

        _restartButton.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        _enemyCounter.Finished += OnFinished;
        _restartButton.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _enemyCounter.Finished -= OnFinished;
        _restartButton.onClick.RemoveListener(OnClick);
    }

    private void OnFinished()
    {
        _restartButton.gameObject.SetActive(true);
    }

    private void OnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
