using System;

public class Desafio1
{
	private int valor;
	private int dobro;
	private int triplo;
	private float raiz;

	public int Valor { get => valor; set => valor = value; }
	public int Dobro { get => dobro; set => dobro = value; }
	public float Raiz { get => raiz; set => raiz = value; }
	public int Triplo { get => valor; set => valor = value; }

	Console.Write("Informe o valor: ");
	valor = ReadLine();

	dobro = valor*2;
	WriteLine(dobro);
}
