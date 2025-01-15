using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public List<GameObject> spawnedThings;

    // Start is called before the first frame update
    void Start()
    {
        spawnedThings = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newThing = Instantiate(prefab, mouse, Quaternion.identity);
            //Instantiate(prefab, transform);

            spawnedThings.Add(newThing);

            newThing.transform.localScale = Vector3.one * Random.Range(0.75f, 1.5f);

            FirstScript myScript = newThing.GetComponent<FirstScript>();

            myScript.thingThatSpawnedMe = this;

            if(myScript != null)
            {
                myScript.speed = Random.Range(2, 10);
            }

            Destroy(newThing, 8);
        }
    }
}
