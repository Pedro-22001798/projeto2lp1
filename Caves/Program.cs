using System;

namespace Caves
{
    class Program
    {
        static void Main(string[] args)
        {
			int largura, altura, num_creations;
			
			Console.WriteLine("Insira a largura desejada");
			largura = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Insira a altura desejada");
			altura = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Insira o número de repetições");
			num_creations = Convert.ToInt32(Console.ReadLine());
			
            string [,] world = new string[largura, altura];
			string [,] newWorld = new string[largura, altura];
			string [,] auxWorld = new string[largura, altura];
			
			int i, j, n, random, vizinhos;
			Random aleatorio = new Random();

			for(i = 0; i < altura; i++)
			{
				for(j = 0; j < largura; j++)
				{
					random = aleatorio.Next(1,3);
					if(random == 1)
					{
						world[i,j] = "#";
					}
					else
					{
						world[i,j] = ".";
					}
					
				}
			}
			
			
			for(n = 0; n < num_creations; n++)
			{

			for(i = 0; i < altura; i++)
			{
				for(j = 0; j < largura; j++)
				{
					vizinhos = 0;
					if(i < altura-1)
					{
						if(world[i+1,j] == ".")
						{
							vizinhos++;
						}
					}
					if(i > 0)
					{
						if(world[i-1,j] == ".")
						{
							vizinhos++;
						}
					}
					if(j > 0)
					{
						if(world[i,j-1] == ".")
						{
							vizinhos++;
						}
					}
					if(j < largura-1)
					{
						if(world[i,j+1] == ".")
						{
							vizinhos++;
						}
					}
					if(j < largura-1 && i < altura-1)
					{
						if(world[i+1,j+1] == ".")
						{
							vizinhos++;
						}
					}
					if(j > 0 && i > 0)
					{
						if(world[i-1,j-1] == ".")
						{
							vizinhos++;
						}
					}
					if(j < largura-1 && i > 0)
					{
						if(world[i-1,j+1] == ".")
						{
							vizinhos++;
						}
					}
					if(j > 0 && i < altura-1)
					{
						if(world[i+1,j-1] == ".")
						{
							vizinhos++;
						}
					}
					
					if(vizinhos >= 5)
					{
						newWorld[i,j] = ".";
					}
					else
					{
						newWorld[i,j] = "#";
					}
				}
				
			}
			
			
			for(i = 0; i < altura; i++)
			{
				for(j = 0; j < largura; j++)
				{
					auxWorld[i,j] = world[i,j];
				}
			}
			for(i = 0; i < altura; i++)
			{
				for(j = 0; j < largura; j++)
				{
					world[i,j] = newWorld[i,j];
				}
			}
			for(i = 0; i < altura; i++)
			{
				for(j = 0; j < largura; j++)
				{
					newWorld[i,j] = auxWorld[i,j];
				}
			}

			
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine("New World");
			for(i = 0; i < altura; i++)
			{
				for(j = 0; j < largura; j++)
				{
					Console.Write(newWorld[i,j] + " ");
				}
				Console.WriteLine(" ");
			}			
        }
		
		}
    }
}
