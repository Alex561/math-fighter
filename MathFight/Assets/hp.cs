using UnityEngine;
using System.Collections;

public class hp : MonoBehaviour {
		//get the hp sprites
		public int health;
		public Sprite fullHp; 
		public Sprite twoHP;
		public Sprite oneHP; 
	public Sprite zeroHp;
		//used to change sprites
		private SpriteRenderer spriteRendererH; 
		// Use this for initialization
		void Start () {
			
			spriteRendererH = GetComponent<SpriteRenderer>(); //  the SpriteRenderer that is attached to the Gameobject
			if (spriteRendererH.sprite == null) // if the sprite  is empty// set the sprite to fullHP
				spriteRendererH.sprite = fullHp; 
			
		}
		
		// Update is called once per frame
		void Update () {
			
			if ( health== 2) {
				spriteRendererH.sprite= oneHP;//change the sprite to 2 hp
			}
			else if (health == 1) {
				spriteRendererH.sprite= twoHP; // chnage the sprite to 1 hp
			}
			else if (health == 0) {
				spriteRendererH.sprite= twoHP; //moves to game over screen
				
			}
			
		}
	}
