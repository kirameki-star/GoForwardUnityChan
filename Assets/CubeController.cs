using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

      // Use this for initialization
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }


    }
    // ���ʉ���炷�ׂ̏Փ˔���i�ʏ�ۑ�j
    void OnCollisionEnter2D(Collision2D other)
    {
        //�n�ʂ��L���[�u�ɓ����������Ɍ��ʉ���炷
        if(other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
       
    }

}