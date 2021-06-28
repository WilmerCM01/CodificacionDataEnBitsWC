using System;

namespace Programas
{
    class Program
    {

        static void verificar(short info, short edad){

            short femenino = 0b_0000_0010_0000_0000;
            short casado = 0b_0000_0001_0000_0000;
            short medio = 0b_0000_1000_0000_0000;
            short grado = 0b_0000_0100_0000_0000;
            short pos = 0b_0000_1100_0000_0000;
            short contador = 0;

            while(contador < 120){

                contador+=1;

                if((info & edad) == contador){

                    Console.WriteLine("Edad: " + (info & edad));

                }

            }

            if((info & femenino) == 512){

                Console.WriteLine("Sexo: Femenino");

            }else{

                Console.WriteLine("Sexo: Masculino");

            }
            if((info & casado) == 256){

                Console.WriteLine("Estado civil: Casado");

            }else{

                Console.WriteLine("Estado civil: Soltero");

            }
            if((info & pos) == 3072){

                Console.WriteLine("Grado académico: Posgrado");

            }
            else if((info & grado) == 1024){

                Console.WriteLine("Grado académico: Grado");

            }
            else if((info & medio) == 2048){

                Console.WriteLine("Grado académico: Medio");

            }
            else{

                Console.WriteLine("Grado académico: Inicial");

            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine();

            Console.Write("Introduzca su edad: ");
            short edad = short.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Introduzca su sexo: ");
            Console.WriteLine("1- Masculino");
            Console.WriteLine("2- Femenino");
            Console.WriteLine();
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Introduzca su estado civil");
            Console.WriteLine("1- Soltero");
            Console.WriteLine("2- Casado");
            Console.WriteLine();
            char estado = char.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Introduzca su grado académico: ");
            Console.WriteLine("1- Inicial");
            Console.WriteLine("2- Medio");
            Console.WriteLine("3- Grado");
            Console.WriteLine("4- Posgrado");
            Console.WriteLine();
            char academico = char.Parse(Console.ReadLine());

            Console.WriteLine();

            short info = 0b_0000_0000_0000_0000;
            short femenino = 0b_0000_0010_0000_0000;
            short casado = 0b_0000_0001_0000_0000;
            short medio = 0b_0000_1000_0000_0000;
            short grado = 0b_0000_0100_0000_0000;
            short pos = 0b_0000_1100_0000_0000;

            info = (short)(info | edad);

            if(sexo.Equals('2')){

                info = (short)(info | femenino);

            }

            if(estado.Equals('2')){

                info = (short)(info | casado);

            }

            if(academico.Equals('2')){

                info = (short)(info | medio);

            }
            else if(academico.Equals('3')){

                info = (short)(info | grado);

            }
            else if(academico.Equals('4')){

                info = (short)(info | pos);

            }

            verificar(info, edad);
            Console.WriteLine();

        }
    }
}