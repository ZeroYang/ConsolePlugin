using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour {

	private GameObject Console;
	// Use this for initialization
	void Start () {
		Console = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Console"));
		Console.SetActive(true);

		UnityEngine.Debug.Log("Console plugin");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
