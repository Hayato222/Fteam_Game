using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera
    : MonoBehaviour
{
    private StartTimer timer;
    public GameObject mainCamera;
    public GameObject subCamera;
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();
        // 各カメラオブジェクトを取得
        mainCamera = GameObject.Find("Main Camera");
        subCamera = GameObject.Find("Sub Camera");

        // サブカメラはデフォルトで無効にしておく
        subCamera.SetActive(true);
    }

    void Update()
    {
        // もしSpaceキーが押されたならば、
        if (timer.CountDownTime <= 0)
        {
            // 各カメラオブジェクトの有効フラグを逆転(true→false,false→true)させる
            subCamera.SetActive(false);
            mainCamera.SetActive(true);

        }
    }
}