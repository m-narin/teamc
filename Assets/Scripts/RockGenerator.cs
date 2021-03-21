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

    // 

    // 時間を計測(敵生成間隔)
    float timelapse; 


    // 指定時間ごとに敵生成
    float interval = 1.0f;

    // 一度の敵生成数
    int generations = 2;
    int vaccinegeneraitions =1;

  // 時間を計測(敵生成間隔)
  float timelapse;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("呼び出す関数", 呼びだす秒数, なん秒ごとに呼び出すか(秒数));
        // InvokeRepeating ("GenRock", 1, 1);
        
    }
    
    // void GenRock () {
    //     Instantiate (rockPrefab, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    // }

  // 指定時間ごとに敵生成
  float interval = 1.0f;

  // 一度の敵生成数
  int generations = 2;
  int vaccinegeneraitions = 1;

  public GameObject emergency;

        num=Random.Range(0,3);
        if(lasting_time > 3.0f){
            generations = 2 ;
            emergency.SetActive(false);
        }

    lasting_time += Time.deltaTime;

            if(num == 0){
            // 指定の数だけ敵を生成する
            for(int i = 0; i < generations; i++){
                Instantiate (rockPrefab, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
            }
            }
            if(num==1){
                Instantiate (Vaccine, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
            }
            /*if(num==2){
                Instantiate (, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
            }*/
            if(num==2){
                Instantiate (sansomasuku, new Vector3 (-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);

            }

            timelapse = 0.0f;
        }
        if (num == 3)
        {
          Instantiate(sansomasuku, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);

        }

        timelapse = 0.0f;
      }

      // bombが残っているとき, Enterを押すと, bombが一つ減る
      if (bomb > 0)
      {

                emergency.SetActive(true);
            }
        }
    }
}

