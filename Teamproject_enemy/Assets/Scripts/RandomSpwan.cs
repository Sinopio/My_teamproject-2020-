using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpwan : MonoBehaviour
{
    //몬스터 덱
    public List<Monster> deck = new List<Monster>();
    //몬스터 확률? Weight의 합
    public int total_count;
    //랜덤하게 선택된 몹리스트
    public List<Monster> result = new List<Monster>();

    // 몹스폰에 딜레이를 걸어주는 변수
    public float spwan_delay;
    // 몹 스폰 딜레이 시간 변수
    public float delay_min;
    public float delay_max;
    //게임플레이에 따른 시간 증가 값
    public float spwan_time;

    private int num;
    private GameObject temp;

    // Start is called before the first frame update
    void Start()
    {
        // 스폰시간 랜덤 설정
        spwan_delay = Random.Range(delay_min, delay_max);
        total_count = 0;
        for(int j = 0; j < deck.Count; j++)
        {
            // 총 가중치 합산
            total_count += deck[j].weight;
        }
        num = 0;
        // 랜덤으로 몹 덱을 만들어 준다.
        ResultSelect();
    }

    // Update is called once per frame
    void Update()
    {
        Spwaner();
        ResultSelect();
    }


    public void ResultSelect()
    {
        result.Add(RandomMob());
    }

    public Monster RandomMob()
    {
        int spwan_num = 0;
        int selet_num = 0;

        selet_num = Mathf.RoundToInt(total_count * Random.Range(0.0f, 1.0f));

        for (int i = 0; i < deck.Count; i++)
        {
            spwan_num += deck[i].weight;
            if (selet_num <= spwan_num)
            {
                Monster temp = new Monster(deck[i]);
                return temp;
            }
        }
        return null;
    }

    void Spwaner()
    {
        if (spwan_time >= spwan_delay)
        {
            if(result[num] == null)
            {
                Debug.Log("result[num] = null");
                num = 0;
            }
            temp = result[num].MobObject;
            Instantiate(temp, transform.position, Quaternion.identity);
            spwan_time = 0;
            num++;
            spwan_delay = Random.Range(delay_min, delay_max);
        }
        spwan_time += Time.deltaTime;
    }
}
