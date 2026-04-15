using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.VisualScripting.IndexMetadata;

public class BulletController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer line;
    [SerializeField] private TextMeshPro bulletText;

    public void MyStart(int index)
    {
        bulletText.SetText(index.ToString());
    }
    public void Move(Vector3 finish, float time)
    {
        StartCoroutine(_Move(finish, time));
    }

    private IEnumerator _Move(Vector3 finishPosition, float time)
    {
        var passed = 0f;
        var init = transform.position;
        while (passed < time)
        {
            yield return null;
            passed += Time.deltaTime;
            var normalize = passed / time;
            var newPosition = Vector3.Lerp(init, finishPosition, normalize);
            transform.position = newPosition;
        }
    }

    public void OnCompleted(Transform parent)
    {
        transform.SetParent(parent);
        line.enabled = true;
        LevelManager.Instance.CheckAndChangeDirection();
        if (LevelManager.Instance.IsLevelCompleted())
        {
            LevelManager.Instance.OnFinishLevel();
        }

    }
}
