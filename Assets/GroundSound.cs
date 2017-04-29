using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSound : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    //cube同士がぶつかったら音をだす。unityちゃんがぶつかったら音はださない。
    void OnCollisionEnter2D(Collision2D collision)
    {
        //ぶつかってくるのがcubeだったら
        if (collision.gameObject.tag == "cubeprefab")
        {
            // 音を出す
            GetComponent<AudioSource>().Play();
        }



        


    }
}
