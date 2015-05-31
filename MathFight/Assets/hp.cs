using UnityEngine;
using System.Collections;

public class hp : MonoBehaviour {
		//get the hp sprites
		public int health;
	public Sprite zeroHp;
		public Sprite fullHp; 
		public Sprite twoHp;
		public Sprite oneHp;
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
			
			if ( health== 4) {
				spriteRendererH.sprite= twoHp;//change the sprite to 2 hp
			}
			else if (health == 2) {
				spriteRendererH.sprite= oneHp; // chnage the sprite to 1 hp
			}
			else if (health == 0) {
				spriteRendererH.sprite= zeroHp; //moves to game over screen
				
			}
			
		}
	}
