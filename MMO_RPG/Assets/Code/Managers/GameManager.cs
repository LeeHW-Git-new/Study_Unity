using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager s_Instance; // 유일성이 보장된다.
    static GameManager Instance { get { Init(); return s_Instance; } } //유일한 매니저를 갖는다


    InputManager _input = new InputManager();
    public static InputManager Input { get { return Instance._input; } }

    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
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
