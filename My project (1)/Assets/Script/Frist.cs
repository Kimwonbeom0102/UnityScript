using System.Collections;
using System.Collections.Generic;
using UnityEngine;  // 유니티에 있는 기능을 사용합니다.

public class NewBehaviourScript : MonoBehaviour  //MonoBehaviour가 연결되었습니다.
                                                 //MonoBehaviour는 유니티에서 사용하는 기능들을 모아놓은 클래스입니다.
                                                 //연결되어 있지않으면 유니티의 오브젝트를 연결할 수 없습니다.
{
    public int count = 0;          // 유니티 엔진에서 수정이 가능하고 보입니다.
    private float value = 2.0f;    // 유니티 엔진에서 보이지 않습니다.

    //일반 c#에서는 Main 함수를 통해 실행을 했다면
    //유니티 스크립트는 라이프 사이클에 의해 정해진 위치에 코드를 설계하고
    //유니티 엔진을 실행하는 것으로 작업을 진행합니다.

    // Start is called before the first frame update => 첫 프레임 시작 시 호출되는 함수
    void Start()
    {
        Debug.Log($"첫 프레임에서 Start를 시작하겠습니다.");
    }

    // Update is called once per frame  => 실질적인 동작 등을 구현해야하는 위치
    // 핵심 로직 등이 작성되는 위치 , 계속 반복
    void Update()
    {
        count++;
        Debug.Log(count);
    }
}
