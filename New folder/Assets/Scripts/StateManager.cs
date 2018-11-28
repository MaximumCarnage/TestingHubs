using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {
public GameObject[] m_gameStates;
public Camera m_mainCam;
private GameObject m_activeState;

	// Use this for initialization
	void Start () {
		int numStates = m_gameStates.Length;
	for(int i=0;i<numStates;i++){
		m_gameStates[i].SetActive(false);
	
	}
		m_activeState=m_gameStates[1];
		m_activeState.SetActive(true);
		
	}
	void Update(){
		// if(m_activeState==m_gameStates[0]){
		// 	StartCoroutine(Splash());
		// }
	}
	IEnumerator Splash(){
		yield return new WaitForSeconds(3);
		Menu();
	}
	public void Exit(){
		Debug.Log("Quitting");
		Application.Quit();
	}
	public void Menu(){
		Debug.Log("Pressed Menu");
		m_activeState.SetActive(false);
		m_activeState = m_gameStates[1];
		m_activeState.SetActive(true);
	}
	public void Scores(){
		Debug.Log("Pressed Scores");
		m_activeState.SetActive(false);
		m_activeState = m_gameStates[4];
		m_activeState.SetActive(true);
	}
	public void GameOver(){
		Debug.Log("Pressed Game Over");
		m_activeState.SetActive(false);
		m_activeState = m_gameStates[3];
		m_activeState.SetActive(true);
		
	}
	public void PlayGame(){
		Debug.Log("Pressed Play Game");
		m_activeState.SetActive(false);
		m_mainCam.GetComponent<CameraScroll>().enabled=true;
		m_activeState = m_gameStates[2];
		m_activeState.SetActive(true);
	}
}
