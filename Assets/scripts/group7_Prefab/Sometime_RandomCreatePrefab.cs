using UnityEngine;

public class Sometime_RandomCreatePrefab : MonoBehaviour
{
    public GameObject newPrefab;

    void Start()
    {
        Invoke("CreatePrefab", Random.Range(5, 10));
    }

    void CreatePrefab()
    {
        Vector3 newPos = this.transform.position;
        newPos.z = -5;
        GameObject newGameObject = Instantiate(newPrefab);
        newGameObject.transform.position = newPos;
    }
}
