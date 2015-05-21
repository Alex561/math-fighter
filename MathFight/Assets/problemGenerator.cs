using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class problemGenerator : MonoBehaviour {
	public Text problemText;
	public List<string> unitCircle;
	bool correct = false;
	public int ap1 = 3;
	public int ap2= 3;
	bool p1Turn = true;
	string question;
	string answer = "eneter answer";

	void Start () {

		problemText.text = "placeholder";
		createUnitCircle ();
		question = changeProblem ();
	
	}
	void createUnitCircle()	{
		unitCircle.Add ("What is sin30°?");
		unitCircle.Add ("What is tan30°?");
		unitCircle.Add ("What is sin45°?");
		unitCircle.Add ("What is cos60°?");
		unitCircle.Add ("What is cos90°?");
	}
	string changeProblem(){
		int n = Random.Range (0, unitCircle.Count);
		problemText.text = unitCircle[n];
		string q = (n.ToString() + "U");
		print ("in change problem" + q);
		return q;
	}
	void checkSolution(string a){
		switch (question) {
		case "0U":
			print ('0');
			break;
		case "1U":
			print ('1');
			break;
		case "2U":
			print ('2');
			break;
		case "3U":
			print ('3');
			break;
		case "4U":
			print ('4');
			break;
		}
	}
	
	void OnGUI(){
		answer = GUI.TextField(new Rect(290,350,200,20),answer,25);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			//get input
			print (question);// test
			print(answer);
			checkSolution("input");
			print ("new problem");
			question = changeProblem ();
		}
		if (correct) {
			correct=false;
		}
	}
}
