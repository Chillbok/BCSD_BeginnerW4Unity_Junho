using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.anyKeyDown) 
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");//아무 입력을 최초로 받을 때 true
        }
        if(Input.anyKey)
        {
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");//아무 키를 누르고 있을 때 true
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템을 구입했습니다.");
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동 중");
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 이동 시작");
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 이동중");
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        }

        //마우스 버튼 입력
        //0: 마우스 좌클릭
        //1: 마우스 우클릭
        
        if(Input.GetMouseButtonDown(0))//마우스 버튼 눌렀을 때
        {
            Debug.Log("마우스 버튼 누름");
        }
        if(Input.GetMouseButton(1))//마우스 버튼 누르고 있는 동안
        {

        }
        if(Input.GetMouseButtonUp(1))//마우스 버튼 뗐을 때
        {

        }
        */

        //Input Manager 사용법
        if(Input.GetButtonDown("Vertical"))
        {
            Debug.Log("1. 위아래 이동 키 누름");
        }
        if(Input.GetButton("Vertical"))
        {
            //GetAxis: 프레임에 따라 다름
            //GetAxisRaw: 무조건 1값 바뀜
            Debug.Log("2. 위아래 이동 키 누르는 중" + Input.GetAxis("Vertical")+"\n" + Input.GetAxisRaw("Vertical"));
        }
        if(Input.GetButtonUp("Vertical"))
        {
            Debug.Log("3. 위아래 이동 키 뗌");
        }

        if(Input.GetButtonDown("Horizontal"))
        {
            Debug.Log("1. 좌우 이동 키 누름");
        }
        if(Input.GetButton("Horizontal"))
        {
            Debug.Log("2. 좌우 이동 키 누르는 중" + Input.GetAxis("Horizontal")+"\n" + Input.GetAxisRaw("Vertical"));
        }
        if(Input.GetButtonUp("Horizontal"))
        {
            Debug.Log("3. 좌우 이동 키 뗌");
        }
        if(Input.GetButtonDown("Ultra"))
        {
            Debug.Log("궁극기!!!!");
        }
    }
}