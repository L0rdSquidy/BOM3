using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPortals : MonoBehaviour
{
    // Start is called before the first frame update

    //key = from => value =to
    Dictionary<GameObject, GameObject> teleports = new Dictionary<GameObject, GameObject>();
    void Start()
    {
        //collect children -> rooms;
        //ever room (for) new Room(obj);
        List<Room> rooms = new List<Room>();
        foreach(GameObject roomObj in ...)
                {
            rooms.Add(new Room(roomObj));

        }
        //collect rooms
        //portals per room
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Room
{
  public List<GameObject> doors = new List<GameObject>();
  public List<GameObject> exits = new List<GameObject>();
    public GameObject roomObj;
    public Room(GameObject roomObj)
    {
        this.roomObj = roomObj;
        GameObject[] checkdoors = GameObject.FindGameObjectsWithTag("portalentrance");

        foreach(GameObject door in checkdoors)
        {
           if( door.parent == roomObj)
                {
                doors.Add(door);
            }
        }
        GameObject[] checkexits = GameObject.FindGameObjectsWithTag("portalexit");
        foreach (GameObject door in checkexits)
        {
            if (door.parent == roomObj)
            {
                exits.Add(door);
            }
        }
    }
}
