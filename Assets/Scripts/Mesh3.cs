using UnityEngine;
using System.Collections;

public class Mesh3 : MonoBehaviour
{

	public  GameObject mes3;
	public  GameObject mes33;


	// Use this for initialization
	void Start ()
	{
		mes3.SetActive (true);
		mes33.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public  void OnMouseUp(){
		PlayerPrefs.SetInt ("clicked",1);
//		if(PlayerPrefs.GetInt("Turn")==0){
//			PlayerPrefs.SetInt ("Turn",1);
//		}
//		else if(PlayerPrefs.GetInt("Turn")==1){
//			PlayerPrefs.SetInt ("Turn",0);
//		}
		mes3.SetActive (false);
		mes33.SetActive (true);

	}
}

