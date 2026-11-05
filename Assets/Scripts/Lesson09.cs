using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    [ContextMenu("Hello")]
    void Hello()
    {
        Debug.Log("Hello");
    }

    [ContextMenu("테스트 1")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("테스트 2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }



    public int attack = 10;
    int killCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(attack);
    }

    // Update is called once per frame
    void Update()
    {
        killCount = killCount + 1;
    }
}
