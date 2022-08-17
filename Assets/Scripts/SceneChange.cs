using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // ���ο��� ù��° �ƽ�����
    public void MainToAni1()
    {
        SceneManager.LoadScene("Ani1");
    }

    // �ƽſ��� ù��° ����������
    public void Ani1toS1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void S1to2()
    {
        SceneManager.LoadScene("Scene2");
    }
    
    // ù��° ������ - ��ź 1, �帱 2, ���� 3
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

    // �帱 ���� �� ���� ����������
    public void S2to3()
    {
        SceneManager.LoadScene("Scene3");
    }

    // �ι�° ������ - ��� 1, �� �޽��� 2
    public void chooseMario()
    {
        SceneManager.LoadScene("Ani3-1");
    }

    public void chooseX()
    {
        SceneManager.LoadScene("Ani3-2");
    }

    // �޽��� ���� �� ���� ����������
    public void S3to4()
    {
        SceneManager.LoadScene("Scene4");
    }

    // ����° ������ - ���߱� 1, �������� 2
    public void chooseDance()
    {
        SceneManager.LoadScene("Ani4-1");
    }

    public void chooseDrop()
    {
        SceneManager.LoadScene("Ani4-2");
    }

    // �� ���� �� ���� ����������
    public void S4to5()
    {
        SceneManager.LoadScene("Scene5");
    }

    // �׹�° ������ - ���� 1, ���ڱ� 2
    public void chooseTools()
    {
        SceneManager.LoadScene("Ani5-1");
    }

    public void chooseTrash()
    {
        SceneManager.LoadScene("Ani5-2");
    }

    // ������ �� �������� ���ư���
    public void ReturnToMain()
    {
        SceneManager.LoadScene("MainTitle");
    }
}
