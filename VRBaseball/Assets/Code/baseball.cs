using UnityEngine;
using System.Collections;

public class baseball : MonoBehaviour {
	public float Fx = 0;
	public float Fy = 0;
	public float Fz = 0;
	public float Tx = 0;
	public float Ty = 0;
	public float Tz = 0;

	public float ConstantForceX;
	public float ConstantForceY;
	public float ConstantForceZ;
	private bool shoot = false;
	// Use this for initialization
	void Start () {
        //this.transform.position = ( 11.214 , 2.135 , 29.17);
        this.GetComponent<Rigidbody>().useGravity = false;
        Fx = 85;
        Fy = 60;
        Fz = -300;
        Tx = 10000;
        Ty = 0;
        Tz = 50;
        ConstantForceX = -1;
        ConstantForceY = 0;
        ConstantForceZ = 0;


    }
	
	// Update is called once per frame
	void Update () {
        /*if (this.GetComponent<Rigidbody>().detectCollisions == true)
        {
            //this.GetComponent<ConstantForce>().enabled = false;
            ConstantForceZ = 500;
            ConstantForceX *= -1;
            //ConstantForceY *=
            OnCollectionEnter

        }*/

        if (Input.GetKey (KeyCode.Q)) {
			//shoot = false;
			this.GetComponent<ConstantForce> ().enabled = false;
			this.GetComponent<Rigidbody>().isKinematic = true;
			this.GetComponent<Rigidbody> ().useGravity = false;
			this.transform.position = new Vector3 (11.214f, 2.135f, 29.17f);
			this.transform.rotation = new Quaternion (0, 90, 0, 0);
			this.GetComponent<Rigidbody>().isKinematic = false;
			//shoot = true;
		}

		if (Input.GetKeyUp (KeyCode.Space) || SteamVR_Controller.Input(3).GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger)) {
			this.GetComponent<Rigidbody> ().useGravity = true;
			this.GetComponent<Rigidbody>().AddForce(Fx, Fy, Fz);
			this.GetComponent<ConstantForce> ().enabled = true;
			this.GetComponent<ConstantForce> ().force = new Vector3 (ConstantForceX, ConstantForceY, ConstantForceZ);
			//this.GetComponent<Rigidbody> ().AddForce( Tz*Vector3.Cross(this.GetComponent<Rigidbody> ().velocity,this.GetComponent<Rigidbody> ().angularVelocity), ForceMode.Force);
			//shoot = true;
			//this.GetComponent<Rigidbody> ().useGravity = true;
			//this.GetComponent<Rigidbody>().AddForce(Fx, Fy, Fz);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			ConstantForceX = ConstantForceX * -1;
			ConstantForceY = ConstantForceY * -1;
			ConstantForceZ = ConstantForceZ * -1;
			//this.GetComponent<Rigidbody>().AddForce(20 ,0 ,0);
		}

	}

	void FixedUpdate (){
		if (shoot) {
			this.GetComponent<Rigidbody> ().AddForce( Tz*Vector3.Cross(this.GetComponent<Rigidbody> ().velocity,this.GetComponent<Rigidbody> ().angularVelocity), ForceMode.Force);
			//this.GetComponent<Rigidbody> ().angularDrag = angDrag;
			//this.GetComponent<Rigidbody> ().maxAngularVelocity = maxAngVel;
			//this.GetComponent<Rigidbody> ().AddTorque (0, 10 * spinForce, 0);
			//this.GetComponent<Rigidbody> ().AddTorque (Tx, Ty, Tz);

			/*if (Input.GetMouseButtonDown (0)) {
				this.GetComponent<Rigidbody> ().useGravity = true;
				//this.GetComponent<Rigidbody> ().AddForceAtPosition (Vector3.back * 700, transform.position);
				this.GetComponent<Rigidbody>().AddForce(Fx, Fy, Fz);
				this.GetComponent<Rigidbody> ().AddTorque (Tx, Ty, Tz);
				//this.GetComponent<Rigidbody> ().angularVelocity = new Vector3(Tx, Ty, Tz);
				//this.GetComponent<Rigidbody> ().velocity
				shoot = false;
				//this.rigidbody.AddTorque(Vector3.left * 20000);
			}*/
		}
	}

    /*void FixedUpdate ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			this.GetComponent<Rigidbody>().AddTorque(Tx ,Ty ,Tz , ForceMode.VelocityChange);
			//this.GetComponent<Rigidbody>().AddTorque(transform.up * Time.frameCount, ForceMode.VelocityChange);
			//this.GetComponent<Rigidbody>().AddRelativeForce
		}
	}*/

    /*
	 * GameObject.Find(ball).GetComponent<Rigidbody>().isKinematic = false;
		GameObject.Find(ball).GetComponent<Rigidbody>().AddForce(xFource * fourcRate * reverseXFource, yFource * fourcRate, zFource * fourcRate * reverseZFource);
	 */
    int qq = 0;
    void OnTriggerEnter(Collider BaseballBat)
    {
        if (qq == 0)
        {
            Fz = 1000;
            Fx = 0;
            Fy = 600;
            Tx = 0;
            Ty = 0;
            Tz = 0;
            ConstantForceX = 0;
            ConstantForceY = 0;
            ConstantForceZ = 0;
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().AddForce(Fx, Fy, Fz);
            this.GetComponent<ConstantForce>().enabled = true;
            this.GetComponent<ConstantForce>().force = new Vector3(ConstantForceX, ConstantForceY, ConstantForceZ);
            qq += 1;
        }
    }
}
