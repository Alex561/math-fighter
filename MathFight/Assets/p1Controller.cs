using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp2;
	// Use this for initialization
	void Start () {
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp2 = GameObject.Find ("HP2").GetComponent<hp> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.W))
		{
			
			pg.ap1 -=1;
			Debug.Log("w");
			//put punch animation
			//put punch sfx
			hp2.health -=1;
		
		}
		if (Input.GetKeyDown(KeyCode.Z)&& pg.p1Turn){
			if(pg.question== ("0U") || pg.question == ("3U"))
				pg.ap1+=1;
			else
				pg.ap1-=1;
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.C)&& pg.p1Turn){
			if(pg.question== ("4U") )
				pg.ap1+=1;
			else
				pg.ap1-=1;
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.X)&& pg.p1Turn){
			if(pg.question== ("1U"))
				pg.ap1+=1;
			else
				pg.ap1-=1;
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.V)&& pg.p1Turn){
			if(pg.question== ("2U") )
				pg.ap1+=1;
			else
				pg.ap1-=1;
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		
	}
}
