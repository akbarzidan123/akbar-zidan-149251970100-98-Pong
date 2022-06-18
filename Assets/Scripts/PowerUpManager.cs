using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour 
{ 
    public int spawnInterval;
    private float timer;
    public Transform spawnArea;
    public int maxPowerUpAmount; 
    public List<GameObject> powerUpTemplateList;
    private List<GameObject> powerUpList;

    public Vector2 powerUpAreaMin; 
    public Vector2 powerUpAreaMax; 
    private void Start() 
    { 
        powerUpList = new List<GameObject>(); 
        timer =0;
    } 
    private void Update()
    {
        timer += Time.deltaTime; 
 
        if (timer > spawnInterval) 
        { 
            GenerateRandomPowerUp(); 
            timer -= spawnInterval;
        } 
    }
    public void GenerateRandomPowerUp() 
    { 
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), 
        Random.Range(powerUpAreaMin.y, powerUpAreaMax.y))); 
    } 
    public void GenerateRandomPowerUp(Vector2 position) 
    { 
        if (powerUpList.Count >= maxPowerUpAmount) 
        { 
            RemovePowerUp(powerUpList[0]);
        } 
 
        if (position.x < powerUpAreaMin.x || 
            position.x > powerUpAreaMax.x || 
            position.y < powerUpAreaMin.y || 
            position.y > powerUpAreaMax.y) 
        { 
            return; 
        } 
 
        int randomIndex = Random.Range(0, powerUpTemplateList.Count); 
 
        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, 
        powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);

        powerUp.SetActive(true); 
 
        powerUpList.Add(powerUp); 
    }
    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }
    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0) 
        { 
            RemovePowerUp(powerUpList[0]); 
        } 
    }

    public void durationScale(GameObject paddle)
    {
        StartCoroutine(FixSizeScale(paddle));
    }

    IEnumerator FixSizeScale(GameObject paddle)
    {
        yield return new WaitForSeconds(5.0f);
        paddle.transform.localScale =  new Vector3(paddle.transform.localScale.x , paddle.transform.localScale.y / 2);
    }
    public void durationSpd(GameObject paddle)
    {
        StartCoroutine(FixSpdPaddle(paddle));
    }

    IEnumerator FixSpdPaddle(GameObject paddle)
    {
        yield return new WaitForSeconds(5.0f);
        int spdTemp = paddle.transform.GetComponent<PaddleController>().getSpd();
        paddle.transform.GetComponent<PaddleController>().setSpd(spdTemp/2);
    }
}
