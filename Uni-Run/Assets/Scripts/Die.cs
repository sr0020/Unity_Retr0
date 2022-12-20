using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리 관련 라이브러리


public class Die : MonoBehaviour
{
    
    void Update()
    {
        // 플레이어 낙사 시 R 버튼 누르면 재시작
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        // esc 누르면 프로그램 종료
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
