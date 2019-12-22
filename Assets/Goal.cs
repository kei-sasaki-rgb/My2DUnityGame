using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //LoadSceneを使うため必要

public class Goal : MonoBehaviour {


    public GameObject GoalText;

	// Use this for initialization
	void Start () {
        this.GoalText = GameObject.Find("GoalText");
        GoalText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GoalText.SetActive(true);

            SceneManager.LoadScene("ClearScene");//クリアシーンに移動
        }
    }
}
