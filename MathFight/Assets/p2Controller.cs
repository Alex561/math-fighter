using UnityEngine;
using System.Collections;

public class p2Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp1;
	// Use this for initialization
	void Start () {
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp1 = GameObject.Find ("HP1").GetComponent<hp> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.O))
		{
			
			pg.ap2 -=1;
			Debug.Log("o");
			hp1.health-=1;
			///call punch
		}
		
	}
}
