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

    //add to sceen

    private void addToScene()
    {
        var ds = new DBHandler();

        var planets = ds.getPlanets();

        foreach( var planet in planets)
        {
            Instantiate(planetPrefab, new Vector3(planet.x, planet.y, 0), Quaternion.identity);
        }

    }







}
