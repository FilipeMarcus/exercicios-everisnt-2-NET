using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String ossos; //declare as suas variaveis
        String raca;
        String comida;

        ossos = Console.ReadLine(); //insira suas variaveis
        raca = Console.ReadLine();
        comida = Console.ReadLine();

      if (( ossos  == "vertebrado") && ( raca == "ave") && ( comida == "carnivoro")) {
      Console.WriteLine("aguia\n");
    }

     if (( ossos  == "vertebrado") && ( raca == "ave") && ( comida == "onivoro")) {
      Console.WriteLine("pomba\n");
    }

     if (( ossos  == "vertebrado") && ( raca == "mamifero") && ( comida == "onivoro")) {
      Console.WriteLine("homem\n");
    }

     if (( ossos  == "vertebrado") && ( raca == "mamifero") && ( comida == "herbivoro")) {
      Console.WriteLine("vaca\n");
    }

     if (( ossos  == "invertebrado") && ( raca == "inseto") && ( comida == "hematofago")) {
      Console.WriteLine("pulga\n");
    }

     if (( ossos  == "invertebrado") && ( raca == "inseto") && ( comida == "herbivoro")) {
      Console.WriteLine("lagarta\n");
    }

    if (( ossos  == "invertebrado") && ( raca == "anelideo") && ( comida == "hematofago")) {
      Console.WriteLine("sanguessuga\n");
    }
    
    if (( ossos == "invertebrado") && ( raca == "anelideo") && ( comida == "onivoro")) {
      Console.WriteLine("minhoca\n");
    }

  }
}