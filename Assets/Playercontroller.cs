using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//LoadSceneを使うために必要

public class Playercontroller : MonoBehaviour
{
    //Playerを移動させるコンポーネントを入れる
    public Rigidbody2D rigid2D;

    //Playerをアニメージョンさせるコンポーネントを入れる
    public Animator anim;

    //左右に移動するための力
    private float walkForce = 6.0f;
    float maxWalkSpeed = 6.0f;

    //ジャンプする力
    float jumpForce = 700.0f;
    //ジャンプ状態かどうか（追加）
    public bool jumpFlag = false;

    //足が何かに触れているか（追加)
    public bool groundFlag = false; //bool→真偽型、groundFlag→着地フラグ

    //ゲーム終了の判定
    private bool isEnd = false;



    //ゲーム終了時に表示するテキスト（追加）
    private GameObject stateText;


    // Use this for initialization
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();

        //シーン中のstateTextオブジェクトを取得（追加）
        this.stateText = GameObject.Find("GoalText");
    }
    // Update is called once per frame
    void Update()
    {
        //ジャンプする
        if (Input.GetKeyDown(KeyCode.Space) && groundFlag)
        {
            this.rigid2D.AddForce(transform.up * jumpForce);
            Debug.Log("jump");//ジャンプを表示する
        }
        //左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 10;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -10;

        //プレイヤーの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //スピード制限
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);//AddForce=力を加える
            anim.SetBool("isRun", true);


        }
        if (key == 0)
        {
            this.rigid2D.velocity = new Vector2(0, this.rigid2D.velocity.y);//velocity=速度
            anim.SetBool("isRun", false);
        }
        //動く方向に応じて反転
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 10, 10);
        }

        //もし、スぺースキーを押したとき、足が何かに触れていたら（追加）
        if (Input.GetKey(KeyCode.Space) && groundFlag)
        {
            jumpFlag = true;
        }

        //画面外から出たら最初に戻る
        if (transform.position.y < -16){
            SceneManager.LoadScene("GameScene");
        }
    }
    //足が何かに触れたら（追加）
    void OnTriggerStay2D(Collider2D collision)
    {
        groundFlag = true;
       
    }
    //足に何も触れなかったら（追加）
    void OnTriggerExit2D(Collider2D collision)
    {
        groundFlag = false;
        
    }

    
 }


