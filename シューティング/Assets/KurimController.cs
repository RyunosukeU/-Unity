using UnityEngine;
using System.Collections;

public class KurimController : MonoBehaviour {
        
	void Update () {
        if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.1f, 0, 0);
            if (transform.position.x < -2.4 ) {
                transform.Translate (0.1f, 0, 0);
		    }
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate ( 0.1f, 0, 0);
            if (transform.position.x > 2.4) {
                transform.Translate (-0.1f, 0, 0);
		    }
		}
    }
}