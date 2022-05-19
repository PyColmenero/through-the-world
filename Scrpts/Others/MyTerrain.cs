using UnityEngine;

public class MyTerrain : MonoBehaviour
{
    public int depth = 20;

    public int width = 256;
    public int height = 256;

    public float scale = 20;


    // Start is called before the first frame update
    void Start()
    {
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.size = new Vector3 (width, depth, height);
        terrainData.SetHeights(0, 0, GenerateHeights());

        return terrainData;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[width, height];

        for(int x = 0; x < width; x++)
        {
             for(int y = 0; y < height; x++)
            {
                heights[x,y] = CalculateHeight(x,y);
            }
        }

        return heights;
    }

    float CalculateHeight (int x, int y)
    {
        float xCoord = x / width * scale;
        float yCoord = y / width * scale;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }


}
