using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;
    public float expRate = 1.5f;


    [ContextMenu("정산")]
    void Settle()
    {
        
        int hour = playSeconds / 3600;
        int minute = (playSeconds % 3600) / 60;
        int second = playSeconds % 60;

        Debug.Log("플레이 시간" + hour + "시간" + minute + "분" + second + "초");

        
        int goldperPerson = gold / members;
        int remainder = gold % members;

        Debug.Log("1인당" + goldperPerson + "G, 리더 보너스" + remainder + "G");

        
        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);

        Debug.Log("경험치" + finalExp + " (기본 " + baseExp + ")");


        int level = finalExp / 100 + 1;
        int remainingExp = 100 - (finalExp % 100);

        Debug.Log("Lv" + level + ", 다음 레벨까지 " + remainingExp);


        float averageDamage = (float)totalDamage / hits;

        Debug.Log("평균 데미지" + averageDamage);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
