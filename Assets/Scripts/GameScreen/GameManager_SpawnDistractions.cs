using UnityEngine;
using System.Collections;

public class GameManager_SpawnDistractions : MonoBehaviour {

    public bool runSpawner = true;

    float spawnTimer = 3.0f;

    float spawnRate = 1.0f;

    Vector3 spawnPosition = Vector3.zero;

    public GameObject distractionPrefab;

    public int distractionCount = 1;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (!runSpawner) return;

        spawnRate -= 0.01f * Time.deltaTime;

        spawnRate = Mathf.Clamp(spawnRate, 0.4f, 50.0f);

        spawnTimer += 1.0f * Time.deltaTime;
        if(spawnTimer >= spawnRate)
        {
            spawnTimer = 0.0f;
            if(distractionPrefab == null)
            {
                Debug.Log("Distraction prefab not set in inspector.");
                return;
            }

            float worldScreenHeight = Camera.main.orthographicSize * 2;
            float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

            int randSide = Random.Range(1, 4);

            if (randSide == 1)
            {
                // left side
                spawnPosition.x = -worldScreenWidth * 0.6f;

                spawnPosition.y = Random.Range(-worldScreenHeight * 0.3f, worldScreenHeight * 0.6f);
            }

            else if (randSide == 2)
            {
                // top side
                spawnPosition.x = Random.Range(-worldScreenWidth * 0.6f, worldScreenWidth * 0.6f);

                spawnPosition.y = worldScreenHeight * 0.6f;
            }

            else if (randSide == 3)
            {
                // right side
                spawnPosition.x = worldScreenWidth * 0.6f;

                spawnPosition.y = Random.Range(-worldScreenHeight * 0.3f, worldScreenHeight * 0.6f);
            }

            //Debug.Log("height " + worldScreenHeight + ", " + "width " + worldScreenWidth);
            //Debug.Log(randY);

            //float randX = Random.Range();

            if(spawnPosition == Vector3.zero)
            {
                Debug.Log("spawn position is zero");
                return;
            }

            GameObject distraction = (GameObject)Instantiate(distractionPrefab, spawnPosition, Quaternion.identity);
            distraction.name = "Distraction" + distractionCount;
            distractionCount++;
            distraction.transform.SetParent(GameObject.Find("SceneSpawnedObjects").transform);
        }
	}
}
