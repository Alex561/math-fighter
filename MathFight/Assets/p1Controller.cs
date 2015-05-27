using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {
	public problemGenerator pg;
	// Use this for initialization
	void Start () {
		pg = gameObject.GetComponent<problemGenerator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.W))
		    {

			if (pg ==null)
				Debug.Log("null");
			///call punch
		}

	}
}
