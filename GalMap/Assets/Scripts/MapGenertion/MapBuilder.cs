using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBuilder : MonoBehaviour
{

    int planet_population = 65;
    int galaxy_X = 1000;
    int galaxy_y = 1000;
    int chain_length = 25;

    int shyness = 12;

    public GameObject planetPrefab;


    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(255);
        addToScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //add to screen
    private void addToScene()
    {
        var db = new DBHandler();
        var planets = db.getPlanets();

        foreach ( var planet in planets)
        {
            GameObject planetObj = Instantiate(planetPrefab);
            planetPrefab.name = "planet: " + planet.id;

            var chains =  db.getLinkedPlanets(planet.id);

            LineRenderer line = planetObj.GetComponent<LineRenderer>() as LineRenderer;

            foreach (var chain in chains)
            {
                var planet2 = db.getPlanetByID(chain.Oid);

                line.positionCount = line.positionCount+1;
                line.SetPosition(line.positionCount-1, new Vector3(planet.x, planet.y,-1));

                line.positionCount = line.positionCount + 1;
                line.SetPosition(line.positionCount-1, new Vector3(planet2.x, planet2.y,-1));
            }
            line.sortingLayerName = "Foreground";
            planetObj.transform.position = new Vector3(planet.x,planet.y,10);
        }
    }
}
