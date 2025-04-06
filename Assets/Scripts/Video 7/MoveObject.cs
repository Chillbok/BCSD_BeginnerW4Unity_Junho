using NUnit.Framework.Constraints;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int number = 4;//스칼라 값
        Vector2 vec = new Vector2(-3,-3);//벡터 값
        transform.Translate(vec);//Translate(): 벡터 값을 현재에 더하는 함수
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
            );
        transform.Translate(move);
    }
}