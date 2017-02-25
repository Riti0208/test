using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class player : MonoBehaviour {


	private int posX;
	private int posY;
	private bool isMove;
	Vector2 rot;
	bool push;
	public void PushDown()
	{
		push = true;
	}
	public void PushUp()
	{
		push = false;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (push) {
			transform.Translate(Time.deltaTime * rot);
		}
	}
	public void moveUp() {
		rot = new Vector2(0f, 1f);
	}
	public void moveDown() {
		rot = new Vector2(0f, -1f);
	}
	public void moveRight() {
		rot = new Vector2(1f, 0f);
	}
	public void moveLeft() {
		rot = new Vector2(-1f, 0f);
	}
}
