using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{

    public GameObject bulletPrefab;
    public int tsuukacount ;

    // Start is called before the first frame update
    void Start()
    {
        tsuukacount =3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate ( 0.1f, 0, 0);
		}
        if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bulletPrefab, transform.position, Quaternion.identity);
		}

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "sanso")
		{
            Kaihuku ();
		}
    }
    public void Tsuuka(){
        tsuukacount-=1;
            Debug.Log(tsuukacount);
		
        if(tsuukacount==0){
            SceneManager.LoadScene("Endscene");
        }
    }
    public void Kaihuku(){
        tsuukacount+=1;
        Debug.Log(tsuukacount);
    }
}

