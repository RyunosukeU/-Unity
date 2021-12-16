using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {this.fallSpeed = 0.01f + 0.05f * Random.value; //落ちる速度
     this.rotSpeed = 3f + 3f * Random.value; //回転する速度

    }

    // Update is called once per frame
    void Update()
    {transform.Translate(0, -fallSpeed, 0, Space.World);
     transform.Rotate(0, 0, rotSpeed);

     if (transform.position.y < -5.5f) {
       Destroy(gameObject);
     }

    }
}
