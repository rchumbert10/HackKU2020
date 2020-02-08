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

// class ReadFile {
	// static void Main(){
		// string dataFile[];
		// string fileName = ("test.txt"); //needs to take whatever file is given by API
		// dataFile[] = File.ReadAllLines(fileName);
	// }
// }

class weatherType{
	public static void Main(String[] arg0{
		//Usinga list instead of an arry soI can shuffle/randomize the weather
		List<string> weather = new List<string>();
		//4 main weather types
		weather.Add("Snowy");
		weather.Add("Cloudy");
		weather.Add("Rainy");
		weather.Add("Sunny");
		//Effectivly randomizes the list
		shuffledList = weather.OrderBy( x => Random.value ).ToList( );
	}
}
