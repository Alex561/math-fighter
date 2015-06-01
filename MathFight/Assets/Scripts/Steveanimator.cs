using UnityEngine;
using System.Collections;

public class Steveanimator : MonoBehaviour {
	Animator anim_s;
	int punch=Animator.StringToHash("Punch");
	// Use this for initialization
	void Start () {
		anim_s= GetComponent<Animator> ();
	}
	
	void Update ()
	{
		AnimatorStateInfo stateinfo = anim_s.GetCurrentAnimatorStateInfo (0);
		if (Input.GetKeyDown (KeyCode.O)) {
			anim_s.SetTrigger("Punch");
		}
		else if (Input.GetKeyDown (KeyCode.L)) {
			anim_s.SetTrigger("Block");
		}
		
	}
}
