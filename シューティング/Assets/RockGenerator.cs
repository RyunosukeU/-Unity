using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rockPrefab;

    void Start()
    {InvokeRepeating("GenRock", 1, 1);

    }

    // Update is called once per frame
    void GenRock()
    {
        Instantiate(rockPrefab, new Vector2 (-7.5f + 15 * Random.value, 6), Quaternion.identity);
        //Vector2( 左端 + 左端からどれだけ右にずらすか（ランダム) , どの高さから降らせるか ）
    }
}
