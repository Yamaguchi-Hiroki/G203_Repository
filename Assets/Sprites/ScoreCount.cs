using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    //�e�L�X�g�I�u�W�F�N�g
    public GameObject score_object = null;

    //�X�R�A�ϐ�
    public int score_num = 0;

    // ������
    void Start()
    {
        
    }

    // �X�V
    void Update()
    {
        //�I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();

        //�e�L�X�g�̕\�������ւ���
        score_text.text = "Score:" + score_num;

        //1�����Z����
        score_num += 1;
    }
}
