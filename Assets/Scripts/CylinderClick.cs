using UnityEngine;
using System.Collections;

public class CylinderClick : MonoBehaviour
{

	public GameObject mes1;
	public GameObject mes11;


	// Use this for initialization
	void Start ()
	{

		mes1.SetActive (true);
		mes11.SetActive (false);
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
		mes1.SetActive (false);
		mes11.SetActive (true);

	}
}

