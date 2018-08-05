using UnityEngine;
using System.Collections;

public class Mesh18 : MonoBehaviour
{

	public GameObject mes18;
	public GameObject mes1818;


	// Use this for initialization
	void Start ()
	{
		mes18.SetActive (true);
		mes1818.SetActive (false);
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
		mes18.SetActive (false);
		mes1818.SetActive (true);

	}
}

