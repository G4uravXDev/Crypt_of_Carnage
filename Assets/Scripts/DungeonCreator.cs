using UnityEngine;

public class DungeonCreatorScript : MonoBehaviour
{
    public int dungeonWidth, dungeonLength;
    public int roomWidth, roomLength;
    public int maxIterations;
    public int corridorWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateDungeon();
    }

    private void CreateDungeon()
    {
        // Implement the dungeon creation logic here
        // This is where you would generate rooms, corridors, and place them within the dungeon space
        DungeonGenerator generator = new DungeonGenerator(dungeonWidth, dungeonLength);
        var listOFRooms = generaotor.CalculateRooms(maxIterations, roomWidthMin, roomLengthMin); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
