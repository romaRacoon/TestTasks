using UnityEngine;
using UnityEngine.UI;

public class LevelView : MonoBehaviour
{
    private const string _levelConst = "Level ";

    [SerializeField] private Text _levelText;

    private int _levelNumber = 1;

    private void Start()
    {
        LoadData();
    }

    private void LoadData()
    {
        if (PlayerPrefs.HasKey(_levelConst))
        {
            _levelNumber = PlayerPrefs.GetInt(_levelConst);

            _levelText.text = _levelConst + _levelNumber.ToString();
        }
        else
        {
            _levelText.text = _levelConst + _levelNumber.ToString();
        }
    }
}
