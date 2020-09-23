using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject[] blocks;

    [SerializeField]
    private int rows = 5;
    [SerializeField]
    private int cols = 8;

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
        GameManager.instance.maxScore = rows*cols;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateGrid()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                // Generate block 
                GameObject tile = Instantiate(blocks[Random.Range(0,blocks.Length)]);
                // Make the GameObject tile a child of Grid Manager
                tile.transform.parent = this.transform;
                // Add brick script to the gameObject
                tile.AddComponent<Brick>();

                // Multiply by 2 because the block height is 8px
                float posX = col*2f; 
                // Divide by 2 because the block width is 32px
                float posY = row/2f; 

                // Block position
                tile.transform.position = new Vector2(posX, posY);

            }
        }

        // Grid Manager position
        transform.position = new Vector2((-cols)+1, 4-(rows/2f));
    }
}
