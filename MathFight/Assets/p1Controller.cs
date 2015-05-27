using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {

	public problemGenerator pg;
	// Use this for initialization
	void Start () {
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.W))
		{
			
			pg.ap1 -=1;
			Debug.Log("w");
			///call punch
		}
		
	}
}
