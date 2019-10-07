using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class GetGazePosition : MonoBehaviour {

    //Eye；画面を見た視点の座標を写すために使う。
    private Vector3 Eye = Vector3.zero;
    //Tobii.Gaminigにある視点を扱うためのクラス。
    private GazePoint gp;

    void Update()
    {
        //Tobiiが読み取っているデータを格納する。
        gp = TobiiAPI.GetGazePoint();
        //Is.Recnet;画面を見ているかを否かを判断する。
        if (gp.IsRecent())
        {
            //スクリーンの何処を見ているかの座標を取得
            Vector3 gazeOnScreen = gp.Screen;
            //z軸の座標を修正。
            gazeOnScreen += (transform.forward * 10f);
            //PC画面の座標からUnityの画面での座標に変換する。
            Eye = Camera.main.ScreenToWorldPoint(gazeOnScreen);
            Debug.Log(" X = " +Eye.x + ":Y = " +Eye.y + ":Z = " +Eye.z );
        }
    }
}
