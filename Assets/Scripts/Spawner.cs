using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GD.MinMaxSlider;


public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnerData spawnerData;

    public Transform spawnPosition;
    public bool playOnAwake = true;

    [MinMaxSlider(0, 100), SerializeField] Vector2Int numberOfSpawns;
    [MinMaxSlider(0, 20), SerializeField] Vector2 delay�etweenSpawns;



    private void Start()
    {
        if(playOnAwake)
            StartCoroutine(startSpawnCor());
    }

    public IEnumerator startSpawnCor()
    {
        for (int i = 0; i < Random.Range(numberOfSpawns.x, numberOfSpawns.y); i++)
        {
            yield return new WaitForSeconds(Random.Range(delay�etweenSpawns.x, delay�etweenSpawns.y));
            Instantiate(spawnerData.Prefabs[Random.Range(0, spawnerData.Prefabs.Count)], spawnPosition).transform.localPosition = Vector3.zero;
        }

        yield break;
    }


    // � ��������� ������� 
    // ��������� ���-�� �� ���
    // ������ ��������� ����� �������� �������� ��������
    // ����� ����� 
    // ������������ ���������
    // ���� ��������� ������� ����� ��������
}