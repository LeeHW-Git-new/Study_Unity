using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager s_Instance; // ���ϼ��� ����ȴ�.
    public static GameManager Instance { get { return s_Instance; } } //������ �Ŵ����� ���´�
    
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void Init()
    {
        if (s_Instance == null)
        {
            GameObject gameobject = GameObject.Find("@Manager");
            if(gameobject == null)
            {
                gameobject = new GameObject { name = "@Manager" };
                gameobject.AddComponent<GameManager>();
            }

            DontDestroyOnLoad(gameobject);
            s_Instance = gameobject.GetComponent<GameManager>();
        }
    }
}
