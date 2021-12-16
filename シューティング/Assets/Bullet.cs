using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Bulletにこのスクリプトをくっつけてプレハブ化。

SerializeFieldつけてるのでUnityEditorのInspectorで弾のスピードいじれます。

y座標が５より大きくなったら自分自身を破壊するようにしてます。
*/
public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 0.3f;

    void Update()
    {
        move();
        destroyCheck();
    }

    void move(){
        transform.Translate(0,bulletSpeed,0);
    }
    void destroyCheck(){
        if (transform.position.y > 5){
            Destroy(gameObject);
        }
    }
}
