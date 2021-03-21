using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public GameObject explosionPrefab;

	void Update () {
		transform.Translate (0, 0.2f, 0);

		if (transform.position.y > 5) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		// 衝突したときにスコアを更新する
		if(coll.gameObject.tag =="sanso"||coll.gameObject.tag =="corona"||coll.gameObject.tag =="vaccine")
		{
		GameObject.Find ("Canvas").GetComponent<UIController> ().AddScore ();

        // 爆発エフェクトを生成する	
		GameObject effect = Instantiate (explosionPrefab, transform.position, Quaternion.identity) as GameObject;
		Destroy (effect, 1.0f);

		Destroy (coll.gameObject);	// ぶつかった相手(石)が消える
		Destroy (gameObject); // 自分自身が消える
		/*if(coll.gameObject.tag == "sanso")
		{
			GameObject.Find ("rocket").GetComponent<RocketController> ().Kaihuku ();
		}*/
		}
	}
}