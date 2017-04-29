using UnityEngine;
using System.Collections;

//キューブが地面に接触する時とキューブ同士が積み重なるときに効果音をつけてください
//ユニティちゃんと衝突した時には効果音が鳴らないようにしてください

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
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