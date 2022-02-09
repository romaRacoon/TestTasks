using UnityEngine;

public class FinishGame : MonoBehaviour
{
    private const int _templateConst = 0;

    [SerializeField] private FinishArea _finishArea;
    [SerializeField] private GameObject _winPanel;

    private void OnEnable()
    {
        _finishArea.Winned += OnWinned;
    }

    private void OnDisable()
    {
        _finishArea.Winned -= OnWinned;
    }

    private void OnWinned()
    {
        _winPanel.SetActive(true);

        Time.timeScale = _templateConst;
    }
}
