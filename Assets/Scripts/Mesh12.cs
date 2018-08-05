using UnityEngine;
using System.Collections;

public class Mesh12 : MonoBehaviour
{

	public GameObject mes12;
	public GameObject mes1212;


	// Use this for initialization
	void Start ()
	{
		mes12.SetActive (true);
		mes1212.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void OnMouseDown(){
		PlayerPrefs.SetInt ("clicked",1);
//		if(PlayerPrefs.GetInt("Turn")==0){
//			PlayerPrefs.SetInt ("Turn",1);
//		}
//		else if(PlayerPrefs.GetInt("Turn")==1){
//			PlayerPrefs.SetInt ("Turn",0);
//		}
		mes12.SetActive (false);
		mes1212.SetActive (true);

	}
}

