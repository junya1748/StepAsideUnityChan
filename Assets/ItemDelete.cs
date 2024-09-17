using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {

        //Unityちゃんが10m過ぎたらオブジェクトを廃棄
        if (this.transform.position.z < this.unitychan.transform.position.z - 10f)
        {
            Destroy(this.gameObject);
        }

    }
}