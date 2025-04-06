using UnityEngine;

public class Move : MonoBehaviour
{
    Vector2 target = new Vector2(10,5.5f);
    Vector3 target3 = new Vector3(10,5.5f,1);
    // Update is called once per frame
    void Update()
    {
        //1. MoveTowards(단순 등속 이동)
        /*
        transform.position =
            Vector2.MoveTowards(transform.position, target, 0.05f);//x좌표, y좌표, 움직이는 속도
        */
        
        //2. SmoothDamp(미끄러지듯이 감속 이동)
        Vector2 velo = Vector2.zero;

        //마지막 매개변수에 반비례해서 속도 증가
        //값을 많이 줄수록 속도 빨라짐
        /*
        transform.position =
            Vector2.SmoothDamp(transform.position,target,ref velo, 0.1f);
        */

        //3. Lerf (선형 보간 이동)
        //값을 적게 줄수록 속도 빨라짐
        transform.position =
            Vector2.Lerp(transform.position,
            target,
            0.01f);

        //4. Slerp (구면 선형 보간 이동)
        //포물선 이동
        //vec2(2D)에서는 사용 불가능
        /*
        transform.position =
            Vector3.Slerp(
                transform,
                target3,
                0.05f
            );
        */
    }
}