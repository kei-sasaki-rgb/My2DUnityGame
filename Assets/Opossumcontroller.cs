using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opossumcontroller : MonoBehaviour {

    public Animator anim; //敵をアニメージョンさせるコンポーネントを入れる(宣言）

    public GameObject opossum; //プレイヤーのコンポーネントを入れる（宣言）

    public Vector3 dir;//進行方向を入れる

    public float rotSpeed = 1.0f;

    public void flip() {
        transform.Rotate(new Vector3(0, 180, 0));
        
        
            }



    // Use this for initialization
    void Start () {


        this.anim = GetComponent<Animator>();//ゲットコンポーネントを使ってアニメーターコンポーネントを取得

    }

    // Update is called once per frame
    void Update() {

        transform.Translate(dir);

        this.transform.Rotate(0, this.rotSpeed, 0);
        
    }

    void OnCollisionEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Opossum"){

            Debug.Log("敵に接触");
        }
    }


}
