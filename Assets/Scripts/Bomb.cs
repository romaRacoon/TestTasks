using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private const float _waitingTimeToChangeFieldConst = 3f;
    private const float _timeBeforeBlowConst = 1f;

    private bool _isReadyToBlow = false;

    private void Start()
    {
        StartCoroutine(Blow());
    }

    private IEnumerator Blow()
    {
        yield return new WaitForSeconds(_waitingTimeToChangeFieldConst);

        _isReadyToBlow = true;
        yield return new WaitForSeconds(_timeBeforeBlowConst);
        gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Creature>(out Creature creature))
        {
            if (_isReadyToBlow == true)
            {
                creature.Die();
            }
        }
    }
}
