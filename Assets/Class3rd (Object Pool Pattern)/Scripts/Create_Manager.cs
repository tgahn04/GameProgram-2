using UnityEngine;
using System.Collections;

public class Create_Manager : MonoBehaviour
{
    [SerializeField] float SpawnInterval;
    [SerializeField] float SpawnPoint;
    [SerializeField] Vector3 SpawnOffset;

    [SerializeField] Transform Portal;

    void Awake()
    {
        GameObject PortalObject = GameObject.Find("Portal");

        if(PortalObject != null)
        {
            Portal = PortalObject.transform;
        }
    }

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnMinotaur();
            yield return new WaitForSeconds(SpawnInterval);
        }
    }

    void SpawnMinotaur()
    {
        if (Portal == null || Object_Pool.Instance == null)
            return;

        GameObject minotaur = Object_Pool.Instance.GetObject();

        if (minotaur == null)
            return;

        Vector2 direction = Random.insideUnitCircle.normalized;

        Vector3 spawnPosition = Portal.position + 
        new Vector3(direction.x, 0f, direction.y) * SpawnPoint + SpawnOffset;

        Vector3 lookDir = Portal.position - spawnPosition;
        lookDir.y = 0f;

        Quaternion rotation = Quaternion.LookRotation(lookDir);

        minotaur.transform.position = spawnPosition;
        minotaur.transform.rotation = rotation;
        minotaur.SetActive(true);
    }
}
