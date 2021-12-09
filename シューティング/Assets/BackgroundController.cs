using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour
 {
	void Update () {
		transform.Translate (0, -0.008f, 0);
		if (transform.position.y < -9.6f ) {
			transform.position = new Vector3 (0, 9.6f, 0);
		}
	}
}