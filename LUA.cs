/*
	Create by: Jonatha Rihan (RBioZ)
	07.11.2019
	Version 1.0
	UTF-8
*/

using System;
using System.Collections.Generic;


public class MainClass
{
  public static void Main (string[] args)
  {
	  //Variaveis
		int n = 0;
	  	int m = 0;
	  	string text = "";
	    List<double> maior_menor = new List<double>{};
	  	int counter = 1;

	  //Inicio do Loop no Main
	  do{
	  
	  	text = Console.ReadLine();
	  
	  //Input de dados M e N
		for(int i = 0; i <= text.Length-1; i++)
		{
			if(text[i] == Convert.ToChar(" "))
			{
				n = Convert.ToInt32(text.Substring(0, i));
				m = Convert.ToInt32(text.Substring(i+1, i));	
			}
			
		}
	  
	  //Condicional de validação
	  if((n <= 0 || n >= 10000) || (m <= 1 || m >= n))
	  {
		    if(n == 0 && m == 0)
			{
				break;
			}
	  		Console.WriteLine("Valores Invalidos");
		  	continue;
	  }
		  
	  int[] temp = new int[n];  
	  for(int z = 0; z<n; z++)
	  {
	      temp[z] = Convert.ToInt32(Console.ReadLine());
	  }
		  	maior_menor.Add(Menor(temp, m));
			maior_menor.Add(Maior(temp, m));
		  
	  }while(n != 0 && m!= 0);
	  //Fim do Loop no Main
	  
	  for(int y = 0;y<maior_menor.Count;y+=2)
	  {	  
		  Console.WriteLine("Teste {0}", counter);
		  Console.WriteLine("{0} {1}", maior_menor[y],maior_menor[y+1]);
		  counter++;
	  }
	  Console.ReadKey(); 
  }
	//Metodo para encontrar maior numero
	public static double Maior(int[] temp, int m)
	{
		double maior = -200;
		for(int i = 0; i<temp.Length - m+1;i++)
		{		
			int num = 0;
			for(int p = i;p<i+m;p++)
			{
				num+=temp[p];
			}
			num = num/m;
			if(num>=maior)
			{
				maior = num;
			}
		}
		
		return maior;
	}
	
	//Metodo para encontrar menor numero
	public static double Menor(int[] temp,int m)
	{
		double menor = 200;
		for(int i = 0; i<temp.Length - m+1;i++)
		{		
			int num = 0;
			for(int p = i;p<i+m;p++)
			{
				num+=temp[p];
			}
			num = num/m;
			if(num<=menor)
			{
				menor = num;
			}
		}
		
		return menor;
	}
}

