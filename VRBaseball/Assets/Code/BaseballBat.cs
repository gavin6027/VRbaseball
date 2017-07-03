using UnityEngine;
using System.Collections;

public class BaseballBat : MonoBehaviour {
	public GameObject baseballBat;
	//private Quaternion tempQ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		baseballBat.transform.position = this.transform.position;

		//baseballBat.transform.rotation = new Quaternion (this.transform.rotation.x - 45, this.transform.rotation.y - 30, this.transform.rotation.z - 45, this.transform.rotation.w);
		baseballBat.transform.rotation = this.transform.rotation;
	}
}
