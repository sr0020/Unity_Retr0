using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �� ���� ���� ���̺귯��


public class Die : MonoBehaviour
{
    
    void Update()
    {
        // �÷��̾� ���� �� R ��ư ������ �����
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        // esc ������ ���α׷� ����
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
