using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp2;
	public AudioClip correctSound;
	public AudioClip wrongSound;
	public AudioClip punch;
	private AudioSource source;
	public Animator anim;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp2 = GameObject.Find ("HP2").GetComponent<hp> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.W)&& pg.ap1!=0)
		{
			
			pg.ap1 -=1;
			Debug.Log("w");
			anim.SetTrigger("Punch");
			source.PlayOneShot(punch,5f);
			hp2.health -=1;
		
		}

		if (Input.GetKeyDown (KeyCode.S)&& pg.ap1!=0)
		{
			
			pg.ap1 -=1;
			anim.SetTrigger("Block");
			
		}
		if (Input.GetKeyDown(KeyCode.Z)){
			if(pg.question== ("0U") || pg.question == ("3U")){
				pg.ap1+=1;
				source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.C)){
			if(pg.question== ("4U") || pg.question == ("8U")){
				pg.ap1+=1;
				source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.X)){
			if(pg.question== ("1U")|| pg.question == ("5U")){
				pg.ap1+=1;
			source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.V)){
			if(pg.question== ("2U")||pg.question== ("6U")|| pg.question == ("7U") ){
				pg.ap1+=1;
				source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (hp2.health == 0)
			Application.LoadLevel ("BatmanWins");
		
	}
}
