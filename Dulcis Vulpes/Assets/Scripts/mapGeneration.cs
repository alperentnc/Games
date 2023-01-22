using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapGeneration : MonoBehaviour
{
    public Transform cameraTransform;
    float xVal;
    int roomRandom;
    public List<GameObject> rooms;
    GameObject leftRoom,middleRoom,rightRoom,lastRoom;
    public BoxCollider2D floorsColl;
    public GameObject firstRoom;
    List<int> roomsList = new List<int>() {};
    // Start is called before the first frame update
    void Start()
    {
        firstRoom = (GameObject)Instantiate(firstRoom, new Vector2(0, 0.5f), Quaternion.identity);
        rooms = new List<GameObject>(Resources.LoadAll<GameObject>("Rooms"));
        for(int i=0; i<rooms.Count; i++)
        {
            roomsList.Add(i);
        }
        roomRandom = Random.Range(0,roomsList.Count);
        leftRoom = (GameObject)Instantiate(rooms[roomsList[roomRandom]], new Vector2(21.6f, 0.5f), Quaternion.identity);
        roomsList.Remove(roomsList[roomRandom]);
        roomRandom = Random.Range(0, roomsList.Count);
        middleRoom = (GameObject)Instantiate(rooms[roomsList[roomRandom]], new Vector2(43.2f, 0.5f), Quaternion.identity);
        roomsList.Remove(roomsList[roomRandom]);
        roomRandom = Random.Range(0, roomsList.Count);
        rightRoom = (GameObject)Instantiate(rooms[roomsList[roomRandom]], new Vector2(64.8f, 0.5F), Quaternion.identity);
        roomsList.Remove(roomsList[roomRandom]);
    }

    // Update is called once per frame
    void Update()
    {
        xVal = cameraTransform.position.x + 12;

        if (xVal >= rightRoom.transform.position.x + 10)
        {
            builder();
        }
        if (cameraTransform.position.x >= 35 && firstRoom != null)
        {
            Destroy(firstRoom);
        }
              
    }
    void builder()
    {
        if (roomsList.Count<=2)
        {
            roomsList = null;
        }
        for (int i = 0; i < rooms.Count; i++)
        {
            roomsList.Add(i);
        }
        roomRandom = Random.Range(0, roomsList.Count);
        lastRoom = (GameObject)Instantiate(rooms[roomsList[roomRandom]], new Vector2(rightRoom.transform.position.x + 21.6f, 0.5f), Quaternion.identity);
        roomsList.Remove(roomsList[roomRandom]);
        Destroy(leftRoom);
        leftRoom = middleRoom;
        middleRoom = rightRoom;
        rightRoom = lastRoom;
    }
    
}
