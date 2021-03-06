using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panja : MonoBehaviour
{
    [SerializeField]
    Sprite mySprite = null;

    [SerializeField]
    private float CreateTimeInter = 0.0f;

    [SerializeField]
    private float CreateRandomRangeYStart = -2.0f;
    [SerializeField]
    private float CreateRandomRangeYEnd = 2.0f;

    [SerializeField]
    private float CreateRandomScaleXStart = 5.0f;
    [SerializeField]
    private float CreateRandomScaleXEnd = 10.0f;

    [SerializeField]
    private float CreateRange = 20.0f;
    // 마지막으로 만들어진 판자의 위치
    [SerializeField]
    private float LastCreatePosX = 0.0f;
    // 마지막으로 만들어진 판자의 크기
    [SerializeField]
    private float LastCreateScaleX = 0.0f;

    // Start is called before the first frame update

    bool NewPanjaLogic()
    {
        if(LastCreatePosX >= Player.PlayerPos.x + CreateRange)
        {
            return false;
        }

        // 새 게임 오브젝트 생성
        GameObject newPanja = new GameObject("Panja");

        Vector3 CreatePos = new Vector3();


        newPanja.transform.localScale = new Vector3(Random.Range(CreateRandomScaleXStart, CreateRandomScaleXEnd), 1.0f, 1.0f);
        CreatePos.x = LastCreatePosX + LastCreateScaleX + newPanja.transform.localScale.x * 0.5f;
        CreatePos.z = 0.0f;
        CreatePos.y = Random.Range(CreateRandomRangeYStart, CreateRandomRangeYEnd);
        newPanja.transform.position = CreatePos;

        newPanja.transform.position = CreatePos;

        SpriteRenderer newSp = newPanja.AddComponent<SpriteRenderer>();

        newSp.sprite = mySprite;

        // 갱신
        LastCreatePosX = CreatePos.x;
        LastCreateScaleX = (newPanja.transform.localScale.x * 0.5f);

        return true;
    }

    void CheckPanjaCreate()
    {
        while (NewPanjaLogic());
    }

    private void Start()
    {
        CheckPanjaCreate();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
