using SQLite4Unity3d;
using UnityEngine;
#if !UNITY_EDITOR
using System.Collections;
using System.IO;
#endif
using System.Collections.Generic;

public class DBHandler 
{
    string DB = "map.db";
    private SQLiteConnection _connection;

    public DBHandler()
    {

#if UNITY_EDITOR
        var dbPath = string.Format(@"Assets/DBs/{0}", DB);
#else
        // check if file exists in Application.persistentDataPath
        var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);

        if (!File.Exists(filepath))
        {
            Debug.Log("Database not in Persistent path");
            // if it doesn't ->
            // open StreamingAssets directory and load the db ->

#if UNITY_ANDROID
            var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
            while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
            // then save to Application.persistentDataPath
            File.WriteAllBytes(filepath, loadDb.bytes);
#elif UNITY_IOS
                 var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);
#elif UNITY_WP8
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#elif UNITY_WINRT
		var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
		
#elif UNITY_STANDALONE_OSX
		var loadDb = Application.dataPath + "/Resources/Data/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
#else
	var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
	// then save to Application.persistentDataPath
	File.Copy(loadDb, filepath);

#endif

            Debug.Log("Database written");
        }

        var dbPath = filepath;
#endif
        _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        Debug.Log("Final PATH: " + dbPath);

    }

    //planet table
    string planet_table = "planet_table";
    string planet_table_id = "id";
    string planet_table_x = "x";
    string planet_table_y = "y";
    
    //changeTable
    string chain_table = "chain_table";
    string planet_id = "id";
    string other_planet_id = "Oid";

    //feild type
    string integer_field_type = "INTEGER";
    string string_field_type = "STRING";
    string Date_field_type = "date";
    string Tstamp_field = "timestamp";

    public void createDB()
    {
        //todo create this when totaly move from python

    }

    public void destroyDB()
    {
        //todo create this when totaly move from python
    }

    //create tables
    private void creatPlanetTable()
    {
        //todo create this when totaly move from python
    }

    private void createChainTable()
    {
        //todo create this when totaly move from python
    }

    // add to tables 

    public void addToChainTable(int id, int otherID)
    {
        //todo create this when totaly move from python
    }

    // get tables

    public IEnumerable<Planet> getPlanets()
    {
        return _connection.Table<Planet>();
    }








}
