using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coincontroller : MonoBehaviour {

    public Animator anim;//Coinをアニメーションさせるコンポーネントを入れる

    public AudioSource aud;//コインの音を出すためのコンポーネントを入れる

    public GameObject CoinSE;

    



    // Use this for initialization
    void Start () {
        anim = this.gameObject.GetComponent<Animator>();

        aud = this.gameObject.GetComponent<AudioSource>();

        this.CoinSE = GameObject.Find("CoinSE");


    }
	
	// Update is called once per frame
	void Update () {

        

    }

    void OnTriggerEnter2D(Collider2D collider){
        //コインに衝突した場合
        if (collider.gameObject.tag == "Player") {

            this.CoinSE. GetComponent<AudioSource>().Play();

            

            Destroy(this.gameObject);//collider衝突情報、gameObject=Player(ここでは)
            Debug.Log("オブジェクトを破棄");
        }
        Debug.Log("オントリガーが呼ばれた");
    }
}
