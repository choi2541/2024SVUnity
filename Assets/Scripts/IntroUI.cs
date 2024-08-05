using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroUI : MonoBehaviour
{
    //private vs public
    //private : 다른 곳에서 접근을 못하게 하는 것
    //public : 공공의, 다른 곳에서 접근을 가능하게 해주는것

    // 반환타입 : 반환을 하는 것 안하는 것
    // void : 반환 타입이 없는 것
    // int double... : 해당 타입으로 반환하라

    //함수의 이름
    public void GameStart()
    {
        SceneManager.LoadScene(1); //1번에 등록된 씬을 불러 와라


    }
    public void GameQuit()
    {
        Application.Quit(); //게임을 빌드 해야지만 적용이 됩니다
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;  // 에디터에서 실행 버튼을 비활성화 시키세요.
#endif

    }
}
