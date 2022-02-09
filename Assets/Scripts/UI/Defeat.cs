using UnityEngine;

public class Defeat : MonoBehaviour
{
    [SerializeField] private Ground _ground;
    [SerializeField] private GameObject _defeatMenu;

    private void OnEnable()
    {
        _ground.Contacted += OnContacted;
    }

    private void OnDisable()
    {
        _ground.Contacted -= OnContacted;
    }

    private void OnContacted()
    {
        _defeatMenu.SetActive(true);
    }
}
