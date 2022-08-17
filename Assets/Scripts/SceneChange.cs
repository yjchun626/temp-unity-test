using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // 메인에서 첫번째 컷신으로
    public void MainToAni1()
    {
        SceneManager.LoadScene("Ani1");
    }

    // 컷신에서 첫번째 스테이지로
    public void Ani1toS1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void S1to2()
    {
        SceneManager.LoadScene("Scene2");
    }
    
    // 첫번째 선택지 - 폭탄 1, 드릴 2, 밧줄 3
    public void chooseBomb()
    {
        SceneManager.LoadScene("Ani2-1");
    }

    public void chooseDrill()
    {
        SceneManager.LoadScene("Ani2-2");
    }

    public void chooseString()
    {
        SceneManager.LoadScene("Ani2-3");
    }

    // 드릴 선택 후 다음 스테이지로
    public void S2to3()
    {
        SceneManager.LoadScene("Scene3");
    }

    // 두번째 선택지 - 토관 1, 록 펄스건 2
    public void chooseMario()
    {
        SceneManager.LoadScene("Ani3-1");
    }

    public void chooseX()
    {
        SceneManager.LoadScene("Ani3-2");
    }

    // 펄스건 선택 후 다음 스테이지로
    public void S3to4()
    {
        SceneManager.LoadScene("Scene4");
    }

    // 세번째 선택지 - 춤추기 1, 떨어지기 2
    public void chooseDance()
    {
        SceneManager.LoadScene("Ani4-1");
    }

    public void chooseDrop()
    {
        SceneManager.LoadScene("Ani4-2");
    }

    // 춤 선택 후 다음 스테이지로
    public void S4to5()
    {
        SceneManager.LoadScene("Scene5");
    }

    // 네번째 선택지 - 도구 1, 보자기 2
    public void chooseTools()
    {
        SceneManager.LoadScene("Ani5-1");
    }

    public void chooseTrash()
    {
        SceneManager.LoadScene("Ani5-2");
    }

    // 진엔딩 후 메인으로 돌아가기
    public void ReturnToMain()
    {
        SceneManager.LoadScene("MainTitle");
    }
}
