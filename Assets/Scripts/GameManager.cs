using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        LevelManager.Instance.OnStartLevel();
    }

    public void GameOver()
    {
        Debug.Log("Oyun Bitti Kaybettin");
        Time.timeScale = 0;


    }
}
