using UnityEngine;
using System.Collections.Generic;

public class BinarySpacePartitioner
{
    RoomNode rootNode;

    public RoomNode RootNode {get => rootNode;}

	public BinarySpacePartitioner(int dungeonWidth, int dungeonLength)
	{
        this.rootNode = new RoomNode(0, 0, dungeonWidth, dungeonLength, null, 0);
	}

    public List<RoomNode> PrepareNodesCollection(int maxIterations, int roomWidthMin, int roomLengthMin)
    {
        Queue<RoomNode> graph = new Queue<RoomNode>();
        List<RoomNode> listToReturn = new List<RoomNode>();
        graph.Enqueue(this.rootNode);
        listToReturn.Add(this.rootNode);
        int iterations = 0;
        while(iterations<maxIterations && graph.Count > 0)
        {
            iterations++;
            RoomNode currentNode = graph.Dequeue();
            if(currentNode.Width>=roomWidthMin*2 || currentNode.Length>=roomLengthMin*2)
            {
                SplitTheSpace(currentNode, roomWidthMin, roomLengthMin, listToReturn, graph);
            }
        }
    }

    private void SplitTheSpace(RoomNode currentNode, int roomWidthMin, int roomLengthMin, List<RoomNode> listToReturn, Queue<RoomNode> graph)
    {
      Line line = GetLineDividingSpace(currentNode.BottomLeft, currentNode.TopRight, roomWidthMin, roomLengthMin);
    }

    private Line GetLineDividingSpace(Vector2Int bottomLeftAreaCorner, Vector2Int topRightAreaCorner, int roomWidthMin, int roomLengthMin)
    {
        Orientation orientation;
        bool lengthStatus = topRightAreaCorner.y - bottomLeftAreaCorner.y >= roomLengthMin*2;
        bool widthStatus = topRightAreaCorner.x - bottomLeftAreaCorner.x >= roomWidthMin*2;
    }

}
