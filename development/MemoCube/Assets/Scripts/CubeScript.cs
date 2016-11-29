using UnityEngine;
using System.Collections.Generic;

public class CubeScript : MonoBehaviour {
	public Transform brick;

	private Dictionary<int, Transform> objects = new Dictionary<int, Transform>();

	// Use this for initialization
	void Start () {
		for (int y = 0; y < 5; y++) {
			for (int x = 0; x < 5; x++) {
				Transform instantiated = (Transform) Instantiate(brick, new Vector3(x, y, 0), Quaternion.identity);
				Debug.Log ("Inserting object " + instantiated.GetInstanceID ());
				objects.Add (instantiated.GetInstanceID (), instantiated);
			}
		}
	}
	
	// Update is called once per frame
	void Update() {
		if ( Input.GetMouseButtonDown(0) ) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 100f)){
				hit.collider.transform.tag = "Select";
				Debug.Log("Something was clicked upon");
				int collidedInstanceId = hit.collider.gameObject.GetInstanceID ();
				Debug.Log ("Found object " + collidedInstanceId);
				Transform cube;
				if (objects.TryGetValue (collidedInstanceId, out cube)) {
					Debug.Log ("Clicked over object with id " + collidedInstanceId);
				} else {
					Debug.Log ("What?");
				}
				// cube.transform.Translate(new Vector3(0,0,10));
			}
		}
	}
}
