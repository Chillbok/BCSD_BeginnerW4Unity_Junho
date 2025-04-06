using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    //초기화 영역

    private void Awake()
    {
        //게임 오브젝트 생성할 때 최초 실행
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable()
    {
        //게임 오브젝트가 활성화되었을 때
    }

    private void Start()
    {
        //업데이트 시작 직전, 최초 실행
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    //프레임
        //물리 연산 영역

    private void FixedUpdate()
    {
        //물리 연산을 하기 전에 실행할 내용
        //고정된 실행 주기로 CPU를 많이 사용한다.
        Debug.Log("이동!");
    }
    
        //게임 로직 업데이트

    void Update()
    {
        //게임 로직 업데이트
        //FixedUpdate와 달리 환경에 따라 실행 주기가 적어지거나 많아질 수 있음
        Debug.Log("몬스터 사냥!");
    }

    void LateUpdate()
    {
        //모든 업데이트 끝난 후 실행
        //카메라, 로직 후처리 등을 실행
        Debug.Log("경험치 획득!");
    }

    void OnDisable()
    {
        //게임 오브젝트가 비활성화되었을 때
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    //해체
    private void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다."); 
    }
}
