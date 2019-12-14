using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeInvisibleDestroy : MonoBehaviour {



    private GameObject UnityChanObject;



    // Use this for initialization
    void Start () {
        // ユニティちゃんのオブジェクトを取得
        UnityChanObject = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {


        // 表示されなくなった時の処理
        if (UnityChanObject.GetComponent<UnityChanController>().ReturnPosZ() - 5 > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }



    }



    // 表示されなくなった時の処理
    /*
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        //Debug.Log("destroy");
        
    }
    */
}
