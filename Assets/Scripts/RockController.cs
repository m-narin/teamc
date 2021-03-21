using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockController : MonoBehaviour
{

    float fallSpeed;
	float rotSpeed;
   // int tsuukacount =3;
    GameObject rocket;
    RockController rocketcontroller;


    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
		this.rotSpeed = 5f + 3f * Random.value;
        rocket= GameObject.Find("Rocket");
      //  rocketcontroller = rocket.gameObject.GetComponent<RocketController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( 0, -fallSpeed, 0, Space.World);
		transform.Rotate(0, 0, rotSpeed );

		if (transform.position.y < -5.5f) {
			Destroy (gameObject);
            // rocketcontroller = rocket.gameObject.GetComponent<RocketController>.Tsuu();
            GameObject.Find ("rocket").GetComponent<RocketController> ().Tsuuka ();
           // rocketcontroller.Tsuuka();
		}
       
    }
}
