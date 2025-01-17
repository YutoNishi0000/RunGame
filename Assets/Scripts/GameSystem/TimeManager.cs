using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float _gameTime;

    void Start()
    {
        _gameTime = 0;
    }

    void Update()
    {
        //ゲーム時間を取得
        _gameTime += Time.deltaTime;
    }

    //ゲーム時間を初期化
    public void InitializeTime()
    {
        _gameTime = 0;
    }

    //ゲーム時間を取得
    public float GetGameTime()
    {
        return _gameTime;
    }
}
