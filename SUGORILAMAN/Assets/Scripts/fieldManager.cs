using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldManager : MonoBehaviour {

	public GameObject hardBlock;
	public int[,] fieldIndex;

	// Use this for initialization
	void Start () {
		fieldIndex = new int[17, 13];
		for (int i = 0; i < 17; i++) {
			Instantiate(hardBlock, new Vector3(i * 0.4f - 3.2f, 4f, 0f), Quaternion.identity);
		}
		for (int i = 0; i < 11; i++)
		{
			Instantiate(hardBlock, new Vector3(-3.2f, 3.6f - i * 0.4f, 0f), Quaternion.identity);
		}
		for (int i = 0; i < 17; i++)
		{
			Instantiate(hardBlock, new Vector3(i * 0.4f - 3.2f, -0.8f, 0f), Quaternion.identity);
		}
		for (int i = 0; i < 11; i++)
		{
			Instantiate(hardBlock, new Vector3(3.2f, 3.6f - i * 0.4f, 0f), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
