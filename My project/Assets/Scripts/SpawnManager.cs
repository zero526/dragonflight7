using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject enemy;


    void Start() {
        //함수 반복(반복할 함수, 초기 지연시간, 반복 주기)
        InvokeRepeating("Spawn", 1f, 2f);
    }
    void Update() {

    }

    void Spawn() {
        float x = Random.Range(-2.5f, 2.5f);
        Vector3 randomPos = new Vector3(x, 4, 0);

        //오브젝트 생성 (생성할 오브젝트, 생성 위치, 회전 방향값)
        Instantiate(enemy, randomPos, Quaternion.identity);
    }
}
