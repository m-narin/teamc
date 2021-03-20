using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    public GameObject rockPrefab;
    public GameObject Vaccine;
    public GameObject hakkekyu;
    public GameObject sansomasuku;
    

    
    // ボムの個数
    int  bomb = 3;
    int num;

    // 時間を計測(敵生成間隔)
    float timelapse;

    // 時間を計測(ボムの持続時間)
    float lasting_time;

    // 指定時間ごとに敵生成
    float interval = 1.0f;

    // 一度の敵生成数
    int generations = 2;
    int vaccinegeneraitions =1;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("呼び出す関数", 呼びだす秒数, なん秒ごとに呼び出すか(秒数));
        // InvokeRepeating ("GenRock", 1, 1);
        
    }
    
    // void GenRock () {
    //     Instantiate (rockPrefab, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    // }

    // Update is called once per frame
    void Update()
    {

        lasting_time += Time.deltaTime;

        timelapse += Time.deltaTime;

        num=Random.Range(0,4);
        if(lasting_time > 3.0f){
            generations = 5 ;
        }

        if (timelapse > interval ){

           if(num == 0){
            // 指定の数だけ敵を生成する
            for(int i = 0; i < generations; i++){
                Instantiate (rockPrefab, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
            }
           }
           if(num==1){
                Instantiate (Vaccine, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
            }
            if(num==2){
                Instantiate (hakkekyu, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
            }
            if(num==3){
                Instantiate ( sansomasuku, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);

            }

            timelapse = 0.0f;
        }

        // bombが残っているとき, Enterを押すと, bombが一つ減る
        if (bomb > 0){

            if (Input.GetKeyDown (KeyCode.Return)) {
                bomb -= 1;
                
                // 敵生成数が減る
                generations = 1;

                // 持続時間初期化
                lasting_time = 0.0f;
            }
        }
    }
}