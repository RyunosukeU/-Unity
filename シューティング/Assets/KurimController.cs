using UnityEngine;
using System.Collections;

public class KurimController : MonoBehaviour {

	public GameObject bulletPrefab;

	public bool isGameover=false;

	public void GameOver (){

		isGameover=true;

	}



        
	void Update () {


		if (isGameover==false){

        if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.1f, 0, 0);
            if (transform.position.x < -8.5 ) {
                transform.Translate (0.1f, 0, 0);
		    }
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate ( 0.1f, 0, 0);
            if (transform.position.x > 8.5) {
                transform.Translate (-0.1f, 0, 0);
		    }
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bulletPrefab, transform.position, Quaternion.identity);
		}
		}
    }
}