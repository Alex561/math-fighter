using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class problemGenerator : MonoBehaviour {
	public Text problemText;
	public List<string> unitCircle;
	bool correct = false;


	void Start () {

		problemText.text = "placeholder";
		createUnitCircle ();
	
	}
	void createUnitCircle()	{
		unitCircle.Add ("What is sin30°?");
		unitCircle.Add ("What is cos30°?");
		unitCircle.Add ("What is tan30°?");
		unitCircle.Add ("What is sin45°?");
		unitCircle.Add ("What is cos45°?");
		unitCircle.Add ("What is tan45°?");
		unitCircle.Add ("What is sin60°?");
		unitCircle.Add ("What is cos60°?");
		unitCircle.Add ("What is tan60°?");
		unitCircle.Add ("What is sin90°?");
		unitCircle.Add ("What is cos90°?");
		unitCircle.Add ("What is tan90°?");
	}
	void changeProblem(){
		problemText.text = unitCircle[Random.Range(0,unitCircle.Count)];
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			correct =true;
		}
		if (correct) {
			changeProblem ();
			correct=false;
		}
	}
}
