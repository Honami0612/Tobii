using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;
//このコードをコンポネントした時、指定したコンポネントを強制的につけてくれる。外すことも出来なくする。
[RequireComponent(typeof(GazeAware))]

public class GazeCheck : MonoBehaviour {

    //gazeAwareクラスを取得。見ているかを管理するクラス。
    private GazeAware _gazeAware;
    void Start()
    {
        //初期化
        _gazeAware = GetComponent<GazeAware> ();
    }
    void Update()
    {
        //座標を取得。なくても通る気がする。
        GazePoint gazePoint = TobiiAPI.GetGazePoint();
        //オブジェクトを見ているとtrueを返してくれるので、オブジェクトを見た場合の処理ができるようになる
    
if (_gazeAware.HasGazeFocus == true)
        {
            Debug.Log(" Gaze!");
        }
    }
}
