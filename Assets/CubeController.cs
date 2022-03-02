using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

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
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }


    }
    // 効果音を鳴らす為の衝突判定（通常課題）
    void OnCollisionEnter2D(Collision2D other)
    {
        //地面かキューブに当たった時に効果音を鳴らす
        if(other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
       
    }

}