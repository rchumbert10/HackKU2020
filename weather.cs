using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;
using System.Serialzable;

//HackKU - Project Petshop
//Camryn Moy
//This will read through the data files so that
//we can get the current conditions for  the game


class weatherType{
	public static void Main(String[] arg){
		//Usinga list instead of an arry soI can shuffle/randomize the weather
		List<string> weather = new List<string>();
		//4 main weather types
		weather.Add("Snowy");
		weather.Add("Cloudy");
		weather.Add("Rainy");
		weather.Add("Sunny");
		//Effectivly randomizes the list
		shuffledList = weather.OrderBy( x => Random.value ).ToList( );
		weather = shuffledList;
		int i = 0;
		//for loop to change the weather 
		while (i != shuffledList.Capacity){		//while i is not equal to the list size (hasn't gone through entire list)
			i++;
			for(i = 1; i <= shuffledList.Capacity ; i++){
				if(i <= shuffledList.Capacity){
					i++;					//i inrease to next part of list
					weather = weather[i]; //move to next weather condition
				}
				if(i > shuffledList.Capacity){
					weather = shuffledList;		//reshuffle list
					i = 0;					//reset counter
				}
			}
		}
	}
}
