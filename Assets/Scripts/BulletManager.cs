using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public static BulletManager Instance {get; private set;}
    [SerializeField] private Transform Start;
    [SerializeField] private Transform Finish;
    [SerializeField] private BulletController bulletPrefab;
    [Range(0,1)] [SerializeField] private float timeSpeed;
    [SerializeField] public int bulletRemain;

    void Awake()
    {
        Instance = this;
    }

    public void SpawnandMove()
    {
        if (bulletRemain == 0) return;
        var bullet = Instantiate(bulletPrefab, Start.position, quaternion.identity);
        bullet.MyStart(bulletRemain);
        bullet.Move(Finish.position, timeSpeed);
        bulletRemain--;
    }
}
