using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [Range(0, 400)] [SerializeField] private float speed;
    [SerializeField] private int bulletAmount;
    [SerializeField] private RoundedCircle circleController;
    [SerializeField] private TextMeshPro numberLevel;
    [SerializeField] private bool changeDirectionOnShot;

    public void MyStart(int index)
    {
        circleController.StartRotate(speed);
        BulletManager.Instance.bulletRemain = bulletAmount;
        numberLevel.SetText($"{index + 1}");
    }

    public void ToggleDirection()
    {
        if (changeDirectionOnShot)
        {
            circleController.ReverseRotation();
        }
    }
}
