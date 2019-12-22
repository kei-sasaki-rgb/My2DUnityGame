using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour {
    //Playerのオブジェクト
    private GameObject Player;
    //プレイヤーとカメラの距離
    //private float difference;
	// Use this for initialization
	void Start () {
        //Playerのオブジェクトを取得
        this.Player = GameObject.Find("Player");
        //Playerとカメラの位置（ｚ座標）の差を求まる
        //this.difference = Player.transform.position.z - this.transform.position.z;

    }

    // Update is called once per frame
    void Update () {
        //Playerの位置に合わせてカメラの位置を移動
        //this.transform.position = new Vector3(0, this.transform.position.y, this.Player.transform.position.z - difference);
        this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, this.transform.position.z);
        transform.position = new Vector3(
            Player.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
}
